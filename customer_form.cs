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
    public partial class customer_form : Form
    {
        public customer_form()
        {
            InitializeComponent();
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

        private void customer_form_Load(object sender, EventArgs e)
        {
            sehirleriyukle();
        }

        private void sehirleriyukle()
        {
            ulke ulke1 = new ulke
            {
                ID = 1,
                ad = "Türkiye"

            };
            ulke ulke2 = new ulke
            {
                ID = 2,
                ad = "Almanya"

            };

            ulke ulke3 = new ulke
            {
                ID = 3,
                ad = "Hollanda"

            };

            ulkeler.Add(ulke1);
            ulkeler.Add(ulke2);
            ulkeler.Add(ulke3);

            sehir sehir1 = new sehir
            {
                ID = 1,
                isim = "İstanbul",
                ulkesi = ulke1
            };
            sehir sehir2 = new sehir
            {
                ID = 2,
                isim = "Ankara",
                ulkesi = ulke1
            };
            sehir sehir3 = new sehir
            {
                ID = 3,
                isim = "İzmir",
                ulkesi = ulke1
            };
            sehir sehir4 = new sehir
            {
                ID = 4,
                isim = "Berlin",
                ulkesi = ulke2
            };
            sehir sehir5 = new sehir
            {
                ID = 5,
                isim = "München",
                ulkesi = ulke2
            };
            sehir sehir6 = new sehir
            {
                ID = 6,
                isim = "Hannover",
                ulkesi = ulke2
            };
            sehir sehir7 = new sehir
            {
                ID = 7,
                isim = "Amsterdam",
                ulkesi = ulke3
            };
            sehir sehir8 = new sehir
            {
                ID = 8,
                isim = "Utrecth",
                ulkesi = ulke3
            };
            sehir sehir9 = new sehir
            {
                ID = 9,
                isim = "Eindhoven",
                ulkesi = ulke3
            };

            ulke1.sehirler.Add(sehir1);
            ulke1.sehirler.Add(sehir2);
            ulke1.sehirler.Add(sehir3);

            ulke2.sehirler.Add(sehir4);
            ulke2.sehirler.Add(sehir5);
            ulke2.sehirler.Add(sehir6);

            ulke3.sehirler.Add(sehir7);
            ulke3.sehirler.Add(sehir8);
            ulke3.sehirler.Add(sehir9);
           
            cb_ulke.DisplayMember = "ad";
            cb_ulke.ValueMember = "ID";
            cb_ulke.DataSource = ulkeler;
                        
        }


        public List<ulke> ulkeler = new List<ulke>();
        public List<sehir> sehirler = new List<sehir>();

        private void cb_ulke_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulke u = (ulke)cb_ulke.SelectedItem;
            //MessageBox.Show("Marka Değişti :" + u.ID + "="+u.ad);


            cb_sehir.DisplayMember = "isim";
            cb_sehir.ValueMember = "ID";
           
            cb_sehir.DataSource = u.sehirler;
            cb_sehir.SelectedIndex = 1;
        }

        List<musteri> musteriler = new List<musteri>();
        int count_id = 0;

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            DialogResult kaydet = MessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            bool hatavar = false;
            string hataMesaj = "";

            if (kaydet == DialogResult.Yes)
            {
                TimeSpan span = DateTime.Now - dt_dogum.Value.Date;
                if (span.TotalDays < 6480)
                {
                    hatavar = true;
                    hataMesaj = "18 yaş altındakiler kayıt olamaz!";
                }

                if (!check_sozlesme.Checked)
                {
                    hatavar = true;
                    hataMesaj = "Sözleşmeyi imzalamanız gerekmekte!";

                }
                if((txt_adres.Text=="") ||  (txt_ceptel.Text =="") || (txt_postakodu.Text=="") || (txt_mail.Text=="") || (txt_ad.Text=="") ||  (txt_soyad.Text==""))
                {
                    hatavar = true;
                    hataMesaj = "Gerekli alanları doldurmanız gerekmekte!";
                }
                   

                if (hatavar)
                {
                    MessageBox.Show(hataMesaj, "Hata!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    hatavar = false;
                    if(txt_adres.Text=="")
                    {
                        txt_adres.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_adres.BackColor = Color.White;
                    }
                    if (txt_ad.Text == "")
                    {
                        txt_ad.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_ad.BackColor = Color.White;
                    }
                    if (txt_postakodu.Text == "")
                    {
                        txt_postakodu.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_postakodu.BackColor = Color.White;
                    }
                    if (txt_mail.Text == "")
                    {
                        txt_mail.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_mail.BackColor = Color.White;
                    }
                    if (txt_soyad.Text == "")
                    {
                        txt_soyad.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_soyad.BackColor = Color.White;
                    }
                    if (txt_ceptel.Text == "")
                    {
                        txt_ceptel.BackColor = Color.Red;
                    }
                    else
                    {
                        txt_ceptel.BackColor = Color.White;
                    }
                }
                else
                {
                    musteri yenimuster = new musteri();

                    yenimuster.ID = count_id++;

                    yenimuster.ad = txt_ad.Text;
                    yenimuster.soyad = txt_soyad.Text;

                    if (rb_erkek.Checked)
                    {
                        yenimuster.cinsiyet = 0; //0 erkek 1 kadın
                    }
                    else
                    {
                        yenimuster.cinsiyet = 1;
                    }
                    yenimuster.dogum_tarihi = dt_dogum.Value.Date;
                    yenimuster.adres = txt_adres.Text;
                    yenimuster.sehir = (sehir)cb_sehir.SelectedItem;
                    yenimuster.ceptel = Int32.Parse(txt_ceptel.Text);
                    yenimuster.tel = txt_telefon.Text;
                    yenimuster.postakodu = Int32.Parse(txt_postakodu.Text);
                    yenimuster.mail = txt_mail.Text;


                    musteriler.Add(yenimuster);

                    string ekranayazdir = "Yeni müşteri şu şekilde kaydedilmiştir:\n";
                    ekranayazdir += "\nAd Soyad: " + yenimuster.ad + " " + yenimuster.soyad;
                    ekranayazdir += "\nCep Telefonu: " + yenimuster.ceptel;
                    ekranayazdir += "\nTelefonu: " + yenimuster.tel;
                    ekranayazdir += "\nAdresi: " + yenimuster.adres;
                    ekranayazdir += "\nDoğum Tarihi: " + yenimuster.dogum_tarihi;
                    ekranayazdir += "\nUlke: " + yenimuster.sehir.ulkesi.ad;
                    ekranayazdir += "\nŞehri: " + yenimuster.sehir.isim;
                    ekranayazdir += "\nMail: " + yenimuster.mail;
                    ekranayazdir += "\nDogum Tarihi: " + yenimuster.dogum_tarihi;

                    

                    foreach (var item in this.Controls)
                    {
                        if (item.GetType().Equals(typeof(TextBox)))
                        {
                            TextBox tb = item as TextBox;
                            tb.Text = string.Empty;
                        }
                        else if (item.GetType().Equals(typeof(MaskedTextBox)))
                        {
                            MaskedTextBox tb = item as MaskedTextBox;
                            tb.Text = string.Empty;
                        }
                    }
                    MessageBox.Show(ekranayazdir, "Kayıt Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                }

               
            }
        }
    }
}
