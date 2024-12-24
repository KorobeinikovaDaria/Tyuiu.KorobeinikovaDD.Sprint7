using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }
        private void buttonQuantity_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DrawChartQuantity(dataTable);

                CalculateMinAndMaxQuantity(dataTable);
            }
        }

        private DataTable dataTable;

        public void SetData(DataTable data)
        {
            dataTable = data;
        }

        private void DrawChartQuantity(DataTable data)
        {
            try
            {
                chartQandP.Series.Clear();
                int seriesCount = 0;

                Debug.WriteLine("Data in DataTable:");
                foreach (DataRow row in data.Rows)
                {
                    Debug.WriteLine($"Название: {row["Название"]}, Количество: {row["Количество штук на складе"]}");
                }

                int maxQuantity = 0;
                foreach (DataRow row in data.Rows)
                {
                    string quantityStr = row["Количество штук на складе"]?.ToString()?.Trim();
                    if (int.TryParse(quantityStr, out int quantity))
                    {
                        if (quantity > maxQuantity)
                        {
                            maxQuantity = quantity;
                        }
                    }
                }

                foreach (DataRow row in data.Rows)
                {
                    string name = row["Название"]?.ToString()?.Trim();
                    string quantityStr = row["Количество штук на складе"]?.ToString()?.Trim();

                    if (int.TryParse(quantityStr, out int quantity))
                    {
                        Series newSeries = new Series(name)
                        {
                            ChartType = SeriesChartType.Column,
                            IsValueShownAsLabel = true
                        };

                        double xValue = seriesCount + 1;
                        newSeries.Points.AddXY(xValue, quantity);

                        chartQandP.Series.Add(newSeries);
                        seriesCount++;
                    }
                }

                foreach (var series in chartQandP.Series)
                {
                    series["PointWidth"] = "0.8";
                }

                chartQandP.ChartAreas[0].AxisY.Minimum = 0;
                chartQandP.ChartAreas[0].AxisY.Maximum = maxQuantity + 100;
                chartQandP.ChartAreas[0].AxisY.Interval = 100;

                chartQandP.ChartAreas[0].AxisX.Minimum = 0.5;
                chartQandP.ChartAreas[0].AxisX.Maximum = seriesCount + 0.5;
                chartQandP.ChartAreas[0].AxisX.IsStartedFromZero = false;
                chartQandP.ChartAreas[0].AxisX.Interval = 1;

                chartQandP.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                chartQandP.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void CalculateMinAndMaxQuantity(DataTable data)
        {
            try
            {
                var quantities = data.AsEnumerable()
                    .Select(row => row.Field<string>("Количество штук на складе"))
                    .Where(s => int.TryParse(s, out _))
                    .Select(int.Parse)
                    .ToList();

                if (quantities.Count > 0)
                {
                    int minQuantity = quantities.Min();
                    int maxQuantity = quantities.Max();

                    textBoxMin.Text = minQuantity.ToString();
                    textBoxMax.Text = maxQuantity.ToString();
                }
                else
                {
                    textBoxMin.Text = "Нет данных";
                    textBoxMax.Text = "Нет данных";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                textBoxMin.Enabled = true;
                textBoxMax.Enabled = true;
            }
        }


        private void buttonPrice_Click(object sender, EventArgs e)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DrawChartPrice(dataTable);

                CalculateMinAndMaxPrice(dataTable);
            }
        }

        private void DrawChartPrice(DataTable data)
        {
            try
            {
                chartQandP.Series.Clear();
                int seriesCount = 0;

                Debug.WriteLine("Data in DataTable:");
                foreach (DataRow row in data.Rows)
                {
                    Debug.WriteLine($"Название: {row["Название"]}, Цена: {row["Цена за единицу"]}");
                }

                int maxQuantity = 0;
                foreach (DataRow row in data.Rows)
                {
                    string quantityStr = row["Цена за единицу"]?.ToString()?.Trim();
                    if (int.TryParse(quantityStr, out int quantity))
                    {
                        if (quantity > maxQuantity)
                        {
                            maxQuantity = quantity;
                        }
                    }
                }
                foreach (DataRow row in data.Rows)
                {
                    string name = row["Название"]?.ToString()?.Trim();
                    string priceStr = row["Цена за единицу"]?.ToString()?.Trim();

                    if (double.TryParse(priceStr, out double price))
                    {
                        Series newSeries = new Series(name)
                        {
                            ChartType = SeriesChartType.Column,
                            IsValueShownAsLabel = true
                        };

                        double xValue = seriesCount + 1;
                        newSeries.Points.AddXY(xValue, price);

                        chartQandP.Series.Add(newSeries);
                        seriesCount++;
                    }
                }

                foreach (var series in chartQandP.Series)
                {
                    series["PointWidth"] = "0.8";
                }

                chartQandP.ChartAreas[0].AxisY.Minimum = 0;
                chartQandP.ChartAreas[0].AxisY.Maximum = maxQuantity + 5000;
                chartQandP.ChartAreas[0].AxisY.Interval = 5000;

                chartQandP.ChartAreas[0].AxisX.Minimum = 0.5;
                chartQandP.ChartAreas[0].AxisX.Maximum = seriesCount + 0.5;
                chartQandP.ChartAreas[0].AxisX.IsStartedFromZero = false;
                chartQandP.ChartAreas[0].AxisX.Interval = 1;

                chartQandP.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                chartQandP.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void CalculateMinAndMaxPrice(DataTable data)
        {
            try
            {
                var quantities = data.AsEnumerable()
                    .Select(row => row.Field<string>("Цена за единицу"))
                    .Where(s => int.TryParse(s, out _))
                    .Select(int.Parse)
                    .ToList();

                if (quantities.Count > 0)
                {
                    int minQuantity = quantities.Min();
                    int maxQuantity = quantities.Max();

                    textBoxMin.Text = minQuantity.ToString();
                    textBoxMax.Text = maxQuantity.ToString();
                }
                else
                {
                    textBoxMin.Text = "Нет данных";
                    textBoxMax.Text = "Нет данных";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}


