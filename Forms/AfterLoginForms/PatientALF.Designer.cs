namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PatientALF
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonPALF_Bilgilerim = new Button();
            buttonPALF_RandevuBilgileri = new Button();
            buttonPALF_RandevuAl = new Button();
            panel2 = new Panel();
            labelPALF_NameSurname = new Label();
            labelPALF_Hg = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonPALF_Bilgilerim);
            panel1.Controls.Add(buttonPALF_RandevuBilgileri);
            panel1.Controls.Add(buttonPALF_RandevuAl);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 599);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 333);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonPALF_Bilgilerim
            // 
            buttonPALF_Bilgilerim.Dock = DockStyle.Top;
            buttonPALF_Bilgilerim.Location = new Point(0, 273);
            buttonPALF_Bilgilerim.Name = "buttonPALF_Bilgilerim";
            buttonPALF_Bilgilerim.Size = new Size(250, 60);
            buttonPALF_Bilgilerim.TabIndex = 3;
            buttonPALF_Bilgilerim.Text = "Bilgilerim";
            buttonPALF_Bilgilerim.UseVisualStyleBackColor = true;
            // 
            // buttonPALF_RandevuBilgileri
            // 
            buttonPALF_RandevuBilgileri.Dock = DockStyle.Top;
            buttonPALF_RandevuBilgileri.Location = new Point(0, 213);
            buttonPALF_RandevuBilgileri.Name = "buttonPALF_RandevuBilgileri";
            buttonPALF_RandevuBilgileri.Size = new Size(250, 60);
            buttonPALF_RandevuBilgileri.TabIndex = 2;
            buttonPALF_RandevuBilgileri.Text = "Randevu Bilgileri";
            buttonPALF_RandevuBilgileri.UseVisualStyleBackColor = true;
            // 
            // buttonPALF_RandevuAl
            // 
            buttonPALF_RandevuAl.Dock = DockStyle.Top;
            buttonPALF_RandevuAl.Location = new Point(0, 153);
            buttonPALF_RandevuAl.Name = "buttonPALF_RandevuAl";
            buttonPALF_RandevuAl.Size = new Size(250, 60);
            buttonPALF_RandevuAl.TabIndex = 1;
            buttonPALF_RandevuAl.Text = "Randevu Al";
            buttonPALF_RandevuAl.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelPALF_NameSurname);
            panel2.Controls.Add(labelPALF_Hg);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 153);
            panel2.TabIndex = 0;
            // 
            // labelPALF_NameSurname
            // 
            labelPALF_NameSurname.AutoSize = true;
            labelPALF_NameSurname.Location = new Point(103, 69);
            labelPALF_NameSurname.Name = "labelPALF_NameSurname";
            labelPALF_NameSurname.Size = new Size(44, 15);
            labelPALF_NameSurname.TabIndex = 1;
            labelPALF_NameSurname.Text = "default";
            // 
            // labelPALF_Hg
            // 
            labelPALF_Hg.AutoSize = true;
            labelPALF_Hg.Location = new Point(91, 9);
            labelPALF_Hg.Name = "labelPALF_Hg";
            labelPALF_Hg.Size = new Size(69, 15);
            labelPALF_Hg.TabIndex = 0;
            labelPALF_Hg.Text = "Hosgeldiniz";
            // 
            // PatientALF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1264, 599);
            Controls.Add(panel1);
            Name = "PatientALF";
            Text = "PatientALF";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button buttonPALF_RandevuAl;
        private Button buttonPALF_Bilgilerim;
        private Button buttonPALF_RandevuBilgileri;
        private Label labelPALF_NameSurname;
        private Label labelPALF_Hg;
        private PictureBox pictureBox1;
    }
}