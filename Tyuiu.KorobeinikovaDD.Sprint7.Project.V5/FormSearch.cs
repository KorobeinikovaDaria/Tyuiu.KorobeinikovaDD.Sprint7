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
            dataGridView2.AutoGenerateColumns = true;
        }

        public void SetData(DataTable data)
        {
            dataTable = data;
            dataGridView2.DataSource = data;
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
        private DataServiceSort dataServiceSort = new DataServiceSort();
        private void buttonSortAscendingE_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sortedTable = dataServiceSort.SortColumnAscending(dataTable, "Количество штук на складе");
                dataGridView2.DataSource = sortedTable; 
                dataGridView2.Refresh(); 
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
                dataGridView2.DataSource = sortedTable;
                dataGridView2.Refresh();
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
                    dataGridView2.DataSource = sortedTable; 
                    dataGridView2.Refresh(); 
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
                    dataGridView2.DataSource = sortedTable;
                    dataGridView2.Refresh();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
    } 
    

  
