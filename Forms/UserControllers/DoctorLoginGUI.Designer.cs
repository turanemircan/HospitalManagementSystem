namespace HospitalManagementSystem.Forms.UserControllers
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

        #region Component Designer generated code

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
            rjBtnDoctorBackMain.Location = new Point(3, 3);
            rjBtnDoctorBackMain.Name = "rjBtnDoctorBackMain";
            rjBtnDoctorBackMain.Size = new Size(40, 40);
            rjBtnDoctorBackMain.TabIndex = 14;
            rjBtnDoctorBackMain.TextColor = Color.White;
            rjBtnDoctorBackMain.UseVisualStyleBackColor = false;
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
            rjBtnDoctorSignIn.Location = new Point(130, 253);
            rjBtnDoctorSignIn.Name = "rjBtnDoctorSignIn";
            rjBtnDoctorSignIn.Size = new Size(140, 31);
            rjBtnDoctorSignIn.TabIndex = 13;
            rjBtnDoctorSignIn.Text = "Sign in";
            rjBtnDoctorSignIn.TextColor = Color.White;
            rjBtnDoctorSignIn.UseVisualStyleBackColor = false;
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
            rjTextBoxDoctorPassword.Location = new Point(75, 201);
            rjTextBoxDoctorPassword.Margin = new Padding(4);
            rjTextBoxDoctorPassword.Multiline = false;
            rjTextBoxDoctorPassword.Name = "rjTextBoxDoctorPassword";
            rjTextBoxDoctorPassword.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxDoctorPassword.PasswordChar = false;
            rjTextBoxDoctorPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxDoctorPassword.PlaceholderText = "";
            rjTextBoxDoctorPassword.Size = new Size(250, 31);
            rjTextBoxDoctorPassword.TabIndex = 12;
            rjTextBoxDoctorPassword.Texts = "";
            rjTextBoxDoctorPassword.UnderlinedStyle = false;
            // 
            // labelDoctorPassword
            // 
            labelDoctorPassword.AutoSize = true;
            labelDoctorPassword.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorPassword.Location = new Point(75, 179);
            labelDoctorPassword.Name = "labelDoctorPassword";
            labelDoctorPassword.Size = new Size(73, 20);
            labelDoctorPassword.TabIndex = 11;
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
            rjTextBoxDoctorIdentificationNo.Location = new Point(75, 135);
            rjTextBoxDoctorIdentificationNo.Margin = new Padding(4);
            rjTextBoxDoctorIdentificationNo.Multiline = false;
            rjTextBoxDoctorIdentificationNo.Name = "rjTextBoxDoctorIdentificationNo";
            rjTextBoxDoctorIdentificationNo.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxDoctorIdentificationNo.PasswordChar = false;
            rjTextBoxDoctorIdentificationNo.PlaceholderColor = Color.DarkGray;
            rjTextBoxDoctorIdentificationNo.PlaceholderText = "";
            rjTextBoxDoctorIdentificationNo.Size = new Size(250, 31);
            rjTextBoxDoctorIdentificationNo.TabIndex = 10;
            rjTextBoxDoctorIdentificationNo.Texts = "";
            rjTextBoxDoctorIdentificationNo.UnderlinedStyle = false;
            // 
            // labelDoctorID
            // 
            labelDoctorID.AutoSize = true;
            labelDoctorID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorID.Location = new Point(75, 111);
            labelDoctorID.Name = "labelDoctorID";
            labelDoctorID.Size = new Size(125, 20);
            labelDoctorID.TabIndex = 9;
            labelDoctorID.Text = "Identification No";
            // 
            // lbl_DoctorLoginGUI
            // 
            lbl_DoctorLoginGUI.AutoSize = true;
            lbl_DoctorLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_DoctorLoginGUI.Location = new Point(132, 62);
            lbl_DoctorLoginGUI.Name = "lbl_DoctorLoginGUI";
            lbl_DoctorLoginGUI.Size = new Size(137, 25);
            lbl_DoctorLoginGUI.TabIndex = 8;
            lbl_DoctorLoginGUI.Text = "Ready to Login";
            // 
            // DoctorLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(rjBtnDoctorBackMain);
            Controls.Add(rjBtnDoctorSignIn);
            Controls.Add(rjTextBoxDoctorPassword);
            Controls.Add(labelDoctorPassword);
            Controls.Add(rjTextBoxDoctorIdentificationNo);
            Controls.Add(labelDoctorID);
            Controls.Add(lbl_DoctorLoginGUI);
            Name = "DoctorLoginGUI";
            Size = new Size(400, 350);
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
