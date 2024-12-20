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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBoxSearch = new TextBox();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panelQ = new Panel();
            panel3 = new Panel();
            toolTipInfo = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panelQ.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(698, 20);
            button1.Name = "button1";
            button1.Size = new Size(62, 44);
            button1.TabIndex = 1;
            toolTipInfo.SetToolTip(button1, "Нажмите на кнопку, чтобы найти нужный товар");
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSearch_Click;
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 305);
            dataGridView2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 305);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(14, 7);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSortAscendingPrice_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(14, 42);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSortDescendingPrice_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(13, 7);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonSortAscendingE_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(13, 42);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonSortDescendingE_Click;
            // 
            // panelQ
            // 
            panelQ.Controls.Add(button4);
            panelQ.Controls.Add(button5);
            panelQ.Location = new Point(12, 399);
            panelQ.Name = "panelQ";
            panelQ.Size = new Size(122, 74);
            panelQ.TabIndex = 7;
            toolTipInfo.SetToolTip(panelQ, "Cортировка по количеству штук на складе\r\n(Первая кнопка сортирует сверху-вниз, вторая - снизу-вверх)\r\n");
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
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
            Controls.Add(groupBox1);
            MinimumSize = new Size(821, 523);
            Name = "FormSearch";
            Text = "Поиск";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panelQ.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBoxSearch;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panelQ;
        private ToolTip toolTipInfo;
        private Panel panel3;
    }
}