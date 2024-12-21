using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAbout));
            groupbox = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupbox.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupbox
            // 
            groupbox.Controls.Add(button1);
            groupbox.Controls.Add(label4);
            groupbox.Controls.Add(label3);
            groupbox.Controls.Add(label2);
            groupbox.Controls.Add(label1);
            groupbox.Location = new Point(168, 12);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(408, 233);
            groupbox.TabIndex = 0;
            groupbox.TabStop = false;
            groupbox.Text = "Описание";
            // 
            // button1
            // 
            button1.Location = new Point(308, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonOK_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 155);
            label4.Name = "label4";
            label4.Size = new Size(404, 20);
            label4.TabIndex = 3;
            label4.Text = "Внутреннее имя: Tyuiu.KorobeinikovaDD.Sprint7.Project.V5\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 101);
            label3.Name = "label3";
            label3.Size = new Size(361, 40);
            label3.TabIndex = 2;
            label3.Text = "Тюменский индустриальный университет (с) 2024 \r\nВысшая школа цифровых технологий (с) 2024";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 52);
            label2.Name = "label2";
            label2.Size = new Size(251, 40);
            label2.TabIndex = 1;
            label2.Text = "Программа разработана в рамках\r\nизучения языка C#";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(372, 20);
            label1.TabIndex = 0;
            label1.Text = "Разработчик Коробейникова Д.Д. группа ПКТб-24-1";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            ClientSize = new Size(588, 249);
            Controls.Add(pictureBox1);
            Controls.Add(groupbox);
            MaximumSize = new Size(606, 296);
            MinimumSize = new Size(606, 296);
            Name = "FormAbout";
            Text = "О программе";
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private GroupBox groupbox;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
