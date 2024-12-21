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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            chartQandP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonQ = new Button();
            buttonPrice = new Button();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            toolTipInfo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)chartQandP).BeginInit();
            SuspendLayout();
            // 
            // chartQandP
            // 
            chartQandP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartQandP.ChartAreas.Add(chartArea2);
            chartQandP.Location = new Point(12, 81);
            chartQandP.Name = "chartQandP";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartQandP.Series.Add(series2);
            chartQandP.Size = new Size(755, 367);
            chartQandP.TabIndex = 0;
            chartQandP.Text = "chart1";
            toolTipInfo.SetToolTip(chartQandP, "Гистограмма, которая показывает количество штук на складе/цену за единицу товара\r\n");
            // 
            // buttonQ
            // 
            buttonQ.Image = Properties.Resources.package;
            buttonQ.Location = new Point(12, 12);
            buttonQ.Name = "buttonQ";
            buttonQ.Size = new Size(94, 63);
            buttonQ.TabIndex = 1;
            toolTipInfo.SetToolTip(buttonQ, "Высчитать количество штук на складе");
            buttonQ.UseVisualStyleBackColor = true;
            buttonQ.Click += buttonQuantity_Click;
            // 
            // buttonPrice
            // 
            buttonPrice.Image = (Image)resources.GetObject("buttonPrice.Image");
            buttonPrice.Location = new Point(112, 12);
            buttonPrice.Name = "buttonPrice";
            buttonPrice.Size = new Size(94, 63);
            buttonPrice.TabIndex = 2;
            toolTipInfo.SetToolTip(buttonPrice, "Высчитать цену за единицу");
            buttonPrice.UseVisualStyleBackColor = true;
            buttonPrice.Click += buttonPrice_Click;
            // 
            // textBoxMin
            // 
            textBoxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMin.Enabled = false;
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
            textBoxMax.Enabled = false;
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
            Controls.Add(buttonPrice);
            Controls.Add(buttonQ);
            Controls.Add(chartQandP);
            MinimumSize = new Size(805, 508);
            Name = "FormStatistics";
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chartQandP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartQandP;
        private Button buttonQ;
        private Button buttonPrice;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label1;
        private Label label2;
        private ToolTip toolTipInfo;
    }
}