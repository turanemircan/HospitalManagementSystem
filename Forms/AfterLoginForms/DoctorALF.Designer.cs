namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class DoctorALF
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelDALF_DoctorID = new Label();
            labeDALF_DoctorName = new Label();
            buttonDALF_İnformation = new Button();
            buttonDALF_ViewAppointment = new Button();
            pictureBox1 = new PictureBox();
            panelDoctorALF = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelDALF_DoctorID);
            panel1.Controls.Add(labeDALF_DoctorName);
            panel1.Controls.Add(buttonDALF_İnformation);
            panel1.Controls.Add(buttonDALF_ViewAppointment);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 804);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // labelDALF_DoctorID
            // 
            labelDALF_DoctorID.AutoSize = true;
            labelDALF_DoctorID.Location = new Point(12, 64);
            labelDALF_DoctorID.Name = "labelDALF_DoctorID";
            labelDALF_DoctorID.Size = new Size(88, 20);
            labelDALF_DoctorID.TabIndex = 8;
            labelDALF_DoctorID.Text = "Doctor ID =";
            // 
            // labeDALF_DoctorName
            // 
            labeDALF_DoctorName.AutoSize = true;
            labeDALF_DoctorName.Location = new Point(12, 93);
            labeDALF_DoctorName.Name = "labeDALF_DoctorName";
            labeDALF_DoctorName.Size = new Size(113, 20);
            labeDALF_DoctorName.TabIndex = 1;
            labeDALF_DoctorName.Text = "Doctor Name =";
            // 
            // buttonDALF_İnformation
            // 
            buttonDALF_İnformation.Dock = DockStyle.Bottom;
            buttonDALF_İnformation.Location = new Point(0, 396);
            buttonDALF_İnformation.Name = "buttonDALF_İnformation";
            buttonDALF_İnformation.Size = new Size(286, 53);
            buttonDALF_İnformation.TabIndex = 7;
            buttonDALF_İnformation.Text = "İnformation";
            buttonDALF_İnformation.UseVisualStyleBackColor = true;
            buttonDALF_İnformation.Click += buttonDALF_İnformation_Click;
            // 
            // buttonDALF_ViewAppointment
            // 
            buttonDALF_ViewAppointment.Location = new Point(0, 347);
            buttonDALF_ViewAppointment.Name = "buttonDALF_ViewAppointment";
            buttonDALF_ViewAppointment.Size = new Size(286, 53);
            buttonDALF_ViewAppointment.TabIndex = 6;
            buttonDALF_ViewAppointment.Text = "View Appointment";
            buttonDALF_ViewAppointment.UseVisualStyleBackColor = true;
            buttonDALF_ViewAppointment.Click += buttonDALF_ViewAppointment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 449);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelDoctorALF
            // 
            panelDoctorALF.BackColor = Color.White;
            panelDoctorALF.Location = new Point(283, 0);
            panelDoctorALF.Name = "panelDoctorALF";
            panelDoctorALF.Size = new Size(1164, 804);
            panelDoctorALF.TabIndex = 1;
            // 
            // DoctorALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 804);
            Controls.Add(panelDoctorALF);
            Controls.Add(panel1);
            Name = "DoctorALF";
            Text = "DoctorALF";
            FormClosed += DoctorALF_FormClosed;
            Load += DoctorALF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonDALF_ViewAppointment;
        private Button button2;
        private Button buttonDALF_İnformation;
        private Label labeDALF_DoctorName;
        private Label labelDALF_DoctorID;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panelDoctorALF;
    }
}