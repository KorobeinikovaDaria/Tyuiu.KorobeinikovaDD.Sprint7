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
                openFileDialog.Title = "�������� ����";

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

                // ��������� ������� � DataTable
                dataTable.Columns.Add("��� ������");
                dataTable.Columns.Add("��������");
                dataTable.Columns.Add("���������� ���� �� ������");
                dataTable.Columns.Add("���� �� �������");
                dataTable.Columns.Add("�������� ������");

                // ��������� DataTable ������� �� �����
                foreach (var line in lines.Skip(1)) // ���������� ���������
                {
                    var values = line.Split(',');

                    // ���������, ��� ���������� �������� ������������� ���������� ��������
                    if (values.Length == 5)
                    {
                        dataTable.Rows.Add(values);
                    }
                }

                // ������������� �������� ������ ��� DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� �����: {ex.Message}");
            }

        }
        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("��� ������");
            dataTable.Columns.Add("��������");
            dataTable.Columns.Add("���������� ���� �� ������");
            dataTable.Columns.Add("���� �� �������");
            dataTable.Columns.Add("�������� ������");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["��� ������"] = txtProductCode.Text;
            newRow["��������"] = txtProductName.Text;
            newRow["���������� ���� �� ������"] = txtQuantity.Text;
            newRow["���� �� �������"] = txtPrice.Text;
            newRow["�������� ������"] = txtDescription.Text;

            dataTable.Rows.Add(newRow);
            ClearTextBoxes();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["��� ������"].Value = txtProductCode.Text;
                selectedRow.Cells["��������"].Value = txtProductName.Text;
                selectedRow.Cells["���������� ���� �� ������"].Value = txtQuantity.Text;
                selectedRow.Cells["���� �� �������"].Value = txtPrice.Text;
                selectedRow.Cells["�������� ������"].Value = txtDescription.Text;
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

            // ���������� ���������� ���� � ��������� ���������
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName; // ���������� ���������� ��� ����������

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                // ���� ���� ����������, ������� ���
                if (fileExists)
                {
                    File.Delete(path);
                }

                // ���������� ������ � ����
                using (StreamWriter writer = new StreamWriter(path)) // ���������� path ������ filePath
                {
                    // ���������� ���������
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(dataTable.Columns[i]);
                        if (i < dataTable.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // ���������� ������ ������
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

                MessageBox.Show($"CSV ���� '{path}' ������� ��������."); // ���������� path ��� ����������� ���������
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
                txtProductCode.Text = selectedRow.Cells["��� ������"].Value.ToString();
                txtProductName.Text = selectedRow.Cells["��������"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["���������� ���� �� ������"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["���� �� �������"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["�������� ������"].Value.ToString();
            }
        }
        private void buttonOpenSearchForm_Click(object sender, EventArgs e)
        {
            FormSearch filterForm = new FormSearch();

            // �������� ������ �� DataTable �� ������ �����
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
  

