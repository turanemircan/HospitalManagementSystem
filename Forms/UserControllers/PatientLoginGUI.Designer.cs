namespace HospitalManagementSystem.Forms.UserControllers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_PatientLoginGUI = new Label();
            label1 = new Label();
            rjTextBox1 = new CustomTools.RJTextBox.RJTextBox();
            rjTextBox2 = new CustomTools.RJTextBox.RJTextBox();
            label2 = new Label();
            rjButton1 = new CustomTools.RJButton.RJButton();
            rjButton2 = new CustomTools.RJButton.RJButton();
            rjBtnBackMainForm = new CustomTools.RJButton.RJButton();
            SuspendLayout();
            // 
            // lbl_PatientLoginGUI
            // 
            lbl_PatientLoginGUI.AutoSize = true;
            lbl_PatientLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_PatientLoginGUI.Location = new Point(132, 62);
            lbl_PatientLoginGUI.Name = "lbl_PatientLoginGUI";
            lbl_PatientLoginGUI.Size = new Size(137, 25);
            lbl_PatientLoginGUI.TabIndex = 0;
            lbl_PatientLoginGUI.Text = "Ready to Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(75, 111);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Identification No";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.Salmon;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(75, 135);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(250, 31);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.Salmon;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 15;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(75, 201);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(250, 31);
            rjTextBox2.TabIndex = 4;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(75, 179);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Black;
            rjButton1.BackgroundColor = Color.Black;
            rjButton1.BorderColor = Color.Salmon;
            rjButton1.BorderRadius = 17;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(130, 253);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(140, 31);
            rjButton1.TabIndex = 5;
            rjButton1.Text = "Sign in";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Black;
            rjButton2.BackgroundColor = Color.Black;
            rjButton2.BorderColor = Color.Salmon;
            rjButton2.BorderRadius = 17;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(323, 7);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(74, 31);
            rjButton2.TabIndex = 6;
            rjButton2.Text = "Sign Up";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjBtnBackMainForm
            // 
            rjBtnBackMainForm.BackColor = Color.White;
            rjBtnBackMainForm.BackgroundColor = Color.White;
            rjBtnBackMainForm.BorderColor = Color.RosyBrown;
            rjBtnBackMainForm.BorderRadius = 20;
            rjBtnBackMainForm.BorderSize = 0;
            rjBtnBackMainForm.FlatAppearance.BorderSize = 0;
            rjBtnBackMainForm.FlatStyle = FlatStyle.Flat;
            rjBtnBackMainForm.ForeColor = Color.White;
            rjBtnBackMainForm.Image = Properties.Resources.LeftArrowIcon;
            rjBtnBackMainForm.Location = new Point(3, 3);
            rjBtnBackMainForm.Name = "rjBtnBackMainForm";
            rjBtnBackMainForm.Size = new Size(40, 40);
            rjBtnBackMainForm.TabIndex = 7;
            rjBtnBackMainForm.TextColor = Color.White;
            rjBtnBackMainForm.UseVisualStyleBackColor = false;
            // 
            // PatientLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(rjBtnBackMainForm);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(rjTextBox2);
            Controls.Add(label2);
            Controls.Add(rjTextBox1);
            Controls.Add(label1);
            Controls.Add(lbl_PatientLoginGUI);
            Name = "PatientLoginGUI";
            Size = new Size(400, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_PatientLoginGUI;
        private Label label1;
        private CustomTools.RJTextBox.RJTextBox rjTextBox1;
        private CustomTools.RJTextBox.RJTextBox rjTextBox2;
        private Label label2;
        private CustomTools.RJButton.RJButton rjButton1;
        private CustomTools.RJButton.RJButton rjButton2;
        private CustomTools.RJButton.RJButton rjBtnBackMainForm;
    }
}
