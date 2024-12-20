namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    partial class FormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            button2 = new Button();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            toolTipInfo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(12, 81);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(755, 367);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            toolTipInfo.SetToolTip(chart1, "Гистограмма, которая показывает количество штук на складе/цену за единицу товара\r\n");
            // 
            // button1
            // 
            button1.Image = Properties.Resources.package;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 63);
            button1.TabIndex = 1;
            toolTipInfo.SetToolTip(button1, "Высчитать количество штук на складе");
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonQuantity_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(112, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 63);
            button2.TabIndex = 2;
            toolTipInfo.SetToolTip(button2, "Высчитать цену за единицу");
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonPrice_Click;
            // 
            // textBoxMin
            // 
            textBoxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMin.Location = new Point(642, 35);
            textBoxMin.Multiline = true;
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(125, 35);
            textBoxMin.TabIndex = 3;
            toolTipInfo.SetToolTip(textBoxMin, "Минимальное значение количества штук на складе/цены за единицу товара\r\n");
            // 
            // textBoxMax
            // 
            textBoxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMax.Location = new Point(504, 35);
            textBoxMax.Multiline = true;
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(125, 35);
            textBoxMax.TabIndex = 4;
            toolTipInfo.SetToolTip(textBoxMax, "Максимальное значение количества штук на складе/цены за единицу товара");
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(504, 12);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "Максимум:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(642, 12);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Минимум:";
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Подсказка";
            toolTipInfo.Popup += toolTip1_Popup;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 461);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxMin);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chart1);
            MinimumSize = new Size(805, 508);
            Name = "FormStatistics";
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
        private Button button2;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label1;
        private Label label2;
        private ToolTip toolTipInfo;
    }
}