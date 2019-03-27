namespace Anaform
{
    partial class AracEkle
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
            this.cmb_durum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_yakit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ucret = new DevExpress.XtraEditors.TextEdit();
            this.txt_Motor = new DevExpress.XtraEditors.TextEdit();
            this.txt_renk = new DevExpress.XtraEditors.TextEdit();
            this.txt_plaka = new DevExpress.XtraEditors.TextEdit();
            this.txt_model = new DevExpress.XtraEditors.TextEdit();
            this.txt_marka = new DevExpress.XtraEditors.TextEdit();
            this.txt_Yil = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_durum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_yakit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Motor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_durum
            // 
            this.cmb_durum.Location = new System.Drawing.Point(115, 219);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_durum.Properties.Items.AddRange(new object[] {
            "Elimizde",
            "Kirada",
            "Bakımda",
            "Yasaklı"});
            this.cmb_durum.Size = new System.Drawing.Size(122, 20);
            this.cmb_durum.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Anaform.Properties.Resources.if_car_add_35817;
            this.simpleButton1.Location = new System.Drawing.Point(48, 245);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 40);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = global::Anaform.Properties.Resources.if_Backspace_clean_clear_delete_remove_erase_1886483__1_;
            this.simpleButton3.Location = new System.Drawing.Point(49, 290);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(188, 38);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Temizle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.EditValue = "Seçiniz";
            this.cmb_yakit.Location = new System.Drawing.Point(115, 165);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_yakit.Properties.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "LPG+Benzin"});
            this.cmb_yakit.Properties.Sorted = true;
            this.cmb_yakit.Size = new System.Drawing.Size(122, 20);
            this.cmb_yakit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 220);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "Durum";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(48, 194);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 101;
            this.labelControl11.Text = "Günlük Ücret";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(48, 168);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 13);
            this.labelControl10.TabIndex = 99;
            this.labelControl10.Text = "Yakıt";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(48, 113);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(55, 13);
            this.labelControl12.TabIndex = 98;
            this.labelControl12.Text = "Motor Gücü";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(48, 142);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 97;
            this.labelControl9.Text = "Renk";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(48, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(25, 13);
            this.labelControl8.TabIndex = 102;
            this.labelControl8.Text = "Plaka";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(48, 87);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(10, 13);
            this.labelControl7.TabIndex = 95;
            this.labelControl7.Text = "Yıl";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(48, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 96;
            this.labelControl6.Text = "Model";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 94;
            this.labelControl5.Text = "Marka";
            // 
            // txt_ucret
            // 
            this.txt_ucret.Location = new System.Drawing.Point(115, 191);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Properties.Mask.EditMask = "d";
            this.txt_ucret.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_ucret.Properties.MaxLength = 4;
            this.txt_ucret.Size = new System.Drawing.Size(122, 20);
            this.txt_ucret.TabIndex = 7;
            // 
            // txt_Motor
            // 
            this.txt_Motor.Location = new System.Drawing.Point(115, 110);
            this.txt_Motor.Name = "txt_Motor";
            this.txt_Motor.Properties.MaxLength = 4;
            this.txt_Motor.Size = new System.Drawing.Size(122, 20);
            this.txt_Motor.TabIndex = 4;
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(115, 139);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Properties.MaxLength = 10;
            this.txt_renk.Size = new System.Drawing.Size(122, 20);
            this.txt_renk.TabIndex = 5;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(115, 58);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Properties.MaxLength = 10;
            this.txt_plaka.Size = new System.Drawing.Size(122, 20);
            this.txt_plaka.TabIndex = 2;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(115, 32);
            this.txt_model.Name = "txt_model";
            this.txt_model.Properties.MaxLength = 20;
            this.txt_model.Size = new System.Drawing.Size(122, 20);
            this.txt_model.TabIndex = 1;
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(115, 6);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Properties.MaxLength = 20;
            this.txt_marka.Size = new System.Drawing.Size(122, 20);
            this.txt_marka.TabIndex = 0;
            // 
            // txt_Yil
            // 
            this.txt_Yil.EditValue = "";
            this.txt_Yil.Location = new System.Drawing.Point(115, 84);
            this.txt_Yil.Name = "txt_Yil";
            this.txt_Yil.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_Yil.Properties.Mask.EditMask = "d";
            this.txt_Yil.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Yil.Properties.MaxLength = 4;
            this.txt_Yil.Size = new System.Drawing.Size(122, 20);
            this.txt_Yil.TabIndex = 3;
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.cmb_yakit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_ucret);
            this.Controls.Add(this.txt_Motor);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.txt_Yil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ARAÇ EKLE";
            ((System.ComponentModel.ISupportInitialize)(this.cmb_durum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_yakit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ucret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Motor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yil.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit cmb_durum;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_yakit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_ucret;
        private DevExpress.XtraEditors.TextEdit txt_Motor;
        private DevExpress.XtraEditors.TextEdit txt_renk;
        private DevExpress.XtraEditors.TextEdit txt_plaka;
        private DevExpress.XtraEditors.TextEdit txt_model;
        private DevExpress.XtraEditors.TextEdit txt_marka;
        private DevExpress.XtraEditors.TextEdit txt_Yil;
    }
}