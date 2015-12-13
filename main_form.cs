using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarForm aracform = new CarForm();
            aracform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer_form musteri_formu = new customer_form();
            this.Hide();
            musteri_formu.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program coded by Kubilay AKÇA\n for CET301 project.\n2014 ©", "About Program", MessageBoxButtons.OK);
        }
    }
}
