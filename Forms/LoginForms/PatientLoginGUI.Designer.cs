namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class PatientLoginGUI
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
            rjBtnPatientBackMain = new CustomTools.RJButton.RJButton();
            rjBtnPatientSignUp = new CustomTools.RJButton.RJButton();
            rjBtnPatientSignIn = new CustomTools.RJButton.RJButton();
            rjTextBoxPatientPassword = new CustomTools.RJTextBox.RJTextBox();
            label_Patient_Password = new Label();
            rjTextBoxPatientIdentificationNo = new CustomTools.RJTextBox.RJTextBox();
            label_Patient_ID = new Label();
            lbl_PatientLoginGUI = new Label();
            SuspendLayout();
            // 
            // rjBtnPatientBackMain
            // 
            rjBtnPatientBackMain.BackColor = Color.White;
            rjBtnPatientBackMain.BackgroundColor = Color.White;
            rjBtnPatientBackMain.BorderColor = Color.RosyBrown;
            rjBtnPatientBackMain.BorderRadius = 20;
            rjBtnPatientBackMain.BorderSize = 0;
            rjBtnPatientBackMain.FlatAppearance.BorderSize = 0;
            rjBtnPatientBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnPatientBackMain.ForeColor = Color.White;
            rjBtnPatientBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnPatientBackMain.Location = new Point(3, 3);
            rjBtnPatientBackMain.Name = "rjBtnPatientBackMain";
            rjBtnPatientBackMain.Size = new Size(40, 40);
            rjBtnPatientBackMain.TabIndex = 15;
            rjBtnPatientBackMain.TextColor = Color.White;
            rjBtnPatientBackMain.UseVisualStyleBackColor = false;
            rjBtnPatientBackMain.Click += rjBtnPatientBackMain_Click;
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
            rjBtnPatientSignUp.Location = new Point(323, 7);
            rjBtnPatientSignUp.Name = "rjBtnPatientSignUp";
            rjBtnPatientSignUp.Size = new Size(74, 31);
            rjBtnPatientSignUp.TabIndex = 14;
            rjBtnPatientSignUp.Text = "Sign Up";
            rjBtnPatientSignUp.TextColor = Color.White;
            rjBtnPatientSignUp.UseVisualStyleBackColor = false;
            rjBtnPatientSignUp.Click += rjBtnPatientSignUp_Click;
            // 
            // rjBtnPatientSignIn
            // 
            rjBtnPatientSignIn.BackColor = Color.Black;
            rjBtnPatientSignIn.BackgroundColor = Color.Black;
            rjBtnPatientSignIn.BorderColor = Color.Salmon;
            rjBtnPatientSignIn.BorderRadius = 17;
            rjBtnPatientSignIn.BorderSize = 0;
            rjBtnPatientSignIn.FlatAppearance.BorderSize = 0;
            rjBtnPatientSignIn.FlatStyle = FlatStyle.Flat;
            rjBtnPatientSignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnPatientSignIn.ForeColor = Color.White;
            rjBtnPatientSignIn.Location = new Point(130, 253);
            rjBtnPatientSignIn.Name = "rjBtnPatientSignIn";
            rjBtnPatientSignIn.Size = new Size(140, 31);
            rjBtnPatientSignIn.TabIndex = 13;
            rjBtnPatientSignIn.Text = "Sign in";
            rjBtnPatientSignIn.TextColor = Color.White;
            rjBtnPatientSignIn.UseVisualStyleBackColor = false;
            // 
            // rjTextBoxPatientPassword
            // 
            rjTextBoxPatientPassword.BackColor = SystemColors.Window;
            rjTextBoxPatientPassword.BorderColor = Color.Salmon;
            rjTextBoxPatientPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxPatientPassword.BorderRadius = 15;
            rjTextBoxPatientPassword.BorderSize = 2;
            rjTextBoxPatientPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxPatientPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxPatientPassword.Location = new Point(75, 201);
            rjTextBoxPatientPassword.Margin = new Padding(4);
            rjTextBoxPatientPassword.Multiline = false;
            rjTextBoxPatientPassword.Name = "rjTextBoxPatientPassword";
            rjTextBoxPatientPassword.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxPatientPassword.PasswordChar = false;
            rjTextBoxPatientPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxPatientPassword.PlaceholderText = "";
            rjTextBoxPatientPassword.Size = new Size(250, 31);
            rjTextBoxPatientPassword.TabIndex = 12;
            rjTextBoxPatientPassword.Texts = "";
            rjTextBoxPatientPassword.UnderlinedStyle = false;
            // 
            // label_Patient_Password
            // 
            label_Patient_Password.AutoSize = true;
            label_Patient_Password.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Patient_Password.Location = new Point(75, 179);
            label_Patient_Password.Name = "label_Patient_Password";
            label_Patient_Password.Size = new Size(73, 20);
            label_Patient_Password.TabIndex = 11;
            label_Patient_Password.Text = "Password";
            // 
            // rjTextBoxPatientIdentificationNo
            // 
            rjTextBoxPatientIdentificationNo.BackColor = SystemColors.Window;
            rjTextBoxPatientIdentificationNo.BorderColor = Color.Salmon;
            rjTextBoxPatientIdentificationNo.BorderFocusColor = Color.HotPink;
            rjTextBoxPatientIdentificationNo.BorderRadius = 15;
            rjTextBoxPatientIdentificationNo.BorderSize = 2;
            rjTextBoxPatientIdentificationNo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxPatientIdentificationNo.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxPatientIdentificationNo.Location = new Point(75, 135);
            rjTextBoxPatientIdentificationNo.Margin = new Padding(4);
            rjTextBoxPatientIdentificationNo.Multiline = false;
            rjTextBoxPatientIdentificationNo.Name = "rjTextBoxPatientIdentificationNo";
            rjTextBoxPatientIdentificationNo.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxPatientIdentificationNo.PasswordChar = false;
            rjTextBoxPatientIdentificationNo.PlaceholderColor = Color.DarkGray;
            rjTextBoxPatientIdentificationNo.PlaceholderText = "";
            rjTextBoxPatientIdentificationNo.Size = new Size(250, 31);
            rjTextBoxPatientIdentificationNo.TabIndex = 10;
            rjTextBoxPatientIdentificationNo.Texts = "";
            rjTextBoxPatientIdentificationNo.UnderlinedStyle = false;
            // 
            // label_Patient_ID
            // 
            label_Patient_ID.AutoSize = true;
            label_Patient_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Patient_ID.Location = new Point(75, 111);
            label_Patient_ID.Name = "label_Patient_ID";
            label_Patient_ID.Size = new Size(124, 20);
            label_Patient_ID.TabIndex = 9;
            label_Patient_ID.Text = "Identification No";
            // 
            // lbl_PatientLoginGUI
            // 
            lbl_PatientLoginGUI.AutoSize = true;
            lbl_PatientLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_PatientLoginGUI.Location = new Point(132, 62);
            lbl_PatientLoginGUI.Name = "lbl_PatientLoginGUI";
            lbl_PatientLoginGUI.Size = new Size(137, 25);
            lbl_PatientLoginGUI.TabIndex = 8;
            lbl_PatientLoginGUI.Text = "Ready to Login";
            // 
            // PatientLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(rjBtnPatientBackMain);
            Controls.Add(rjBtnPatientSignUp);
            Controls.Add(rjBtnPatientSignIn);
            Controls.Add(rjTextBoxPatientPassword);
            Controls.Add(label_Patient_Password);
            Controls.Add(rjTextBoxPatientIdentificationNo);
            Controls.Add(label_Patient_ID);
            Controls.Add(lbl_PatientLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientLoginGUI";
            Text = "PatientLoginGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnPatientBackMain;
        private CustomTools.RJButton.RJButton rjBtnPatientSignUp;
        private CustomTools.RJButton.RJButton rjBtnPatientSignIn;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxPatientPassword;
        private Label label_Patient_Password;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxPatientIdentificationNo;
        private Label label_Patient_ID;
        private Label lbl_PatientLoginGUI;
    }
}