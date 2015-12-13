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
    public partial class SonucForm : Form
    {

        public Arac arac { get; set; }
        CarForm cform = new CarForm();
        public SonucForm(Arac a)
        {
            arac = a;
            InitializeComponent();
        }

        private void SonucForm_Load(object sender, EventArgs e)
        {
            txtplaka.Text = arac.Plaka;
        }

        private void btnyaz_Click(object sender, EventArgs e)
        {
            CarForm cform = this.Owner as CarForm;
           cform.txtback.Text = txtplaka.Text;
        }
    }
}
