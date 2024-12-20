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
                chart1.Series.Clear();
                int seriesCount = 0;

                Debug.WriteLine("Data in DataTable:");
                foreach (DataRow row in data.Rows)
                {
                    Debug.WriteLine($"Название: {row["Название"]}, Количество: {row["Количество штук на складе"]}");
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

                        chart1.Series.Add(newSeries);
                        seriesCount++;
                    }
                }

                foreach (var series in chart1.Series)
                {
                    series["PointWidth"] = "0.8";
                }


                chart1.ChartAreas[0].AxisX.Minimum = 0.5;
                chart1.ChartAreas[0].AxisX.Maximum = seriesCount + 0.5;
                chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
                chart1.ChartAreas[0].AxisX.Interval = 1;

                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                chart1.Refresh();
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
                chart1.Series.Clear();
                int seriesCount = 0;

                Debug.WriteLine("Data in DataTable:");
                foreach (DataRow row in data.Rows)
                {
                    Debug.WriteLine($"Название: {row["Название"]}, Цена: {row["Цена за единицу"]}");
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

                        chart1.Series.Add(newSeries);
                        seriesCount++;
                    }
                }

                foreach (var series in chart1.Series)
                {
                    series["PointWidth"] = "0.8";
                }

                // Настройка оси Y для отображения значений от 0 до 100000
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 100000;
                chart1.ChartAreas[0].AxisY.Interval = 10000;

                chart1.ChartAreas[0].AxisX.Minimum = 0.5;
                chart1.ChartAreas[0].AxisX.Maximum = seriesCount + 0.5;
                chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
                chart1.ChartAreas[0].AxisX.Interval = 1;

                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                chart1.Refresh();
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


