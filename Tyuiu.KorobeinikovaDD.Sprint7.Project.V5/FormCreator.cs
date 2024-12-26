using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    public partial class FormCreator : Form
    {
        public FormCreator()
        {
            InitializeComponent();
            InitializeDataTable();
            dataGridViewData.DataSource = dataTable;
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
            buttonStatistics.Enabled = true;
            buttonSearch.Enabled = true;
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                if (dataTable == null)
                {
                    InitializeDataTable();
                }
                else
                {
                    dataTable.Clear(); 
                }

                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines.Skip(1))
                {
                    var values = ParseCsvLine(line);

                    if (values.Length == 5)
                    {
                        dataTable.Rows.Add(values);
                    }
                }
                dataGridViewData.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

        private string[] ParseCsvLine(string line)
        {
            var result = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(sb.ToString().Trim());
                    sb.Clear();
                }
                else
                {
                    sb.Append(c);
                }
            }

            result.Add(sb.ToString().Trim());

            return result.ToArray();
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
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out _) || !decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Введите числовое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataTable != null)
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
            buttonStatistics.Enabled = true;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Пожалуйста, введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out _) || !decimal.TryParse(txtPrice.Text, out _))
                {
                    MessageBox.Show("Пожалуйста, введите числовое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridViewData.SelectedRows.Count > 0 && dataTable != null)
                {
                    DataGridViewRow selectedRow = dataGridViewData.SelectedRows[0];

                    selectedRow.Cells["Код товара"].Value = txtProductCode.Text;
                    selectedRow.Cells["Название"].Value = txtProductName.Text;
                    selectedRow.Cells["Количество штук на складе"].Value = txtQuantity.Text;
                    selectedRow.Cells["Цена за единицу"].Value = txtPrice.Text;
                    selectedRow.Cells["Описание товара"].Value = txtDescription.Text;

                    DataRow rowToUpdate = dataTable.Rows[selectedRow.Index];
                    rowToUpdate["Код товара"] = txtProductCode.Text;
                    rowToUpdate["Название"] = txtProductName.Text;
                    rowToUpdate["Количество штук на складе"] = txtQuantity.Text;
                    rowToUpdate["Цена за единицу"] = txtPrice.Text;
                    rowToUpdate["Описание товара"] = txtDescription.Text;

                    ClearTextBoxes();
                }
                 else
                {
                MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
            buttonSave.Enabled = true;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (dataGridViewData.SelectedRows.Count > 0 && dataTable != null)
                {
                    int index = dataGridViewData.SelectedRows[0].Index;

                    dataTable.Rows.RemoveAt(index);
                    dataGridViewData.Rows.RemoveAt(index);

                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           
                buttonSave.Enabled = true;
            
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutputData.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                using (StreamWriter writer = new StreamWriter(path))
                {

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(dataTable.Columns[i]);
                        if (i < dataTable.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();


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

                MessageBox.Show($"Файл '{path}' успешно сохранен!");
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
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewData.SelectedRows[0];
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

            if (dataTable != null)
            {
                filterForm.SetData(dataTable.Copy());
            }

            filterForm.Show();
        }

        private void buttonOpenStatisticsForm_Click(object sender, EventArgs e)
        {
            FormStatistics formStats = new FormStatistics();
            formStats.SetData(dataTable);
            formStats.Show();
        }

        private void buttonOpenAboutForm_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.Show();
        }

        private void buttonOpenInfoForm_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }
        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTipInfo_Popup(object sender, PopupEventArgs e)
        {

        }

      
    }
}
  

