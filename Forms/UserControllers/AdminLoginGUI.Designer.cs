namespace HospitalManagementSystem.Forms.UserControllers
{
    partial class AdminLoginGUI
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
            rjBtnAdminBackMain = new CustomTools.RJButton.RJButton();
            rjBtnAdminSignIn = new CustomTools.RJButton.RJButton();
            rjTextBoxAdminPassword = new CustomTools.RJTextBox.RJTextBox();
            labelAdminPassword = new Label();
            rjTextBoxAdminIdentificationNo = new CustomTools.RJTextBox.RJTextBox();
            labelAdminID = new Label();
            lbl_AdminLoginGUI = new Label();
            SuspendLayout();
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
            rjBtnAdminBackMain.Location = new Point(3, 3);
            rjBtnAdminBackMain.Name = "rjBtnAdminBackMain";
            rjBtnAdminBackMain.Size = new Size(40, 40);
            rjBtnAdminBackMain.TabIndex = 21;
            rjBtnAdminBackMain.TextColor = Color.White;
            rjBtnAdminBackMain.UseVisualStyleBackColor = false;
            // 
            // rjBtnAdminSignIn
            // 
            rjBtnAdminSignIn.BackColor = Color.Black;
            rjBtnAdminSignIn.BackgroundColor = Color.Black;
            rjBtnAdminSignIn.BorderColor = Color.Salmon;
            rjBtnAdminSignIn.BorderRadius = 17;
            rjBtnAdminSignIn.BorderSize = 0;
            rjBtnAdminSignIn.FlatAppearance.BorderSize = 0;
            rjBtnAdminSignIn.FlatStyle = FlatStyle.Flat;
            rjBtnAdminSignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnAdminSignIn.ForeColor = Color.White;
            rjBtnAdminSignIn.Location = new Point(130, 253);
            rjBtnAdminSignIn.Name = "rjBtnAdminSignIn";
            rjBtnAdminSignIn.Size = new Size(140, 31);
            rjBtnAdminSignIn.TabIndex = 20;
            rjBtnAdminSignIn.Text = "Sign in";
            rjBtnAdminSignIn.TextColor = Color.White;
            rjBtnAdminSignIn.UseVisualStyleBackColor = false;
            // 
            // rjTextBoxAdminPassword
            // 
            rjTextBoxAdminPassword.BackColor = SystemColors.Window;
            rjTextBoxAdminPassword.BorderColor = Color.Salmon;
            rjTextBoxAdminPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxAdminPassword.BorderRadius = 15;
            rjTextBoxAdminPassword.BorderSize = 2;
            rjTextBoxAdminPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAdminPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAdminPassword.Location = new Point(75, 201);
            rjTextBoxAdminPassword.Margin = new Padding(4);
            rjTextBoxAdminPassword.Multiline = false;
            rjTextBoxAdminPassword.Name = "rjTextBoxAdminPassword";
            rjTextBoxAdminPassword.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxAdminPassword.PasswordChar = false;
            rjTextBoxAdminPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxAdminPassword.PlaceholderText = "";
            rjTextBoxAdminPassword.Size = new Size(250, 31);
            rjTextBoxAdminPassword.TabIndex = 19;
            rjTextBoxAdminPassword.Texts = "";
            rjTextBoxAdminPassword.UnderlinedStyle = false;
            // 
            // labelAdminPassword
            // 
            labelAdminPassword.AutoSize = true;
            labelAdminPassword.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAdminPassword.Location = new Point(75, 179);
            labelAdminPassword.Name = "labelAdminPassword";
            labelAdminPassword.Size = new Size(73, 20);
            labelAdminPassword.TabIndex = 18;
            labelAdminPassword.Text = "Password";
            // 
            // rjTextBoxAdminIdentificationNo
            // 
            rjTextBoxAdminIdentificationNo.BackColor = SystemColors.Window;
            rjTextBoxAdminIdentificationNo.BorderColor = Color.Salmon;
            rjTextBoxAdminIdentificationNo.BorderFocusColor = Color.HotPink;
            rjTextBoxAdminIdentificationNo.BorderRadius = 15;
            rjTextBoxAdminIdentificationNo.BorderSize = 2;
            rjTextBoxAdminIdentificationNo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAdminIdentificationNo.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAdminIdentificationNo.Location = new Point(75, 135);
            rjTextBoxAdminIdentificationNo.Margin = new Padding(4);
            rjTextBoxAdminIdentificationNo.Multiline = false;
            rjTextBoxAdminIdentificationNo.Name = "rjTextBoxAdminIdentificationNo";
            rjTextBoxAdminIdentificationNo.Padding = new Padding(10, 7, 10, 7);
            rjTextBoxAdminIdentificationNo.PasswordChar = false;
            rjTextBoxAdminIdentificationNo.PlaceholderColor = Color.DarkGray;
            rjTextBoxAdminIdentificationNo.PlaceholderText = "";
            rjTextBoxAdminIdentificationNo.Size = new Size(250, 31);
            rjTextBoxAdminIdentificationNo.TabIndex = 17;
            rjTextBoxAdminIdentificationNo.Texts = "";
            rjTextBoxAdminIdentificationNo.UnderlinedStyle = false;
            // 
            // labelAdminID
            // 
            labelAdminID.AutoSize = true;
            labelAdminID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAdminID.Location = new Point(75, 111);
            labelAdminID.Name = "labelAdminID";
            labelAdminID.Size = new Size(125, 20);
            labelAdminID.TabIndex = 16;
            labelAdminID.Text = "Identification No";
            // 
            // lbl_AdminLoginGUI
            // 
            lbl_AdminLoginGUI.AutoSize = true;
            lbl_AdminLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_AdminLoginGUI.Location = new Point(132, 62);
            lbl_AdminLoginGUI.Name = "lbl_AdminLoginGUI";
            lbl_AdminLoginGUI.Size = new Size(137, 25);
            lbl_AdminLoginGUI.TabIndex = 15;
            lbl_AdminLoginGUI.Text = "Ready to Login";
            // 
            // AdminLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(rjBtnAdminBackMain);
            Controls.Add(rjBtnAdminSignIn);
            Controls.Add(rjTextBoxAdminPassword);
            Controls.Add(labelAdminPassword);
            Controls.Add(rjTextBoxAdminIdentificationNo);
            Controls.Add(labelAdminID);
            Controls.Add(lbl_AdminLoginGUI);
            Name = "AdminLoginGUI";
            Size = new Size(400, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnAdminBackMain;
        private CustomTools.RJButton.RJButton rjBtnAdminSignIn;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAdminPassword;
        private Label labelAdminPassword;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAdminIdentificationNo;
        private Label labelAdminID;
        private Label lbl_AdminLoginGUI;
    }
}
