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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            
            FormCreator formAbout = new FormCreator();
            formAbout.FormClosed += (s, args) => this.Close();
            this.Hide();
            formAbout.ShowDialog();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch formAbout = new FormSearch();

            formAbout.ShowDialog();
        }


    }
}
