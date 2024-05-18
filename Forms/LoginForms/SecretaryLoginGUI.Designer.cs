namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class SecretaryLoginGUI
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
            rjBtnSecretaryBackMain = new CustomTools.RJButton.RJButton();
            rjBtnSecretarySignIn = new CustomTools.RJButton.RJButton();
            rjTextBoxSecretaryPassword = new CustomTools.RJTextBox.RJTextBox();
            label_Secretary_Password = new Label();
            rjTextBoxSecretaryIdentificationNo = new CustomTools.RJTextBox.RJTextBox();
            label_Secretary_ID = new Label();
            lbl_SecretaryLoginGUI = new Label();
            SuspendLayout();
            // 
            // rjBtnSecretaryBackMain
            // 
            rjBtnSecretaryBackMain.BackColor = Color.White;
            rjBtnSecretaryBackMain.BackgroundColor = Color.White;
            rjBtnSecretaryBackMain.BorderColor = Color.RosyBrown;
            rjBtnSecretaryBackMain.BorderRadius = 20;
            rjBtnSecretaryBackMain.BorderSize = 0;
            rjBtnSecretaryBackMain.FlatAppearance.BorderSize = 0;
            rjBtnSecretaryBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnSecretaryBackMain.ForeColor = Color.White;
            rjBtnSecretaryBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnSecretaryBackMain.Location = new Point(3, 4);
            rjBtnSecretaryBackMain.Margin = new Padding(3, 4, 3, 4);
            rjBtnSecretaryBackMain.Name = "rjBtnSecretaryBackMain";
            rjBtnSecretaryBackMain.Size = new Size(46, 53);
            rjBtnSecretaryBackMain.TabIndex = 21;
            rjBtnSecretaryBackMain.TextColor = Color.White;
            rjBtnSecretaryBackMain.UseVisualStyleBackColor = false;
            rjBtnSecretaryBackMain.Click += rjBtnSecretaryBackMain_Click;
            // 
            // rjBtnSecretarySignIn
            // 
            rjBtnSecretarySignIn.BackColor = Color.Black;
            rjBtnSecretarySignIn.BackgroundColor = Color.Black;
            rjBtnSecretarySignIn.BorderColor = Color.Salmon;
            rjBtnSecretarySignIn.BorderRadius = 17;
            rjBtnSecretarySignIn.BorderSize = 0;
            rjBtnSecretarySignIn.FlatAppearance.BorderSize = 0;
            rjBtnSecretarySignIn.FlatStyle = FlatStyle.Flat;
            rjBtnSecretarySignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnSecretarySignIn.ForeColor = Color.White;
            rjBtnSecretarySignIn.Location = new Point(149, 337);
            rjBtnSecretarySignIn.Margin = new Padding(3, 4, 3, 4);
            rjBtnSecretarySignIn.Name = "rjBtnSecretarySignIn";
            rjBtnSecretarySignIn.Size = new Size(160, 41);
            rjBtnSecretarySignIn.TabIndex = 20;
            rjBtnSecretarySignIn.Text = "Sign in";
            rjBtnSecretarySignIn.TextColor = Color.White;
            rjBtnSecretarySignIn.UseVisualStyleBackColor = false;
            rjBtnSecretarySignIn.Click += rjBtnSecretarySignIn_Click;
            // 
            // rjTextBoxSecretaryPassword
            // 
            rjTextBoxSecretaryPassword.BackColor = SystemColors.Window;
            rjTextBoxSecretaryPassword.BorderColor = Color.Salmon;
            rjTextBoxSecretaryPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxSecretaryPassword.BorderRadius = 15;
            rjTextBoxSecretaryPassword.BorderSize = 2;
            rjTextBoxSecretaryPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxSecretaryPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxSecretaryPassword.Location = new Point(86, 268);
            rjTextBoxSecretaryPassword.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxSecretaryPassword.Multiline = false;
            rjTextBoxSecretaryPassword.Name = "rjTextBoxSecretaryPassword";
            rjTextBoxSecretaryPassword.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxSecretaryPassword.PasswordChar = true;
            rjTextBoxSecretaryPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxSecretaryPassword.PlaceholderText = "";
            rjTextBoxSecretaryPassword.Size = new Size(286, 39);
            rjTextBoxSecretaryPassword.TabIndex = 19;
            rjTextBoxSecretaryPassword.Texts = "";
            rjTextBoxSecretaryPassword.UnderlinedStyle = false;
            // 
            // label_Secretary_Password
            // 
            label_Secretary_Password.AutoSize = true;
            label_Secretary_Password.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Secretary_Password.Location = new Point(86, 239);
            label_Secretary_Password.Name = "label_Secretary_Password";
            label_Secretary_Password.Size = new Size(92, 25);
            label_Secretary_Password.TabIndex = 18;
            label_Secretary_Password.Text = "Password";
            // 
            // rjTextBoxSecretaryIdentificationNo
            // 
            rjTextBoxSecretaryIdentificationNo.BackColor = SystemColors.Window;
            rjTextBoxSecretaryIdentificationNo.BorderColor = Color.Salmon;
            rjTextBoxSecretaryIdentificationNo.BorderFocusColor = Color.HotPink;
            rjTextBoxSecretaryIdentificationNo.BorderRadius = 15;
            rjTextBoxSecretaryIdentificationNo.BorderSize = 2;
            rjTextBoxSecretaryIdentificationNo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxSecretaryIdentificationNo.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxSecretaryIdentificationNo.Location = new Point(86, 180);
            rjTextBoxSecretaryIdentificationNo.Margin = new Padding(5, 5, 5, 5);
            rjTextBoxSecretaryIdentificationNo.Multiline = false;
            rjTextBoxSecretaryIdentificationNo.Name = "rjTextBoxSecretaryIdentificationNo";
            rjTextBoxSecretaryIdentificationNo.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxSecretaryIdentificationNo.PasswordChar = false;
            rjTextBoxSecretaryIdentificationNo.PlaceholderColor = Color.DarkGray;
            rjTextBoxSecretaryIdentificationNo.PlaceholderText = "";
            rjTextBoxSecretaryIdentificationNo.Size = new Size(286, 39);
            rjTextBoxSecretaryIdentificationNo.TabIndex = 17;
            rjTextBoxSecretaryIdentificationNo.Texts = "";
            rjTextBoxSecretaryIdentificationNo.UnderlinedStyle = false;
            // 
            // label_Secretary_ID
            // 
            label_Secretary_ID.AutoSize = true;
            label_Secretary_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Secretary_ID.Location = new Point(86, 148);
            label_Secretary_ID.Name = "label_Secretary_ID";
            label_Secretary_ID.Size = new Size(157, 25);
            label_Secretary_ID.TabIndex = 16;
            label_Secretary_ID.Text = "Identification No";
            // 
            // lbl_SecretaryLoginGUI
            // 
            lbl_SecretaryLoginGUI.AutoSize = true;
            lbl_SecretaryLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_SecretaryLoginGUI.Location = new Point(151, 83);
            lbl_SecretaryLoginGUI.Name = "lbl_SecretaryLoginGUI";
            lbl_SecretaryLoginGUI.Size = new Size(163, 30);
            lbl_SecretaryLoginGUI.TabIndex = 15;
            lbl_SecretaryLoginGUI.Text = "Ready to Login";
            // 
            // SecretaryLoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 415);
            Controls.Add(rjBtnSecretaryBackMain);
            Controls.Add(rjBtnSecretarySignIn);
            Controls.Add(rjTextBoxSecretaryPassword);
            Controls.Add(label_Secretary_Password);
            Controls.Add(rjTextBoxSecretaryIdentificationNo);
            Controls.Add(label_Secretary_ID);
            Controls.Add(lbl_SecretaryLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SecretaryLoginGUI";
            Text = "SecretaryLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnSecretaryBackMain;
        private CustomTools.RJButton.RJButton rjBtnSecretarySignIn;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxSecretaryPassword;
        private Label label_Secretary_Password;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxSecretaryIdentificationNo;
        private Label label_Secretary_ID;
        private Label lbl_SecretaryLoginGUI;
    }
}