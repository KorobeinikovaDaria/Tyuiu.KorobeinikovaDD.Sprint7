namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5
{
    partial class FormMain
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 174);
            button1.Name = "button1";
            button1.Size = new Size(181, 118);
            button1.TabIndex = 1;
            button1.Text = "Загрузить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreator_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 174);
            button2.Name = "button2";
            button2.Size = new Size(183, 118);
            button2.TabIndex = 2;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSearch_Click;
            // 
            // button3
            // 
            button3.Location = new Point(514, 174);
            button3.Name = "button3";
            button3.Size = new Size(172, 118);
            button3.TabIndex = 3;
            button3.Text = "Статистика";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(679, 373);
            button4.Name = "button4";
            button4.Size = new Size(98, 65);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(570, 373);
            button5.Name = "button5";
            button5.Size = new Size(103, 65);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}