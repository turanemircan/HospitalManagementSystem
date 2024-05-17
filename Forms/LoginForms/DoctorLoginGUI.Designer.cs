namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class DoctorLoginGUI
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
            rjBtnDoctorBackMain = new CustomTools.RJButton.RJButton();
            rjBtnDoctorSignIn = new CustomTools.RJButton.RJButton();
            rjTextBoxDoctorPassword = new CustomTools.RJTextBox.RJTextBox();
            labelDoctorPassword = new Label();
            rjTextBoxDoctorIdentificationNo = new CustomTools.RJTextBox.RJTextBox();
            labelDoctorID = new Label();
            lbl_DoctorLoginGUI = new Label();
            SuspendLayout();
            // 
            // rjBtnDoctorBackMain
            // 
            rjBtnDoctorBackMain.BackColor = Color.White;
            rjBtnDoctorBackMain.BackgroundColor = Color.White;
            rjBtnDoctorBackMain.BorderColor = Color.RosyBrown;
            rjBtnDoctorBackMain.BorderRadius = 20;
            rjBtnDoctorBackMain.BorderSize = 0;
            rjBtnDoctorBackMain.FlatAppearance.BorderSize = 0;
            rjBtnDoctorBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnDoctorBackMain.ForeColor = Color.White;
            rjBtnDoctorBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnDoctorBackMain.Location = new Point(3, 4);
            rjBtnDoctorBackMain.Margin = new Padding(3, 4, 3, 4);
            rjBtnDoctorBackMain.Name = "rjBtnDoctorBackMain";
            rjBtnDoctorBackMain.Size = new Size(46, 53);
            rjBtnDoctorBackMain.TabIndex = 21;
            rjBtnDoctorBackMain.TextColor = Color.White;
            rjBtnDoctorBackMain.UseVisualStyleBackColor = false;
            rjBtnDoctorBackMain.Click += rjBtnDoctorBackMain_Click;
            // 
            // rjBtnDoctorSignIn
            // 
            rjBtnDoctorSignIn.BackColor = Color.Black;
            rjBtnDoctorSignIn.BackgroundColor = Color.Black;
            rjBtnDoctorSignIn.BorderColor = Color.Salmon;
            rjBtnDoctorSignIn.BorderRadius = 17;
            rjBtnDoctorSignIn.BorderSize = 0;
            rjBtnDoctorSignIn.FlatAppearance.BorderSize = 0;
            rjBtnDoctorSignIn.FlatStyle = FlatStyle.Flat;
            rjBtnDoctorSignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnDoctorSignIn.ForeColor = Color.White;
            rjBtnDoctorSignIn.Location = new Point(149, 337);
            rjBtnDoctorSignIn.Margin = new Padding(3, 4, 3, 4);
            rjBtnDoctorSignIn.Name = "rjBtnDoctorSignIn";
            rjBtnDoctorSignIn.Size = new Size(160, 41);
            rjBtnDoctorSignIn.TabIndex = 20;
            rjBtnDoctorSignIn.Text = "Sign in";
            rjBtnDoctorSignIn.TextColor = Color.White;
            rjBtnDoctorSignIn.UseVisualStyleBackColor = false;
            rjBtnDoctorSignIn.Click += rjBtnDoctorSignIn_Click;
            // 
            // rjTextBoxDoctorPassword
            // 
            rjTextBoxDoctorPassword.BackColor = SystemColors.Window;
            rjTextBoxDoctorPassword.BorderColor = Color.Salmon;
            rjTextBoxDoctorPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxDoctorPassword.BorderRadius = 15;
            rjTextBoxDoctorPassword.BorderSize = 2;
            rjTextBoxDoctorPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxDoctorPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxDoctorPassword.Location = new Point(86, 268);
            rjTextBoxDoctorPassword.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxDoctorPassword.Multiline = false;
            rjTextBoxDoctorPassword.Name = "rjTextBoxDoctorPassword";
            rjTextBoxDoctorPassword.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxDoctorPassword.PasswordChar = true;
            rjTextBoxDoctorPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxDoctorPassword.PlaceholderText = "";
            rjTextBoxDoctorPassword.Size = new Size(286, 39);
            rjTextBoxDoctorPassword.TabIndex = 19;
            rjTextBoxDoctorPassword.Texts = "";
            rjTextBoxDoctorPassword.UnderlinedStyle = false;
            // 
            // labelDoctorPassword
            // 
            labelDoctorPassword.AutoSize = true;
            labelDoctorPassword.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorPassword.Location = new Point(86, 239);
            labelDoctorPassword.Name = "labelDoctorPassword";
            labelDoctorPassword.Size = new Size(92, 25);
            labelDoctorPassword.TabIndex = 18;
            labelDoctorPassword.Text = "Password";
            // 
            // rjTextBoxDoctorIdentificationNo
            // 
            rjTextBoxDoctorIdentificationNo.BackColor = SystemColors.Window;
            rjTextBoxDoctorIdentificationNo.BorderColor = Color.Salmon;
            rjTextBoxDoctorIdentificationNo.BorderFocusColor = Color.HotPink;
            rjTextBoxDoctorIdentificationNo.BorderRadius = 15;
            rjTextBoxDoctorIdentificationNo.BorderSize = 2;
            rjTextBoxDoctorIdentificationNo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxDoctorIdentificationNo.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxDoctorIdentificationNo.Location = new Point(86, 180);
            rjTextBoxDoctorIdentificationNo.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxDoctorIdentificationNo.Multiline = false;
            rjTextBoxDoctorIdentificationNo.Name = "rjTextBoxDoctorIdentificationNo";
            rjTextBoxDoctorIdentificationNo.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxDoctorIdentificationNo.PasswordChar = false;
            rjTextBoxDoctorIdentificationNo.PlaceholderColor = Color.DarkGray;
            rjTextBoxDoctorIdentificationNo.PlaceholderText = "";
            rjTextBoxDoctorIdentificationNo.Size = new Size(286, 39);
            rjTextBoxDoctorIdentificationNo.TabIndex = 17;
            rjTextBoxDoctorIdentificationNo.Texts = "";
            rjTextBoxDoctorIdentificationNo.UnderlinedStyle = false;
            // 
            // labelDoctorID
            // 
            labelDoctorID.AutoSize = true;
            labelDoctorID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorID.Location = new Point(86, 148);
            labelDoctorID.Name = "labelDoctorID";
            labelDoctorID.Size = new Size(157, 25);
            labelDoctorID.TabIndex = 16;
            labelDoctorID.Text = "Identification No";
            // 
            // lbl_DoctorLoginGUI
            // 
            lbl_DoctorLoginGUI.AutoSize = true;
            lbl_DoctorLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_DoctorLoginGUI.Location = new Point(151, 83);
            lbl_DoctorLoginGUI.Name = "lbl_DoctorLoginGUI";
            lbl_DoctorLoginGUI.Size = new Size(163, 30);
            lbl_DoctorLoginGUI.TabIndex = 15;
            lbl_DoctorLoginGUI.Text = "Ready to Login";
            // 
            // DoctorLoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 467);
            Controls.Add(rjBtnDoctorBackMain);
            Controls.Add(rjBtnDoctorSignIn);
            Controls.Add(rjTextBoxDoctorPassword);
            Controls.Add(labelDoctorPassword);
            Controls.Add(rjTextBoxDoctorIdentificationNo);
            Controls.Add(labelDoctorID);
            Controls.Add(lbl_DoctorLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorLoginGUI";
            Text = "DoctorLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnDoctorBackMain;
        private CustomTools.RJButton.RJButton rjBtnDoctorSignIn;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxDoctorPassword;
        private Label labelDoctorPassword;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxDoctorIdentificationNo;
        private Label labelDoctorID;
        private Label lbl_DoctorLoginGUI;
    }
}