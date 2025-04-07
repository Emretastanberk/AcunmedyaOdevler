namespace CarInfosWithWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            lblYakit = new Label();
            icoAraba = new PictureBox();
            icoRenk = new PictureBox();
            icoPencere = new PictureBox();
            icoYakit = new PictureBox();
            icoTarih = new PictureBox();
            btnGoster = new Button();
            cmbKapiSayisi = new ComboBox();
            cmbPencereSayisi = new ComboBox();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            textBox3 = new TextBox();
            txtRenk = new TextBox();
            txtYakit = new TextBox();
            icoKapi = new PictureBox();
            lblBilgiler = new Label();
            ((System.ComponentModel.ISupportInitialize)icoAraba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoRenk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoPencere).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoYakit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoTarih).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoKapi).BeginInit();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(128, 35);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(63, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "MARKA:";
            lblMarka.Click += label1_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(128, 137);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(62, 20);
            lblModel.TabIndex = 0;
            lblModel.Text = "MODEL:";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(128, 251);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(49, 20);
            lblRenk.TabIndex = 0;
            lblRenk.Text = "RENK:";
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(560, 137);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(88, 20);
            lblKapiSayisi.TabIndex = 0;
            lblKapiSayisi.Text = "KAPI SAYISI:";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(560, 35);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(118, 20);
            lblPencereSayisi.TabIndex = 0;
            lblPencereSayisi.Text = "PENCERE SAYISI:";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Location = new Point(560, 251);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(228, 20);
            lblYakit.TabIndex = 0;
            lblYakit.Text = "100 KM'DE YAKTIĞI YAKIT(LİTRE):";
            // 
            // icoAraba
            // 
            icoAraba.Image = (Image)resources.GetObject("icoAraba.Image");
            icoAraba.Location = new Point(40, 12);
            icoAraba.Name = "icoAraba";
            icoAraba.Size = new Size(64, 64);
            icoAraba.SizeMode = PictureBoxSizeMode.AutoSize;
            icoAraba.TabIndex = 1;
            icoAraba.TabStop = false;
            // 
            // icoRenk
            // 
            icoRenk.Image = (Image)resources.GetObject("icoRenk.Image");
            icoRenk.Location = new Point(40, 227);
            icoRenk.Name = "icoRenk";
            icoRenk.Size = new Size(64, 64);
            icoRenk.SizeMode = PictureBoxSizeMode.AutoSize;
            icoRenk.TabIndex = 1;
            icoRenk.TabStop = false;
            // 
            // icoPencere
            // 
            icoPencere.Image = (Image)resources.GetObject("icoPencere.Image");
            icoPencere.Location = new Point(468, 12);
            icoPencere.Name = "icoPencere";
            icoPencere.Size = new Size(64, 64);
            icoPencere.SizeMode = PictureBoxSizeMode.AutoSize;
            icoPencere.TabIndex = 1;
            icoPencere.TabStop = false;
            // 
            // icoYakit
            // 
            icoYakit.Image = (Image)resources.GetObject("icoYakit.Image");
            icoYakit.Location = new Point(468, 227);
            icoYakit.Name = "icoYakit";
            icoYakit.Size = new Size(64, 64);
            icoYakit.SizeMode = PictureBoxSizeMode.AutoSize;
            icoYakit.TabIndex = 1;
            icoYakit.TabStop = false;
            // 
            // icoTarih
            // 
            icoTarih.Image = (Image)resources.GetObject("icoTarih.Image");
            icoTarih.Location = new Point(40, 111);
            icoTarih.Name = "icoTarih";
            icoTarih.Size = new Size(64, 64);
            icoTarih.SizeMode = PictureBoxSizeMode.AutoSize;
            icoTarih.TabIndex = 1;
            icoTarih.TabStop = false;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(40, 347);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(132, 57);
            btnGoster.TabIndex = 2;
            btnGoster.Text = "Bilgileri Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += button1_Click;
            // 
            // cmbKapiSayisi
            // 
            cmbKapiSayisi.FormattingEnabled = true;
            cmbKapiSayisi.Items.AddRange(new object[] { "Seçiniz..", "2", "4", "6" });
            cmbKapiSayisi.Location = new Point(729, 134);
            cmbKapiSayisi.Name = "cmbKapiSayisi";
            cmbKapiSayisi.Size = new Size(151, 28);
            cmbKapiSayisi.TabIndex = 3;
            cmbKapiSayisi.SelectedIndexChanged += cmbKapiSayisi_SelectedIndexChanged;
            // 
            // cmbPencereSayisi
            // 
            cmbPencereSayisi.FormattingEnabled = true;
            cmbPencereSayisi.Items.AddRange(new object[] { "Seçiniz..", "2", "4", "6" });
            cmbPencereSayisi.Location = new Point(729, 32);
            cmbPencereSayisi.Name = "cmbPencereSayisi";
            cmbPencereSayisi.Size = new Size(151, 28);
            cmbPencereSayisi.TabIndex = 3;
            cmbPencereSayisi.SelectedIndexChanged += cmbPencereSayisi_SelectedIndexChanged;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(220, 32);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(220, 134);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(220, 248);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 4;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(794, 248);
            txtYakit.Name = "txtYakit";
            txtYakit.Size = new Size(125, 27);
            txtYakit.TabIndex = 4;
            // 
            // icoKapi
            // 
            icoKapi.Image = (Image)resources.GetObject("icoKapi.Image");
            icoKapi.Location = new Point(468, 111);
            icoKapi.Name = "icoKapi";
            icoKapi.Size = new Size(64, 64);
            icoKapi.SizeMode = PictureBoxSizeMode.AutoSize;
            icoKapi.TabIndex = 1;
            icoKapi.TabStop = false;
            // 
            // lblBilgiler
            // 
            lblBilgiler.AutoSize = true;
            lblBilgiler.Location = new Point(220, 365);
            lblBilgiler.Name = "lblBilgiler";
            lblBilgiler.Size = new Size(0, 20);
            lblBilgiler.TabIndex = 5;
            lblBilgiler.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 459);
            Controls.Add(lblBilgiler);
            Controls.Add(txtYakit);
            Controls.Add(txtRenk);
            Controls.Add(textBox3);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(cmbPencereSayisi);
            Controls.Add(cmbKapiSayisi);
            Controls.Add(btnGoster);
            Controls.Add(icoTarih);
            Controls.Add(icoKapi);
            Controls.Add(icoYakit);
            Controls.Add(icoRenk);
            Controls.Add(icoPencere);
            Controls.Add(icoAraba);
            Controls.Add(lblYakit);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "t";
            ((System.ComponentModel.ISupportInitialize)icoAraba).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoRenk).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoPencere).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoYakit).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoTarih).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoKapi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private Label lblYakit;
        private PictureBox icoAraba;
        private PictureBox icoRenk;
        private PictureBox icoPencere;
        private PictureBox icoYakit;
        private PictureBox icoTarih;
        private Button btnGoster;
        private ComboBox cmbKapiSayisi;
        private ComboBox cmbPencereSayisi;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox textBox3;
        private TextBox txtRenk;
        private TextBox txtYakit;
        private PictureBox icoKapi;
        private Label lblBilgiler;
    }
}
