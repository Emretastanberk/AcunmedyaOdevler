namespace Serilazation_Deserialization
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
            btnDeserialization = new Button();
            txtAd = new TextBox();
            txtFiyat = new TextBox();
            btnJsonCreate = new Button();
            listUrunler = new ListBox();
            btnClear = new Button();
            btnReflection = new Button();
            lstProps = new ListBox();
            SuspendLayout();
            // 
            // btnDeserialization
            // 
            btnDeserialization.Location = new Point(632, 42);
            btnDeserialization.Name = "btnDeserialization";
            btnDeserialization.Size = new Size(120, 60);
            btnDeserialization.TabIndex = 1;
            btnDeserialization.Text = "JSON Deserize Et";
            btnDeserialization.UseVisualStyleBackColor = true;
            btnDeserialization.Click += btnDeserialization_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(108, 59);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(236, 27);
            txtAd.TabIndex = 2;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(108, 115);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(236, 27);
            txtFiyat.TabIndex = 2;
            // 
            // btnJsonCreate
            // 
            btnJsonCreate.Location = new Point(444, 42);
            btnJsonCreate.Name = "btnJsonCreate";
            btnJsonCreate.Size = new Size(117, 60);
            btnJsonCreate.TabIndex = 3;
            btnJsonCreate.Text = "JSON Oluştur";
            btnJsonCreate.UseVisualStyleBackColor = true;
            btnJsonCreate.Click += btnJsonCreate_Click;
            // 
            // listUrunler
            // 
            listUrunler.FormattingEnabled = true;
            listUrunler.Location = new Point(77, 323);
            listUrunler.Name = "listUrunler";
            listUrunler.Size = new Size(635, 104);
            listUrunler.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(450, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 60);
            btnClear.TabIndex = 5;
            btnClear.Text = "Listeyi Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReflection
            // 
            btnReflection.Location = new Point(632, 149);
            btnReflection.Name = "btnReflection";
            btnReflection.Size = new Size(120, 29);
            btnReflection.TabIndex = 6;
            btnReflection.Text = "REFLECTION";
            btnReflection.UseVisualStyleBackColor = true;
            btnReflection.Click += btnReflection_Click;
            // 
            // lstProps
            // 
            lstProps.FormattingEnabled = true;
            lstProps.Location = new Point(617, 194);
            lstProps.Name = "lstProps";
            lstProps.Size = new Size(150, 104);
            lstProps.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstProps);
            Controls.Add(btnReflection);
            Controls.Add(btnClear);
            Controls.Add(listUrunler);
            Controls.Add(btnJsonCreate);
            Controls.Add(txtFiyat);
            Controls.Add(txtAd);
            Controls.Add(btnDeserialization);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeserialization;
        private TextBox txtAd;
        private TextBox txtFiyat;
        private Button btnJsonCreate;
        private ListBox listUrunler;
        private Button btnClear;
        private Button btnReflection;
        private ListBox lstProps;
    }
}
