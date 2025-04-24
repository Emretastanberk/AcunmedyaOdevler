namespace Reflection
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
            cmbOdemeYontemi = new ComboBox();
            txtTutar = new TextBox();
            btnOdemeYap = new Button();
            lblSonuc = new Label();
            lblOdemeYontemi = new Label();
            lblTutar = new Label();
            btnListBox = new Button();
            lstListBox = new ListBox();
            btnAttributeUse = new Button();
            lstAttribute = new ListBox();
            btnAttributeControl = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtMail = new TextBox();
            lstAttributeControl = new ListBox();
            label1 = new Label();
            lblIsim = new Label();
            lblYas = new Label();
            lblMail = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(238, 40);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(151, 28);
            cmbOdemeYontemi.TabIndex = 0;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(188, 103);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(201, 27);
            txtTutar.TabIndex = 2;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(44, 184);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(94, 29);
            btnOdemeYap.TabIndex = 3;
            btnOdemeYap.Text = "ONAYLA";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(42, 248);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 4;
            // 
            // lblOdemeYontemi
            // 
            lblOdemeYontemi.AutoSize = true;
            lblOdemeYontemi.Location = new Point(42, 43);
            lblOdemeYontemi.Name = "lblOdemeYontemi";
            lblOdemeYontemi.Size = new Size(181, 20);
            lblOdemeYontemi.TabIndex = 5;
            lblOdemeYontemi.Text = "Ödeme Yöntemini Seçiniz:";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(42, 110);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(96, 20);
            lblTutar.TabIndex = 5;
            lblTutar.Text = "Tutarı Giriniz:";
            // 
            // btnListBox
            // 
            btnListBox.Location = new Point(501, 26);
            btnListBox.Name = "btnListBox";
            btnListBox.Size = new Size(302, 37);
            btnListBox.TabIndex = 6;
            btnListBox.Text = "Projedeki dosyaları göster";
            btnListBox.UseVisualStyleBackColor = true;
            btnListBox.Click += btnListBox_Click;
            // 
            // lstListBox
            // 
            lstListBox.FormattingEnabled = true;
            lstListBox.Location = new Point(504, 92);
            lstListBox.Name = "lstListBox";
            lstListBox.Size = new Size(299, 164);
            lstListBox.TabIndex = 7;
            // 
            // btnAttributeUse
            // 
            btnAttributeUse.Location = new Point(881, 26);
            btnAttributeUse.Name = "btnAttributeUse";
            btnAttributeUse.Size = new Size(250, 37);
            btnAttributeUse.TabIndex = 8;
            btnAttributeUse.Text = "Attribute Okuma";
            btnAttributeUse.UseVisualStyleBackColor = true;
            btnAttributeUse.Click += btnAttributeUse_Click;
            // 
            // lstAttribute
            // 
            lstAttribute.FormattingEnabled = true;
            lstAttribute.Location = new Point(881, 92);
            lstAttribute.Name = "lstAttribute";
            lstAttribute.Size = new Size(250, 164);
            lstAttribute.TabIndex = 9;
            // 
            // btnAttributeControl
            // 
            btnAttributeControl.Location = new Point(44, 384);
            btnAttributeControl.Name = "btnAttributeControl";
            btnAttributeControl.Size = new Size(345, 85);
            btnAttributeControl.TabIndex = 10;
            btnAttributeControl.Text = "Attribute ile veri doğrulamak için basın";
            btnAttributeControl.UseVisualStyleBackColor = true;
            btnAttributeControl.Click += btnAttributeControl_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 286);
            txtName.Name = "txtName";
            txtName.Size = new Size(341, 27);
            txtName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(48, 347);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 12;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(264, 347);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 13;
            // 
            // lstAttributeControl
            // 
            lstAttributeControl.FormattingEnabled = true;
            lstAttributeControl.Location = new Point(504, 286);
            lstAttributeControl.Name = "lstAttributeControl";
            lstAttributeControl.Size = new Size(423, 184);
            lstAttributeControl.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 263);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 15;
            label1.Text = "İsim:";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Location = new Point(48, 263);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(39, 20);
            lblIsim.TabIndex = 15;
            lblIsim.Text = "İsim:";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Location = new Point(48, 324);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(30, 20);
            lblYas.TabIndex = 15;
            lblYas.Text = "Yaş";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(264, 324);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(87, 20);
            lblMail.TabIndex = 15;
            lblMail.Text = "Mail Adresi:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(434, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(42, 504);
            progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 502);
            Controls.Add(progressBar1);
            Controls.Add(lblMail);
            Controls.Add(lblYas);
            Controls.Add(lblIsim);
            Controls.Add(label1);
            Controls.Add(lstAttributeControl);
            Controls.Add(txtMail);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnAttributeControl);
            Controls.Add(lstAttribute);
            Controls.Add(btnAttributeUse);
            Controls.Add(lstListBox);
            Controls.Add(btnListBox);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeYontemi);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeYontemi);
            Name = "Form1";
            Text = "li";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOdemeYontemi;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Label lblSonuc;
        private Label lblOdemeYontemi;
        private Label lblTutar;
        private Button btnListBox;
        private ListBox lstListBox;
        private Button btnAttributeUse;
        private ListBox lstAttribute;
        private Button btnAttributeControl;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtMail;
        private ListBox lstAttributeControl;
        private Label label1;
        private Label lblIsim;
        private Label lblYas;
        private Label lblMail;
        private ProgressBar progressBar1;
    }
}
