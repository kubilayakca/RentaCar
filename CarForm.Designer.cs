namespace RentACar
{
    partial class CarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRenk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelYili = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKilometre = new System.Windows.Forms.MaskedTextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.rbDizel = new System.Windows.Forms.RadioButton();
            this.rbBenzin = new System.Windows.Forms.RadioButton();
            this.rbLPG = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbOtomatik = new System.Windows.Forms.RadioButton();
            this.rbManuel = new System.Windows.Forms.RadioButton();
            this.dtpSigorta = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.txtback = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(81, 22);
            this.txtPlaka.MaxLength = 50;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(120, 20);
            this.txtPlaka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbMarka
            // 
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(80, 69);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 21);
            this.cbMarka.TabIndex = 2;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(80, 111);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 3;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Renk";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbRenk
            // 
            this.cbRenk.FormattingEnabled = true;
            this.cbRenk.Items.AddRange(new object[] {
            "Beyaz",
            "Kırmızı",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Gri",
            "Siyah"});
            this.cbRenk.Location = new System.Drawing.Point(80, 156);
            this.cbRenk.Name = "cbRenk";
            this.cbRenk.Size = new System.Drawing.Size(121, 21);
            this.cbRenk.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model Yılı";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(83, 209);
            this.txtModelYili.Mask = "0000";
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(100, 20);
            this.txtModelYili.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kilometre";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiyat";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKilometre
            // 
            this.txtKilometre.HidePromptOnLeave = true;
            this.txtKilometre.Location = new System.Drawing.Point(83, 245);
            this.txtKilometre.Mask = "00000";
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Size = new System.Drawing.Size(100, 20);
            this.txtKilometre.TabIndex = 6;
            this.txtKilometre.ValidatingType = typeof(int);
            // 
            // nudFiyat
            // 
            this.nudFiyat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFiyat.Location = new System.Drawing.Point(83, 285);
            this.nudFiyat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFiyat.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 7;
            this.nudFiyat.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yakıt";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbDizel
            // 
            this.rbDizel.AutoSize = true;
            this.rbDizel.Location = new System.Drawing.Point(12, 14);
            this.rbDizel.Name = "rbDizel";
            this.rbDizel.Size = new System.Drawing.Size(48, 17);
            this.rbDizel.TabIndex = 8;
            this.rbDizel.Text = "Dizel";
            this.rbDizel.UseVisualStyleBackColor = true;
            // 
            // rbBenzin
            // 
            this.rbBenzin.AutoSize = true;
            this.rbBenzin.Checked = true;
            this.rbBenzin.Location = new System.Drawing.Point(123, 16);
            this.rbBenzin.Name = "rbBenzin";
            this.rbBenzin.Size = new System.Drawing.Size(60, 17);
            this.rbBenzin.TabIndex = 9;
            this.rbBenzin.TabStop = true;
            this.rbBenzin.Text = "benzinli";
            this.rbBenzin.UseVisualStyleBackColor = true;
            // 
            // rbLPG
            // 
            this.rbLPG.AutoSize = true;
            this.rbLPG.Location = new System.Drawing.Point(225, 14);
            this.rbLPG.Name = "rbLPG";
            this.rbLPG.Size = new System.Drawing.Size(46, 17);
            this.rbLPG.TabIndex = 10;
            this.rbLPG.Text = "LPG";
            this.rbLPG.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "vites";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbOtomatik
            // 
            this.rbOtomatik.AutoSize = true;
            this.rbOtomatik.Location = new System.Drawing.Point(9, 19);
            this.rbOtomatik.Name = "rbOtomatik";
            this.rbOtomatik.Size = new System.Drawing.Size(67, 17);
            this.rbOtomatik.TabIndex = 11;
            this.rbOtomatik.Text = "Otomatik";
            this.rbOtomatik.UseVisualStyleBackColor = true;
            // 
            // rbManuel
            // 
            this.rbManuel.AutoSize = true;
            this.rbManuel.Location = new System.Drawing.Point(112, 19);
            this.rbManuel.Name = "rbManuel";
            this.rbManuel.Size = new System.Drawing.Size(60, 17);
            this.rbManuel.TabIndex = 12;
            this.rbManuel.Text = "Manuel";
            this.rbManuel.UseVisualStyleBackColor = true;
            // 
            // dtpSigorta
            // 
            this.dtpSigorta.CustomFormat = "dd/MM/yyyy";
            this.dtpSigorta.Location = new System.Drawing.Point(112, 410);
            this.dtpSigorta.Name = "dtpSigorta";
            this.dtpSigorta.Size = new System.Drawing.Size(170, 20);
            this.dtpSigorta.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sigorta Bitiş Tarihi";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLPG);
            this.groupBox1.Controls.Add(this.rbBenzin);
            this.groupBox1.Controls.Add(this.rbDizel);
            this.groupBox1.Location = new System.Drawing.Point(78, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOtomatik);
            this.groupBox2.Controls.Add(this.rbManuel);
            this.groupBox2.Location = new System.Drawing.Point(81, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 49);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(538, 55);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 17;
            this.lblSonuc.Text = "label11";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(193, 460);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 18;
            this.btn_iptal.Text = "İPTAL";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txtback
            // 
            this.txtback.Location = new System.Drawing.Point(248, 17);
            this.txtback.Name = "txtback";
            this.txtback.Size = new System.Drawing.Size(100, 20);
            this.txtback.TabIndex = 19;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 495);
            this.Controls.Add(this.txtback);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpSigorta);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtKilometre);
            this.Controls.Add(this.txtModelYili);
            this.Controls.Add(this.cbRenk);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarForm";
            this.Text = "Araç Kayıt Formu";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRenk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtModelYili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtKilometre;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbDizel;
        private System.Windows.Forms.RadioButton rbBenzin;
        private System.Windows.Forms.RadioButton rbLPG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbOtomatik;
        private System.Windows.Forms.RadioButton rbManuel;
        private System.Windows.Forms.DateTimePicker dtpSigorta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btn_iptal;
        public System.Windows.Forms.TextBox txtback;
    }
}

