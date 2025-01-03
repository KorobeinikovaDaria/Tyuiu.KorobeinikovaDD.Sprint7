﻿namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    partial class FormCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreator));
            buttonOpen = new Button();
            buttonCreate = new Button();
            buttonSave = new Button();
            button4 = new Button();
            dataGridViewData = new DataGridView();
            groupBox1 = new GroupBox();
            txtProductCode = new TextBox();
            groupBox2 = new GroupBox();
            panel5 = new Panel();
            label5 = new Label();
            txtDescription = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txtPrice = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            txtQuantity = new TextBox();
            panel2 = new Panel();
            txtProductName = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            buttonAdd = new Button();
            saveFileDialog1 = new SaveFileDialog();
            buttonSearch = new Button();
            buttonStatistics = new Button();
            buttonHelp = new Button();
            buttonInfo = new Button();
            toolTipInfo = new ToolTip(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 12;
            label2.Text = "Введите название товара:";
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(81, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 58);
            buttonOpen.TabIndex = 0;
            toolTipInfo.SetToolTip(buttonOpen, "Открыть файл в формате csv");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += btnLoadFile_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCreate.Image = (Image)resources.GetObject("buttonCreate.Image");
            buttonCreate.Location = new Point(815, 12);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 58);
            buttonCreate.TabIndex = 1;
            toolTipInfo.SetToolTip(buttonCreate, "Редактировать данные (заменить строку)");
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonEdit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(181, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 58);
            buttonSave.TabIndex = 2;
            toolTipInfo.SetToolTip(buttonSave, "Сохранить файл в формате csv");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSaveFile_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(915, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 58);
            button4.TabIndex = 3;
            toolTipInfo.SetToolTip(button4, "Удалить данные (удалить строку)");
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDelete_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(3, 23);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(591, 378);
            dataGridViewData.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewData);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 404);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(3, 26);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(242, 27);
            txtProductCode.TabIndex = 6;
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(615, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 336);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtDescription);
            panel5.Location = new Point(16, 265);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 51);
            panel5.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 12;
            label5.Text = "Введите описание товара:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(3, 24);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(242, 27);
            txtDescription.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtPrice);
            panel4.Location = new Point(16, 206);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 53);
            panel4.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.CausesValidation = false;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 11;
            label4.Text = "Введите цену за единицу:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(0, 23);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(245, 27);
            txtPrice.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtQuantity);
            panel3.Location = new Point(16, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 53);
            panel3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 1);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 13;
            label3.Text = "Введите количество штук на складе:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(3, 24);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(242, 27);
            txtQuantity.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 54);
            panel2.TabIndex = 14;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(3, 23);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(242, 27);
            txtProductName.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtProductCode);
            panel1.Location = new Point(16, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 61);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 7;
            label1.Text = "Введите код товара:";
            label1.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(715, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 58);
            buttonAdd.TabIndex = 8;
            toolTipInfo.SetToolTip(buttonAdd, "Добавить данные (добавить строку)");
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += btnAdd_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSearch.Enabled = false;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.Location = new Point(915, 422);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 58);
            buttonSearch.TabIndex = 9;
            toolTipInfo.SetToolTip(buttonSearch, "Открыть окно поиска");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonOpenSearchForm_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStatistics.Enabled = false;
            buttonStatistics.Image = (Image)resources.GetObject("buttonStatistics.Image");
            buttonStatistics.Location = new Point(815, 422);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(94, 58);
            buttonStatistics.TabIndex = 10;
            toolTipInfo.SetToolTip(buttonStatistics, "Открыть окно графика");
            buttonStatistics.UseVisualStyleBackColor = true;
            buttonStatistics.Click += buttonOpenStatisticsForm_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(12, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(63, 58);
            buttonHelp.TabIndex = 11;
            toolTipInfo.SetToolTip(buttonHelp, "Руководство пользователя");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonOpenAboutForm_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(615, 422);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(63, 58);
            buttonInfo.TabIndex = 12;
            toolTipInfo.SetToolTip(buttonInfo, "Информация о программе");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonOpenInfoForm_Click;
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Подсказка";
            toolTipInfo.Popup += toolTipInfo_Popup;
            // 
            // FormCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 495);
            Controls.Add(buttonInfo);
            Controls.Add(buttonHelp);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(buttonSave);
            Controls.Add(buttonCreate);
            Controls.Add(buttonOpen);
            MinimumSize = new Size(1039, 542);
            Name = "FormCreator";
            Text = "Оптовая база";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private Button buttonCreate;
        private Button buttonSave;
        private Button button4;
        private DataGridView dataGridViewData;
        private GroupBox groupBox1;
        private TextBox txtProductCode;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button buttonAdd;
        private SaveFileDialog saveFileDialog1;
        private Button buttonSearch;
        private Button buttonStatistics;
        private Button buttonHelp;
        private Button buttonInfo;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private ToolTip toolTipInfo;
    }
}
