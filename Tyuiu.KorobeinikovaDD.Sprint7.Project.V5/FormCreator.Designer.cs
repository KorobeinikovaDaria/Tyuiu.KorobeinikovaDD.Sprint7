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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtProductCode = new TextBox();
            groupBox2 = new GroupBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button5 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoadFile_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEdit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(112, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 58);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSaveFile_Click;
            // 
            // button4
            // 
            button4.Location = new Point(694, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 58);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 336);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 362);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(16, 26);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(125, 27);
            txtProductCode.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(txtProductCode);
            groupBox2.Location = new Point(428, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 288);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 228);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(16, 176);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(16, 124);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(16, 75);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Location = new Point(494, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 58);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnAdd_Click;
            // 
            // button6
            // 
            button6.Location = new Point(694, 380);
            button6.Name = "button6";
            button6.Size = new Size(94, 58);
            button6.TabIndex = 9;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonOpenSearchForm_Click;
            // 
            // button7
            // 
            button7.Location = new Point(594, 380);
            button7.Name = "button7";
            button7.Size = new Size(94, 58);
            button7.TabIndex = 10;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // FormCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormCreator";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
