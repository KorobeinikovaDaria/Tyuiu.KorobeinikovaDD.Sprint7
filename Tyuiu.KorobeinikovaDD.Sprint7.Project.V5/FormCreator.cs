using System.Data;
using System.Windows.Forms;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    public partial class FormCreator : Form
    {
        public FormCreator()
        {
            InitializeComponent();
            InitializeDataTable();
            dataGridView1.DataSource = dataTable;
        }
        private DataTable dataTable;

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadDataFromFile(openFileDialog.FileName);
                }
            }
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var dataTable = new DataTable();

                // Добавляем столбцы в DataTable
                dataTable.Columns.Add("Код товара");
                dataTable.Columns.Add("Название");
                dataTable.Columns.Add("Количество штук на складе");
                dataTable.Columns.Add("Цена за единицу");
                dataTable.Columns.Add("Описание товара");

                // Заполняем DataTable данными из файла
                foreach (var line in lines.Skip(1)) // Пропускаем заголовок
                {
                    var values = line.Split(',');

                    // Убедитесь, что количество значений соответствует количеству столбцов
                    if (values.Length == 5)
                    {
                        dataTable.Rows.Add(values);
                    }
                }

                // Устанавливаем источник данных для DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
            }

        }
        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Код товара");
            dataTable.Columns.Add("Название");
            dataTable.Columns.Add("Количество штук на складе");
            dataTable.Columns.Add("Цена за единицу");
            dataTable.Columns.Add("Описание товара");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["Код товара"] = txtProductCode.Text;
            newRow["Название"] = txtProductName.Text;
            newRow["Количество штук на складе"] = txtQuantity.Text;
            newRow["Цена за единицу"] = txtPrice.Text;
            newRow["Описание товара"] = txtDescription.Text;

            dataTable.Rows.Add(newRow);
            ClearTextBoxes();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Код товара"].Value = txtProductCode.Text;
                selectedRow.Cells["Название"].Value = txtProductName.Text;
                selectedRow.Cells["Количество штук на складе"].Value = txtQuantity.Text;
                selectedRow.Cells["Цена за единицу"].Value = txtPrice.Text;
                selectedRow.Cells["Описание товара"].Value = txtDescription.Text;
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ClearTextBoxes();
            }
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutDataFileTask7V7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            // Показываем диалоговое окно и проверяем результат
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName; // Используем правильное имя переменной

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                // Если файл существует, удаляем его
                if (fileExists)
                {
                    File.Delete(path);
                }

                // Записываем данные в файл
                using (StreamWriter writer = new StreamWriter(path)) // Используем path вместо filePath
                {
                    // Записываем заголовки
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(dataTable.Columns[i]);
                        if (i < dataTable.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Записываем строки данных
                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            writer.Write(row[i]);
                            if (i < dataTable.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"CSV файл '{path}' успешно сохранен."); // Используем path для отображения сообщения
            }
        }

        private void ClearTextBoxes()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtProductCode.Text = selectedRow.Cells["Код товара"].Value.ToString();
                txtProductName.Text = selectedRow.Cells["Название"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Количество штук на складе"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Цена за единицу"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Описание товара"].Value.ToString();
            }
        }
        private void buttonOpenSearchForm_Click(object sender, EventArgs e)
        {
            FormSearch filterForm = new FormSearch();

            // Передаем данные из DataTable во вторую форму
            if (dataTable != null)
            {
                filterForm.SetData(dataTable.Copy());
            }

            filterForm.Show();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
  

