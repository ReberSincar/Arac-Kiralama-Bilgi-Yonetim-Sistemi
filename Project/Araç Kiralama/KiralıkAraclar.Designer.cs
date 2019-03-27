namespace Anaform
{
    partial class KiralıkAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralıkAraclar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_plakaara = new DevExpress.XtraEditors.TextEdit();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_tcara = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plakaara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tcara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(931, 386);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(173, 403);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "TC NO";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 403);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 18);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Plaka";
            // 
            // txt_plakaara
            // 
            this.txt_plakaara.Location = new System.Drawing.Point(54, 400);
            this.txt_plakaara.Name = "txt_plakaara";
            this.txt_plakaara.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_plakaara.Properties.Appearance.Options.UseFont = true;
            this.txt_plakaara.Properties.MaxLength = 10;
            this.txt_plakaara.Size = new System.Drawing.Size(113, 24);
            this.txt_plakaara.TabIndex = 0;
            this.txt_plakaara.EditValueChanged += new System.EventHandler(this.txt_plakaara_EditValueChanged);
            // 
            // btn_sil
            // 
            this.btn_sil.ImageOptions.Image = global::Anaform.Properties.Resources.minus;
            this.btn_sil.Location = new System.Drawing.Point(608, 392);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(104, 37);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = global::Anaform.Properties.Resources.if_update_64935;
            this.btn_guncelle.Location = new System.Drawing.Point(717, 392);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 37);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImageOptions.Image = global::Anaform.Properties.Resources.plus;
            this.btn_ekle.Location = new System.Drawing.Point(498, 393);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(104, 37);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(351, 394);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Sadece Şuan Kiradakiler";
            this.checkEdit1.Size = new System.Drawing.Size(138, 19);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Anaform.Properties.Resources.if_back_925927;
            this.simpleButton1.Location = new System.Drawing.Point(827, 392);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 36);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "TESLİM AL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_tcara
            // 
            this.txt_tcara.Location = new System.Drawing.Point(224, 400);
            this.txt_tcara.Name = "txt_tcara";
            this.txt_tcara.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcara.Properties.Appearance.Options.UseFont = true;
            this.txt_tcara.Size = new System.Drawing.Size(113, 24);
            this.txt_tcara.TabIndex = 1;
            this.txt_tcara.EditValueChanged += new System.EventHandler(this.txt_tcara_EditValueChanged_1);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(351, 413);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Bugün Teslim Alınacaklar";
            this.checkEdit2.Size = new System.Drawing.Size(138, 19);
            this.checkEdit2.TabIndex = 19;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // KiralıkAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 435);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.txt_tcara);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_plakaara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KiralıkAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KİRADAKİ ARAÇLAR";
            this.Load += new System.EventHandler(this.KiralıkAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_plakaara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tcara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_plakaara;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_ekle;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txt_tcara;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
    }
}