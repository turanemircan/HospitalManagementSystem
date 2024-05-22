namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SecretaryALF
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            SALF_MainPageInformation = new Button();
            SALF_MainPageAppointments = new Button();
            SALF_MainPageMakeAppointments = new Button();
            panel5 = new Panel();
            labelPALF_Hg = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            Salf_secretaryName = new Label();
            labelDALF_SecretaryID = new Label();
            button2 = new Button();
            button1 = new Button();
            panelSecretaryAlf = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 621);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Salmon;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 621);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Salmon;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 621);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Salmon;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(SALF_MainPageInformation);
            panel4.Controls.Add(SALF_MainPageAppointments);
            panel4.Controls.Add(SALF_MainPageMakeAppointments);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 621);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 333);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SALF_MainPageInformation
            // 
            SALF_MainPageInformation.Dock = DockStyle.Top;
            SALF_MainPageInformation.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageInformation.Location = new Point(0, 280);
            SALF_MainPageInformation.Name = "SALF_MainPageInformation";
            SALF_MainPageInformation.Size = new Size(286, 54);
            SALF_MainPageInformation.TabIndex = 3;
            SALF_MainPageInformation.Text = "İnformation";
            SALF_MainPageInformation.UseVisualStyleBackColor = true;
            SALF_MainPageInformation.Click += SALF_MainPageInformation_Click;
            // 
            // SALF_MainPageAppointments
            // 
            SALF_MainPageAppointments.Dock = DockStyle.Top;
            SALF_MainPageAppointments.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageAppointments.Location = new Point(0, 226);
            SALF_MainPageAppointments.Name = "SALF_MainPageAppointments";
            SALF_MainPageAppointments.Size = new Size(286, 54);
            SALF_MainPageAppointments.TabIndex = 2;
            SALF_MainPageAppointments.Text = "Appointments";
            SALF_MainPageAppointments.UseVisualStyleBackColor = true;
            SALF_MainPageAppointments.Click += SALF_MainPageAppointments_Click;
            // 
            // SALF_MainPageMakeAppointments
            // 
            SALF_MainPageMakeAppointments.Dock = DockStyle.Top;
            SALF_MainPageMakeAppointments.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageMakeAppointments.Location = new Point(0, 174);
            SALF_MainPageMakeAppointments.Name = "SALF_MainPageMakeAppointments";
            SALF_MainPageMakeAppointments.Size = new Size(286, 52);
            SALF_MainPageMakeAppointments.TabIndex = 1;
            SALF_MainPageMakeAppointments.Text = "Make an Appointment";
            SALF_MainPageMakeAppointments.UseVisualStyleBackColor = true;
            SALF_MainPageMakeAppointments.Click += SALF_MainPageMakeAppointments_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelPALF_Hg);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(Salf_secretaryName);
            panel5.Controls.Add(labelDALF_SecretaryID);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 174);
            panel5.TabIndex = 0;
            // 
            // labelPALF_Hg
            // 
            labelPALF_Hg.AutoSize = true;
            labelPALF_Hg.Font = new Font("Yu Gothic UI Semibold", 15F);
            labelPALF_Hg.Location = new Point(68, 31);
            labelPALF_Hg.Name = "labelPALF_Hg";
            labelPALF_Hg.Size = new Size(150, 35);
            labelPALF_Hg.TabIndex = 49;
            labelPALF_Hg.Text = "Hosgeldiniz";
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI Semibold", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(142, 91);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 48;
            label2.Text = "label";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Salmon;
            label4.Font = new Font("Yu Gothic UI Semibold", 10F);
            label4.Location = new Point(163, 135);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 47;
            label4.Text = "label";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Salmon;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F);
            label3.Location = new Point(163, 135);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 46;
            // 
            // Salf_secretaryName
            // 
            Salf_secretaryName.AutoSize = true;
            Salf_secretaryName.BackColor = Color.Salmon;
            Salf_secretaryName.Font = new Font("Yu Gothic UI Semibold", 10F);
            Salf_secretaryName.Location = new Point(16, 135);
            Salf_secretaryName.Name = "Salf_secretaryName";
            Salf_secretaryName.Size = new Size(149, 23);
            Salf_secretaryName.TabIndex = 44;
            Salf_secretaryName.Text = "Secretary Name =";
            // 
            // labelDALF_SecretaryID
            // 
            labelDALF_SecretaryID.AutoSize = true;
            labelDALF_SecretaryID.BackColor = Color.Salmon;
            labelDALF_SecretaryID.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelDALF_SecretaryID.Location = new Point(16, 91);
            labelDALF_SecretaryID.Name = "labelDALF_SecretaryID";
            labelDALF_SecretaryID.Size = new Size(120, 23);
            labelDALF_SecretaryID.TabIndex = 43;
            labelDALF_SecretaryID.Text = "Secretary ID =";
            // 
            // button2
            // 
            button2.Location = new Point(68, 117);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(68, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelSecretaryAlf
            // 
            panelSecretaryAlf.BackColor = Color.White;
            panelSecretaryAlf.Dock = DockStyle.Fill;
            panelSecretaryAlf.Location = new Point(286, 0);
            panelSecretaryAlf.Name = "panelSecretaryAlf";
            panelSecretaryAlf.Size = new Size(998, 621);
            panelSecretaryAlf.TabIndex = 1;
            // 
            // SecretaryALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 621);
            Controls.Add(panelSecretaryAlf);
            Controls.Add(panel1);
            Name = "SecretaryALF";
            Text = "SecretaryALF";
            FormClosed += SecretaryALF_FormClosed;
            Load += SecretaryALF_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private Button button1;
        private Button SALF_MainPageInformation;
        private Button SALF_MainPageAppointments;
        private Button SALF_MainPageMakeAppointments;
        private Panel panel5;
        private Panel panelSecretaryAlf;
        private Label Salf_secretaryName;
        private Label labelDALF_SecretaryID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelPALF_Hg;
        private PictureBox pictureBox1;
    }
}