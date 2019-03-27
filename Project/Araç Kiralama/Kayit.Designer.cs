namespace Anaform
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.txt_ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_parola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_parola2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(109, 18);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Properties.MaxLength = 15;
            this.txt_ad.Size = new System.Drawing.Size(139, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(109, 201);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 38);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "KAYIT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(109, 53);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Properties.MaxLength = 15;
            this.txt_soyad.Size = new System.Drawing.Size(139, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Soyad";
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(109, 89);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Properties.MaxLength = 15;
            this.txt_kadi.Size = new System.Drawing.Size(139, 20);
            this.txt_kadi.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Kullanıcı Adı";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(109, 126);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Properties.MaxLength = 15;
            this.txt_parola.Size = new System.Drawing.Size(139, 20);
            this.txt_parola.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Parola";
            // 
            // txt_parola2
            // 
            this.txt_parola2.Location = new System.Drawing.Point(109, 163);
            this.txt_parola2.Name = "txt_parola2";
            this.txt_parola2.Properties.MaxLength = 15;
            this.txt_parola2.Size = new System.Drawing.Size(139, 20);
            this.txt_parola2.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Parola(Tekrar)";
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 255);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_parola2);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT";
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_ad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txt_soyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_kadi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_parola;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_parola2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}