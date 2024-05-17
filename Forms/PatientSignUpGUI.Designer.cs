namespace HospitalManagementSystem.Forms
{
    partial class PatientSignUpGUI
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
            rjTextPatientSurname = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxPatientName = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxGSMNumber = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxIdentificationNo = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxPatientPassword = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxPatientAgainPassword = new CustomTools.RJTextBox.RJTextBox();
            rjBtnPatientSignUp = new CustomTools.RJButton.RJButton();
            rjBtnAdminBackMain = new CustomTools.RJButton.RJButton();
            lbl_AdminLoginGUI = new Label();
            SuspendLayout();
            // 
            // rjTextPatientSurname
            // 
            rjTextPatientSurname.BackColor = SystemColors.Window;
            rjTextPatientSurname.BorderColor = Color.Salmon;
            rjTextPatientSurname.BorderFocusColor = Color.HotPink;
            rjTextPatientSurname.BorderRadius = 15;
            rjTextPatientSurname.BorderSize = 2;
            rjTextPatientSurname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            rjTextPatientSurname.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextPatientSurname.Location = new Point(86, 124);
            rjTextPatientSurname.Margin = new Padding(5, 5, 5, 5);
            rjTextPatientSurname.Multiline = false;
            rjTextPatientSurname.Name = "rjTextPatientSurname";
            rjTextPatientSurname.Padding = new Padding(11, 9, 11, 9);
            rjTextPatientSurname.PasswordChar = false;
            rjTextPatientSurname.PlaceholderColor = Color.Gray;
            rjTextPatientSurname.PlaceholderText = "Surname";
            rjTextPatientSurname.Size = new Size(286, 40);
            rjTextPatientSurname.TabIndex = 28;
            rjTextPatientSurname.Texts = "";
            rjTextPatientSurname.UnderlinedStyle = false;
            // 
            // rjTextBoxPatientName
            // 
            rjTextBoxPatientName.BackColor = SystemColors.Window;
            rjTextBoxPatientName.BorderColor = Color.Salmon;
            rjTextBoxPatientName.BorderFocusColor = Color.HotPink;
            rjTextBoxPatientName.BorderRadius = 15;
            rjTextBoxPatientName.BorderSize = 2;
            rjTextBoxPatientName.Font = new Font("Yu Gothic UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxPatientName.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxPatientName.Location = new Point(86, 72);
            rjTextBoxPatientName.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxPatientName.Multiline = false;
            rjTextBoxPatientName.Name = "rjTextBoxPatientName";
            rjTextBoxPatientName.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxPatientName.PasswordChar = false;
            rjTextBoxPatientName.PlaceholderColor = Color.Gray;
            rjTextBoxPatientName.PlaceholderText = "Name";
            rjTextBoxPatientName.RightToLeft = RightToLeft.No;
            rjTextBoxPatientName.Size = new Size(286, 40);
            rjTextBoxPatientName.TabIndex = 27;
            rjTextBoxPatientName.Texts = "";
            rjTextBoxPatientName.UnderlinedStyle = false;
            rjTextBoxPatientName.Load += rjTextBoxPatientName_Load;
            // 
            // rjTextBoxGSMNumber
            // 
            rjTextBoxGSMNumber.BackColor = SystemColors.Window;
            rjTextBoxGSMNumber.BorderColor = Color.Salmon;
            rjTextBoxGSMNumber.BorderFocusColor = Color.HotPink;
            rjTextBoxGSMNumber.BorderRadius = 15;
            rjTextBoxGSMNumber.BorderSize = 2;
            rjTextBoxGSMNumber.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            rjTextBoxGSMNumber.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxGSMNumber.Location = new Point(86, 228);
            rjTextBoxGSMNumber.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxGSMNumber.Multiline = false;
            rjTextBoxGSMNumber.Name = "rjTextBoxGSMNumber";
            rjTextBoxGSMNumber.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxGSMNumber.PasswordChar = false;
            rjTextBoxGSMNumber.PlaceholderColor = Color.Gray;
            rjTextBoxGSMNumber.PlaceholderText = "GSM No";
            rjTextBoxGSMNumber.Size = new Size(286, 40);
            rjTextBoxGSMNumber.TabIndex = 30;
            rjTextBoxGSMNumber.Texts = "";
            rjTextBoxGSMNumber.UnderlinedStyle = false;
            // 
            // rjTextBoxIdentificationNo
            // 
            rjTextBoxIdentificationNo.BackColor = SystemColors.Window;
            rjTextBoxIdentificationNo.BorderColor = Color.Salmon;
            rjTextBoxIdentificationNo.BorderFocusColor = Color.HotPink;
            rjTextBoxIdentificationNo.BorderRadius = 15;
            rjTextBoxIdentificationNo.BorderSize = 2;
            rjTextBoxIdentificationNo.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            rjTextBoxIdentificationNo.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxIdentificationNo.Location = new Point(86, 176);
            rjTextBoxIdentificationNo.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxIdentificationNo.Multiline = false;
            rjTextBoxIdentificationNo.Name = "rjTextBoxIdentificationNo";
            rjTextBoxIdentificationNo.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxIdentificationNo.PasswordChar = false;
            rjTextBoxIdentificationNo.PlaceholderColor = Color.Gray;
            rjTextBoxIdentificationNo.PlaceholderText = "Identification No";
            rjTextBoxIdentificationNo.Size = new Size(286, 40);
            rjTextBoxIdentificationNo.TabIndex = 29;
            rjTextBoxIdentificationNo.Texts = "";
            rjTextBoxIdentificationNo.UnderlinedStyle = false;
            // 
            // rjTextBoxPatientPassword
            // 
            rjTextBoxPatientPassword.BackColor = SystemColors.Window;
            rjTextBoxPatientPassword.BorderColor = Color.Salmon;
            rjTextBoxPatientPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxPatientPassword.BorderRadius = 15;
            rjTextBoxPatientPassword.BorderSize = 2;
            rjTextBoxPatientPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            rjTextBoxPatientPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxPatientPassword.Location = new Point(86, 280);
            rjTextBoxPatientPassword.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxPatientPassword.Multiline = false;
            rjTextBoxPatientPassword.Name = "rjTextBoxPatientPassword";
<<<<<<< HEAD
            rjTextBoxPatientPassword.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxPatientPassword.PasswordChar = true;
=======
            rjTextBoxPatientPassword.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxPatientPassword.PasswordChar = false;
>>>>>>> 63870c915e80762956d832c3a28a2795efda6fb5
            rjTextBoxPatientPassword.PlaceholderColor = Color.Gray;
            rjTextBoxPatientPassword.PlaceholderText = "Password";
            rjTextBoxPatientPassword.Size = new Size(286, 40);
            rjTextBoxPatientPassword.TabIndex = 31;
            rjTextBoxPatientPassword.Texts = "";
            rjTextBoxPatientPassword.UnderlinedStyle = false;
            // 
            // rjTextBoxPatientAgainPassword
            // 
            rjTextBoxPatientAgainPassword.BackColor = SystemColors.Window;
            rjTextBoxPatientAgainPassword.BorderColor = Color.Salmon;
            rjTextBoxPatientAgainPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxPatientAgainPassword.BorderRadius = 15;
            rjTextBoxPatientAgainPassword.BorderSize = 2;
            rjTextBoxPatientAgainPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            rjTextBoxPatientAgainPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxPatientAgainPassword.Location = new Point(86, 332);
            rjTextBoxPatientAgainPassword.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxPatientAgainPassword.Multiline = false;
            rjTextBoxPatientAgainPassword.Name = "rjTextBoxPatientAgainPassword";
<<<<<<< HEAD
            rjTextBoxPatientAgainPassword.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxPatientAgainPassword.PasswordChar = true;
=======
            rjTextBoxPatientAgainPassword.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxPatientAgainPassword.PasswordChar = false;
>>>>>>> 63870c915e80762956d832c3a28a2795efda6fb5
            rjTextBoxPatientAgainPassword.PlaceholderColor = Color.Gray;
            rjTextBoxPatientAgainPassword.PlaceholderText = "Password Again";
            rjTextBoxPatientAgainPassword.Size = new Size(286, 40);
            rjTextBoxPatientAgainPassword.TabIndex = 32;
            rjTextBoxPatientAgainPassword.Texts = "";
            rjTextBoxPatientAgainPassword.UnderlinedStyle = false;
            // 
            // rjBtnPatientSignUp
            // 
            rjBtnPatientSignUp.BackColor = Color.Black;
            rjBtnPatientSignUp.BackgroundColor = Color.Black;
            rjBtnPatientSignUp.BorderColor = Color.Salmon;
            rjBtnPatientSignUp.BorderRadius = 17;
            rjBtnPatientSignUp.BorderSize = 0;
            rjBtnPatientSignUp.FlatAppearance.BorderSize = 0;
            rjBtnPatientSignUp.FlatStyle = FlatStyle.Flat;
            rjBtnPatientSignUp.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnPatientSignUp.ForeColor = Color.White;
            rjBtnPatientSignUp.Location = new Point(149, 399);
            rjBtnPatientSignUp.Margin = new Padding(3, 4, 3, 4);
            rjBtnPatientSignUp.Name = "rjBtnPatientSignUp";
            rjBtnPatientSignUp.Size = new Size(160, 41);
            rjBtnPatientSignUp.TabIndex = 33;
            rjBtnPatientSignUp.Text = "Sign Up";
            rjBtnPatientSignUp.TextColor = Color.White;
            rjBtnPatientSignUp.UseVisualStyleBackColor = false;
            // 
            // rjBtnAdminBackMain
            // 
            rjBtnAdminBackMain.BackColor = Color.White;
            rjBtnAdminBackMain.BackgroundColor = Color.White;
            rjBtnAdminBackMain.BorderColor = Color.RosyBrown;
            rjBtnAdminBackMain.BorderRadius = 20;
            rjBtnAdminBackMain.BorderSize = 0;
            rjBtnAdminBackMain.FlatAppearance.BorderSize = 0;
            rjBtnAdminBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnAdminBackMain.ForeColor = Color.White;
            rjBtnAdminBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnAdminBackMain.Location = new Point(3, 4);
            rjBtnAdminBackMain.Margin = new Padding(3, 4, 3, 4);
            rjBtnAdminBackMain.Name = "rjBtnAdminBackMain";
            rjBtnAdminBackMain.Size = new Size(46, 53);
            rjBtnAdminBackMain.TabIndex = 35;
            rjBtnAdminBackMain.TextColor = Color.White;
            rjBtnAdminBackMain.UseVisualStyleBackColor = false;
            rjBtnAdminBackMain.Click += rjBtnAdminBackMain_Click;
            // 
            // lbl_AdminLoginGUI
            // 
            lbl_AdminLoginGUI.AutoSize = true;
            lbl_AdminLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_AdminLoginGUI.Location = new Point(183, 13);
            lbl_AdminLoginGUI.Name = "lbl_AdminLoginGUI";
            lbl_AdminLoginGUI.Size = new Size(95, 30);
            lbl_AdminLoginGUI.TabIndex = 36;
            lbl_AdminLoginGUI.Text = "Register";
            // 
            // PatientSignUpGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 467);
            Controls.Add(lbl_AdminLoginGUI);
            Controls.Add(rjBtnAdminBackMain);
            Controls.Add(rjBtnPatientSignUp);
            Controls.Add(rjTextBoxPatientAgainPassword);
            Controls.Add(rjTextBoxPatientPassword);
            Controls.Add(rjTextBoxGSMNumber);
            Controls.Add(rjTextBoxIdentificationNo);
            Controls.Add(rjTextPatientSurname);
            Controls.Add(rjTextBoxPatientName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientSignUpGUI";
            Text = "PatientSignUpGUI";
            Load += PatientSignUpGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJTextBox.RJTextBox rjTextPatientSurname;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxPatientName;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxGSMNumber;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxIdentificationNo;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxPatientPassword;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxPatientAgainPassword;
        private CustomTools.RJButton.RJButton rjBtnPatientSignUp;
        private CustomTools.RJButton.RJButton rjBtnAdminBackMain;
        private Label lbl_AdminLoginGUI;
    }
}