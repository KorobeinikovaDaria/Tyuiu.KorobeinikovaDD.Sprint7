﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KorobeinikovaDD.Sprint7.Project.V5.Lib.Sort;
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
            dataGridViewSearch.AutoGenerateColumns = true;
        }

        public void SetData(DataTable data)
        {
            dataTable = data;
            dataGridViewSearch.DataSource = data;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim();

            if (dataTable != null)
            {
                if (string.IsNullOrEmpty(searchValue))
                {
                    dataGridViewSearch.DataSource = dataTable;
                    return;
                }

                var filteredRows = dataTable.AsEnumerable()
                    .Where(row => row.Field<string>("Код товара").IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                  row.Field<string>("Название").IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    DataTable resultTable = filteredRows.CopyToDataTable();
                    dataGridViewSearch.DataSource = resultTable;
                }
                else
                {
                    dataGridViewSearch.DataSource = null;
                    MessageBox.Show("Нет результатов для поиска.");
                }
            }
        }

        private DataServiceSort dataServiceSort = new DataServiceSort();
        private void buttonSortAscendingE_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sortedTable = dataServiceSort.SortColumnAscending(dataTable, "Количество штук на складе");
                dataGridViewSearch.DataSource = sortedTable;
                dataGridViewSearch.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortDescendingE_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sortedTable = dataServiceSort.SortColumnDescending(dataTable, "Количество штук на складе");
                dataGridViewSearch.DataSource = sortedTable;
                dataGridViewSearch.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortAscendingPrice_Click(object sender, EventArgs e)

        {
            try
            {
                DataTable sortedTable = dataServiceSort.SortColumnAscending(dataTable, "Цена за единицу");
                dataGridViewSearch.DataSource = sortedTable;
                dataGridViewSearch.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSortDescendingPrice_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sortedTable = dataServiceSort.SortColumnDescending(dataTable, "Цена за единицу");
                dataGridViewSearch.DataSource = sortedTable;
                dataGridViewSearch.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelQ_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 
    

  
