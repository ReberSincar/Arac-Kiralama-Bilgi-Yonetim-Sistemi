namespace Anaform
{
    partial class BakımGuncelle
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
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tel = new DevExpress.XtraEditors.TextEdit();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_kisi = new DevExpress.XtraEditors.TextEdit();
            this.txt_ariza = new DevExpress.XtraEditors.TextEdit();
            this.txt_yer = new DevExpress.XtraEditors.TextEdit();
            this.txt_icerik = new DevExpress.XtraEditors.MemoEdit();
            this.txt_tarih = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ariza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_icerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = global::Anaform.Properties.Resources.if_update_64935;
            this.btn_guncelle.Location = new System.Drawing.Point(314, 255);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(188, 40);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = global::Anaform.Properties.Resources.if_Backspace_clean_clear_delete_remove_erase_1886483__1_;
            this.btn_temizle.Location = new System.Drawing.Point(314, 302);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(188, 38);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(313, 120);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 13);
            this.labelControl12.TabIndex = 60;
            this.labelControl12.Text = "Telefon";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(313, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "İçerik";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(313, 149);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 58;
            this.labelControl9.Text = "Tutar";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(313, 68);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(15, 13);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Kişi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(313, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 13);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Yer";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(313, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Tarih";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(313, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Arıza";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(380, 117);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Properties.MaxLength = 11;
            this.txt_tel.Size = new System.Drawing.Size(122, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(380, 146);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.MaxLength = 10;
            this.txt_tutar.Size = new System.Drawing.Size(122, 20);
            this.txt_tutar.TabIndex = 5;
            // 
            // txt_kisi
            // 
            this.txt_kisi.Location = new System.Drawing.Point(380, 65);
            this.txt_kisi.Name = "txt_kisi";
            this.txt_kisi.Properties.MaxLength = 30;
            this.txt_kisi.Size = new System.Drawing.Size(122, 20);
            this.txt_kisi.TabIndex = 2;
            // 
            // txt_ariza
            // 
            this.txt_ariza.Location = new System.Drawing.Point(380, 11);
            this.txt_ariza.Name = "txt_ariza";
            this.txt_ariza.Properties.MaxLength = 30;
            this.txt_ariza.Size = new System.Drawing.Size(122, 20);
            this.txt_ariza.TabIndex = 0;
            // 
            // txt_yer
            // 
            this.txt_yer.EditValue = "";
            this.txt_yer.Location = new System.Drawing.Point(380, 91);
            this.txt_yer.Name = "txt_yer";
            this.txt_yer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_yer.Properties.MaxLength = 30;
            this.txt_yer.Size = new System.Drawing.Size(122, 20);
            this.txt_yer.TabIndex = 3;
            // 
            // txt_icerik
            // 
            this.txt_icerik.Location = new System.Drawing.Point(380, 172);
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.Properties.MaxLength = 100;
            this.txt_icerik.Size = new System.Drawing.Size(122, 77);
            this.txt_icerik.TabIndex = 6;
            // 
            // txt_tarih
            // 
            this.txt_tarih.EditValue = null;
            this.txt_tarih.Location = new System.Drawing.Point(381, 37);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_tarih.Properties.DisplayFormat.FormatString = "";
            this.txt_tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_tarih.Properties.EditFormat.FormatString = "";
            this.txt_tarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_tarih.Properties.MaxLength = 30;
            this.txt_tarih.Size = new System.Drawing.Size(122, 20);
            this.txt_tarih.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(294, 352);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BakımGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 350);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_kisi);
            this.Controls.Add(this.txt_ariza);
            this.Controls.Add(this.txt_yer);
            this.Controls.Add(this.txt_icerik);
            this.Controls.Add(this.txt_tarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BakımGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BAKIM GÜNCELLE";
            this.Load += new System.EventHandler(this.BakımGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ariza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_icerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_tel;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.TextEdit txt_kisi;
        private DevExpress.XtraEditors.TextEdit txt_ariza;
        private DevExpress.XtraEditors.TextEdit txt_yer;
        private DevExpress.XtraEditors.MemoEdit txt_icerik;
        private DevExpress.XtraEditors.DateEdit txt_tarih;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}