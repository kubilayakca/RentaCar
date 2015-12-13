namespace RentACar
{
    partial class SonucForm
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
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.btnyaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(46, 40);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(100, 20);
            this.txtplaka.TabIndex = 0;
            // 
            // btnyaz
            // 
            this.btnyaz.Location = new System.Drawing.Point(70, 161);
            this.btnyaz.Name = "btnyaz";
            this.btnyaz.Size = new System.Drawing.Size(75, 23);
            this.btnyaz.TabIndex = 1;
            this.btnyaz.Text = "button1";
            this.btnyaz.UseVisualStyleBackColor = true;
            this.btnyaz.Click += new System.EventHandler(this.btnyaz_Click);
            // 
            // SonucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnyaz);
            this.Controls.Add(this.txtplaka);
            this.Name = "SonucForm";
            this.Text = "SonucForm";
            this.Load += new System.EventHandler(this.SonucForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Button btnyaz;

    }
}