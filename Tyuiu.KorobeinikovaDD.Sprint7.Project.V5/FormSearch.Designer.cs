namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            groupBoxSearch = new GroupBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridViewSearch = new DataGridView();
            panel1 = new Panel();
            buttonPA = new Button();
            buttonPD = new Button();
            buttonQA = new Button();
            buttonQD = new Button();
            panelQ = new Panel();
            panel3 = new Panel();
            toolTipInfo = new ToolTip(components);
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            panel1.SuspendLayout();
            panelQ.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Controls.Add(textBoxSearch);
            groupBoxSearch.Location = new Point(12, 7);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(776, 75);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Поиск";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.Location = new Point(698, 20);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(62, 44);
            buttonSearch.TabIndex = 1;
            toolTipInfo.SetToolTip(buttonSearch, "Нажмите на кнопку, чтобы найти нужный товар");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Location = new Point(3, 26);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(689, 35);
            textBoxSearch.TabIndex = 0;
            toolTipInfo.SetToolTip(textBoxSearch, "Введите в строку поиска код или название товара");
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Dock = DockStyle.Fill;
            dataGridViewSearch.Location = new Point(0, 0);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowHeadersWidth = 51;
            dataGridViewSearch.Size = new Size(776, 305);
            dataGridViewSearch.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridViewSearch);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 305);
            panel1.TabIndex = 2;
            // 
            // buttonPA
            // 
            buttonPA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPA.Image = (Image)resources.GetObject("buttonPA.Image");
            buttonPA.Location = new Point(14, 7);
            buttonPA.Name = "buttonPA";
            buttonPA.Size = new Size(94, 29);
            buttonPA.TabIndex = 3;
            buttonPA.UseVisualStyleBackColor = true;
            buttonPA.Click += buttonSortAscendingPrice_Click;
            // 
            // buttonPD
            // 
            buttonPD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPD.Image = (Image)resources.GetObject("buttonPD.Image");
            buttonPD.Location = new Point(14, 42);
            buttonPD.Name = "buttonPD";
            buttonPD.Size = new Size(94, 29);
            buttonPD.TabIndex = 4;
            buttonPD.UseVisualStyleBackColor = true;
            buttonPD.Click += buttonSortDescendingPrice_Click;
            // 
            // buttonQA
            // 
            buttonQA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonQA.Image = (Image)resources.GetObject("buttonQA.Image");
            buttonQA.Location = new Point(13, 7);
            buttonQA.Name = "buttonQA";
            buttonQA.Size = new Size(94, 29);
            buttonQA.TabIndex = 5;
            buttonQA.UseVisualStyleBackColor = true;
            buttonQA.Click += buttonSortAscendingE_Click;
            // 
            // buttonQD
            // 
            buttonQD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonQD.Image = (Image)resources.GetObject("buttonQD.Image");
            buttonQD.Location = new Point(13, 42);
            buttonQD.Name = "buttonQD";
            buttonQD.Size = new Size(94, 29);
            buttonQD.TabIndex = 6;
            buttonQD.UseVisualStyleBackColor = true;
            buttonQD.Click += buttonSortDescendingE_Click;
            // 
            // panelQ
            // 
            panelQ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelQ.Controls.Add(buttonQA);
            panelQ.Controls.Add(buttonQD);
            panelQ.Location = new Point(12, 399);
            panelQ.Name = "panelQ";
            panelQ.Size = new Size(122, 74);
            panelQ.TabIndex = 7;
            toolTipInfo.SetToolTip(panelQ, "Cортировка по количеству штук на складе\r\n(Первая кнопка сортирует сверху-вниз, вторая - снизу-вверх)\r\n");
            panelQ.Paint += panelQ_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(buttonPA);
            panel3.Controls.Add(buttonPD);
            panel3.Location = new Point(140, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 74);
            panel3.TabIndex = 8;
            toolTipInfo.SetToolTip(panel3, "Cортировка по цене за единицу \r\n(Первая кнопка сортирует сверху-вниз, вторая - снизу-вверх)\r\n");
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Подсказка";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 476);
            Controls.Add(panel3);
            Controls.Add(panelQ);
            Controls.Add(panel1);
            Controls.Add(groupBoxSearch);
            MinimumSize = new Size(821, 523);
            Name = "FormSearch";
            Text = "Поиск";
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            panel1.ResumeLayout(false);
            panelQ.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSearch;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewSearch;
        private Panel panel1;
        private Button buttonPA;
        private Button buttonPD;
        private Button buttonQA;
        private Button buttonQD;
        private Panel panelQ;
        private ToolTip toolTipInfo;
        private Panel panel3;
    }
}