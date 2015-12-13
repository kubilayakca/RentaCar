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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        public void FillMarkaandModel()
        {
            Marka marka1 = new Marka();
            marka1.ID = 1;
            marka1.Ad = "Honda";

            Model m3 = new Model
            {
                ID = 3,
                Ad = "Jazz",
                Marka = marka1
            };

            Model m4 = new Model
            {
                ID = 4,
                Ad = "Civic",
                Marka = marka1
            };

            marka1.Modeller.Add(m3);
            marka1.Modeller.Add(m4);
            

            Marka marka2 = new Marka();
            marka2.ID = 2;
            marka2.Ad = "Toyota";

            Model m1 = new Model
            {
                ID = 1,
                Ad = "Corolla",
                Marka = marka2
            };

            Model m2 = new Model
            {
                ID = 2,
                Ad = "Yaris",
                Marka = marka2
            };

            marka2.Modeller.Add(m1);
            marka2.Modeller.Add(m2);




            Marka marka3 = new Marka();
            marka3.ID = 3;
            marka3.Ad = "Fiat";

                    

            Markalar.Add(marka1);
            Markalar.Add(marka2);
            Markalar.Add(marka3);




        }
        public List<Marka> Markalar = new List<Marka>();
        public List<Arac> Araclar = new List<Arac>();
    
        private void CarForm_Load(object sender, EventArgs e)
        {
            rbDizel.Checked = true;
            dtpSigorta.MaxDate = DateTime.Now.AddYears(1);
            dtpSigorta.MinDate = DateTime.Now;
            dtpSigorta.Value = DateTime.Now;

            FillMarkaandModel();
            
            cbMarka.DisplayMember = "Ad";
            cbMarka.ValueMember = "ID";
            cbMarka.DataSource = Markalar;
            
        }

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marka m = (Marka)cbMarka.SelectedItem;
           // MessageBox.Show("Marka Değişti :" + m.ID + "="+m.Ad);
          
            cbModel.DisplayMember = "Ad";
            cbModel.ValueMember = "ID";

            cbModel.DataSource = m.Modeller;
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arac yeniArac = new Arac();
            yeniArac.Plaka = txtPlaka.Text;
            yeniArac.Model = (Model)cbModel.SelectedItem;
            yeniArac.Renk = cbRenk.Text;
            yeniArac.ModelYili = Int32.Parse(txtModelYili.Text);
            yeniArac.Kilometre = int.Parse(txtKilometre.Text);
            yeniArac.Fiyat = (int)nudFiyat.Value;
            yeniArac.SigortaTarihi = dtpSigorta.Value;

            if (rbDizel.Checked)
            {
                yeniArac.YakitTuru = (int)YakitTurleri.Dizel;
            }
            else if (rbBenzin.Checked)
            {
                yeniArac.YakitTuru = (int)YakitTurleri.Benzinli;
            }
            else if (rbLPG.Checked)
            {
                yeniArac.YakitTuru = (int)YakitTurleri.LPG;
            }
            else
            {
                //HATA
            }

            if (rbOtomatik.Checked)
            {
                yeniArac.Vites = 1;
            }
            else if (rbManuel.Checked)
            {
                yeniArac.Vites = 2;
            }
           DialogResult dr=  MessageBox.Show("Kaydetmek ister misiniz?","Onay", MessageBoxButtons.YesNo);
           
           SonucForm frmSonuc = new SonucForm(yeniArac);
           frmSonuc.Owner = this;
            frmSonuc.ShowDialog();

           if (dr == DialogResult.Yes)
           {
               Araclar.Add(yeniArac);
               lblSonuc.Text = yeniArac.Plaka + "'lı " 
                   + yeniArac.Model.Marka.Ad + "Markalı " 
                   + yeniArac.Model.Ad + " Model aracınız kaydedilmiştir.";

           }
           else
           {

           }

        }

        private void btn_customerform_Click(object sender, EventArgs e)
        {

            customer_form customer_form = new customer_form();
            this.Hide();
            customer_form.Show();

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult iptal = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "İPTAL", MessageBoxButtons.YesNo);

            if (iptal == DialogResult.Yes)
            {
                this.Hide();
                main_form ana_form = new main_form();
                ana_form.Show();

            }
            
        }
    }
}
