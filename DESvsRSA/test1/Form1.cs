using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            Form MainForm = new MainForm();
            MainForm.ShowDialog();
        
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MainForm2 = new MainForm2();
            MainForm2.ShowDialog();
        }
    }
}
