namespace Anaform
{
    partial class Bakimekle
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
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tel = new DevExpress.XtraEditors.TextEdit();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.txt_kisi = new DevExpress.XtraEditors.TextEdit();
            this.txt_yer = new DevExpress.XtraEditors.TextEdit();
            this.btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_icerik = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tarih = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_ariza = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_icerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ariza.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(315, 123);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 13);
            this.labelControl12.TabIndex = 38;
            this.labelControl12.Text = "Telefon";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(315, 152);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 37;
            this.labelControl9.Text = "Tutar";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(315, 71);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(15, 13);
            this.labelControl8.TabIndex = 42;
            this.labelControl8.Text = "Kişi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(315, 97);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 13);
            this.labelControl7.TabIndex = 35;
            this.labelControl7.Text = "Yer";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(315, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Arıza";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(382, 120);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Properties.Mask.EditMask = "d";
            this.txt_tel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_tel.Properties.MaxLength = 11;
            this.txt_tel.Size = new System.Drawing.Size(122, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(382, 149);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Mask.EditMask = "d";
            this.txt_tutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_tutar.Properties.MaxLength = 4;
            this.txt_tutar.Size = new System.Drawing.Size(122, 20);
            this.txt_tutar.TabIndex = 5;
            // 
            // txt_kisi
            // 
            this.txt_kisi.Location = new System.Drawing.Point(382, 68);
            this.txt_kisi.Name = "txt_kisi";
            this.txt_kisi.Properties.MaxLength = 20;
            this.txt_kisi.Size = new System.Drawing.Size(122, 20);
            this.txt_kisi.TabIndex = 2;
            // 
            // txt_yer
            // 
            this.txt_yer.EditValue = "";
            this.txt_yer.Location = new System.Drawing.Point(382, 94);
            this.txt_yer.Name = "txt_yer";
            this.txt_yer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_yer.Properties.MaxLength = 30;
            this.txt_yer.Size = new System.Drawing.Size(122, 20);
            this.txt_yer.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImageOptions.Image = global::Anaform.Properties.Resources.plus;
            this.btn_ekle.Location = new System.Drawing.Point(315, 258);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(189, 40);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = global::Anaform.Properties.Resources.if_Backspace_clean_clear_delete_remove_erase_1886483__1_;
            this.btn_temizle.Location = new System.Drawing.Point(316, 304);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(188, 38);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(315, 177);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "İçerik";
            // 
            // txt_icerik
            // 
            this.txt_icerik.Location = new System.Drawing.Point(382, 175);
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.Properties.MaxLength = 100;
            this.txt_icerik.Size = new System.Drawing.Size(122, 77);
            this.txt_icerik.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(315, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Tarih";
            // 
            // txt_tarih
            // 
            this.txt_tarih.EditValue = null;
            this.txt_tarih.Location = new System.Drawing.Point(383, 40);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_tarih.Properties.DisplayFormat.FormatString = "";
            this.txt_tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_tarih.Properties.EditFormat.FormatString = "";
            this.txt_tarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_tarih.Properties.MaxLength = 12;
            this.txt_tarih.Size = new System.Drawing.Size(122, 20);
            this.txt_tarih.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
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
            // txt_ariza
            // 
            this.txt_ariza.Location = new System.Drawing.Point(382, 14);
            this.txt_ariza.Name = "txt_ariza";
            this.txt_ariza.Properties.MaxLength = 30;
            this.txt_ariza.Size = new System.Drawing.Size(122, 20);
            this.txt_ariza.TabIndex = 0;
            // 
            // Bakimekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 349);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_ekle);
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
            this.Name = "Bakimekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BAKIM EKLE";
            this.Load += new System.EventHandler(this.Bakimekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_icerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ariza.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_ekle;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_tel;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.TextEdit txt_kisi;
        private DevExpress.XtraEditors.TextEdit txt_yer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_icerik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txt_tarih;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_ariza;
    }
}