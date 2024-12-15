using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    public partial class FormSearch : Form
    {
        private DataTable dataTable;

        public FormSearch()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView2.AutoGenerateColumns = true; // Автоматическая генерация колонок
        }

        public void SetData(DataTable data)
        {
            dataTable = data; // Сохраняем данные
            dataGridView2.DataSource = data; // Устанавливаем данные в DataGridView
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue) && dataTable != null)
            {
                var filteredRows = dataTable.AsEnumerable()
                    .Where(row => row.Field<string>("Код товара").Contains(searchValue) ||
                                  row.Field<string>("Название").Contains(searchValue));

                dataGridView2.DataSource = filteredRows.CopyToDataTable();
            }
        }

    }
}

  
