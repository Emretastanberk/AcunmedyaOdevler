namespace Hasta_Randevu_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBrans = new ComboBox();
            cmbDoktor = new ComboBox();
            dtpTarih = new DateTimePicker();
            cmbSaat = new ComboBox();
            lblDurum = new Label();
            txtHastaSoyadi = new TextBox();
            txtHastaAdi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // cmbBrans
            // 
            cmbBrans.DisplayMember = "Branş";
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(54, 54);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(151, 28);
            cmbBrans.TabIndex = 0;
            cmbBrans.Tag = "";
            cmbBrans.Text = "Branş Seçiniz";
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(54, 123);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(151, 28);
            cmbDoktor.TabIndex = 1;
            cmbDoktor.Text = "Doktor Seçiniz";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(345, 186);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 2;
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(54, 186);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(151, 28);
            cmbSaat.TabIndex = 3;
            cmbSaat.Text = "Saat Seçiniz";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(277, 286);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(50, 20);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "label1";
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(345, 123);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(157, 27);
            txtHastaSoyadi.TabIndex = 5;
            txtHastaSoyadi.Text = "Hasta Soyadını Giriniz";
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.ForeColor = Color.Black;
            txtHastaAdi.Location = new Point(345, 51);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(157, 27);
            txtHastaAdi.TabIndex = 6;
            txtHastaAdi.Text = "Hasta Adını girinizi";
            txtHastaAdi.TextChanged += txtHastaAdi_TextChanged;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(66, 286);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(119, 66);
            btnRandevuOlustur.TabIndex = 7;
            btnRandevuOlustur.Text = "RANDEVU OLUŞTUR";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaAdi);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(lblDurum);
            Controls.Add(cmbSaat);
            Controls.Add(dtpTarih);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbBrans);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrans;
        private ComboBox cmbDoktor;
        private DateTimePicker dtpTarih;
        private ComboBox cmbSaat;
        private Label lblDurum;
        private TextBox txtHastaSoyadi;
        private TextBox txtHastaAdi;
        private Button btnRandevuOlustur;
    }
}
