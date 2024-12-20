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

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormAbout
            // 
            ClientSize = new Size(410, 255);
            Name = "FormAbout";
            ResumeLayout(false);
        }
    }
}
