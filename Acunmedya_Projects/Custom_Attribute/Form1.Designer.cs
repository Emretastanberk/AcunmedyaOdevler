namespace Custom_Attribute
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
            lblName = new Label();
            lblSurname = new Label();
            lblDepartment = new Label();
            lblOut = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtDepartment = new TextBox();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(91, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Öğrenci Adı:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(55, 114);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(117, 20);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Öğrenci Soyadı: ";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(55, 177);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(119, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Öğrenci Bölümü:";
            // 
            // lblOut
            // 
            lblOut.AutoSize = true;
            lblOut.Location = new Point(55, 325);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(50, 20);
            lblOut.TabIndex = 3;
            lblOut.Text = "label4";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(193, 109);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(193, 170);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(125, 27);
            txtDepartment.TabIndex = 6;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(55, 248);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(94, 29);
            btnWrite.TabIndex = 7;
            btnWrite.Text = "YAZDIR";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWrite);
            Controls.Add(txtDepartment);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblOut);
            Controls.Add(lblDepartment);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblDepartment;
        private Label lblOut;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtDepartment;
        private Button btnWrite;
    }
}
