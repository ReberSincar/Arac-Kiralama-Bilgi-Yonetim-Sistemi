namespace Anaform
{
    partial class ParolaDegistir
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_eski = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_yeni1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_yeni2 = new DevExpress.XtraEditors.TextEdit();
            this.btn_degis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_eski.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Eski Parola";
            // 
            // txt_eski
            // 
            this.txt_eski.Location = new System.Drawing.Point(111, 30);
            this.txt_eski.Name = "txt_eski";
            this.txt_eski.Size = new System.Drawing.Size(128, 20);
            this.txt_eski.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Yeni Parola";
            // 
            // txt_yeni1
            // 
            this.txt_yeni1.Location = new System.Drawing.Point(111, 68);
            this.txt_yeni1.Name = "txt_yeni1";
            this.txt_yeni1.Size = new System.Drawing.Size(128, 20);
            this.txt_yeni1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yeni Parola";
            // 
            // txt_yeni2
            // 
            this.txt_yeni2.Location = new System.Drawing.Point(111, 107);
            this.txt_yeni2.Name = "txt_yeni2";
            this.txt_yeni2.Size = new System.Drawing.Size(128, 20);
            this.txt_yeni2.TabIndex = 2;
            // 
            // btn_degis
            // 
            this.btn_degis.ImageOptions.Image = global::Anaform.Properties.Resources.custom_flat_reset_password_32;
            this.btn_degis.Location = new System.Drawing.Point(111, 149);
            this.btn_degis.Name = "btn_degis";
            this.btn_degis.Size = new System.Drawing.Size(128, 44);
            this.btn_degis.TabIndex = 3;
            this.btn_degis.Text = "DEĞİŞTİR";
            this.btn_degis.Click += new System.EventHandler(this.btn_degis_Click);
            // 
            // ParolaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.btn_degis);
            this.Controls.Add(this.txt_yeni2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_yeni1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_eski);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ParolaDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PAROLA DEĞİŞTİR";
            ((System.ComponentModel.ISupportInitialize)(this.txt_eski.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_eski;
        private DevExpress.XtraEditors.SimpleButton btn_degis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_yeni1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_yeni2;
    }
}