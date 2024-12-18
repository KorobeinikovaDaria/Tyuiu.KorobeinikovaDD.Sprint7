namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreator));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtProductCode = new TextBox();
            groupBox2 = new GroupBox();
            panel5 = new Panel();
            label5 = new Label();
            txtPrice = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txtDescription = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            txtQuantity = new TextBox();
            panel2 = new Panel();
            txtProductName = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button5 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.Size = new Size(187, 20);
            label2.TabIndex = 12;
            label2.Text = "Введите название товара";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(81, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoadFile_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(815, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEdit_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(181, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 58);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSaveFile_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(915, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 58);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 378);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
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
            txtProductCode.Size = new Size(151, 27);
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
            panel5.Controls.Add(txtPrice);
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
            label5.Size = new Size(189, 20);
            label5.TabIndex = 12;
            label5.Text = "Введите описание товара";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 21);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtDescription);
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
            label4.Size = new Size(184, 20);
            label4.TabIndex = 11;
            label4.Text = "Введите цену за единицу";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(3, 23);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(151, 27);
            txtDescription.TabIndex = 10;
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
            label3.Size = new Size(255, 20);
            label3.TabIndex = 13;
            label3.Text = "Введите количество штук на складе";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(3, 24);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 27);
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
            txtProductName.Size = new Size(151, 27);
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
            label1.Size = new Size(145, 20);
            label1.TabIndex = 7;
            label1.Text = "Введите код товара";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(715, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 58);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnAdd_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(915, 422);
            button6.Name = "button6";
            button6.Size = new Size(94, 58);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonOpenSearchForm_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(815, 422);
            button7.Name = "button7";
            button7.Size = new Size(94, 58);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(12, 12);
            button8.Name = "button8";
            button8.Size = new Size(63, 58);
            button8.TabIndex = 11;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(615, 422);
            button9.Name = "button9";
            button9.Size = new Size(63, 58);
            button9.TabIndex = 12;
            button9.UseVisualStyleBackColor = true;
            // 
            // FormCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 495);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MinimumSize = new Size(1039, 542);
            Name = "FormCreator";
            Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtProductCode;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button button5;
        private SaveFileDialog saveFileDialog1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
    }
}
