namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class AALF_DoctorEdit
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
            buttonAALF_DoctorSave = new CustomTools.RJButton.RJButton();
            buttonAALF_DoctorDelete = new CustomTools.RJButton.RJButton();
            buttonAALF_DoctorUpdate = new CustomTools.RJButton.RJButton();
            labelAALF_Branch = new Label();
            labelAALF_phon = new Label();
            labelAALF_ID = new Label();
            labelAALF_Name = new Label();
            rjTextBoxAALF_DoctorBranch = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxAALF_DoctorPassword = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxAALF_DoctorPhone = new CustomTools.RJTextBox.RJTextBox();
            rjTextBoxAALF_DoctorIDentification = new CustomTools.RJTextBox.RJTextBox();
            labelAALF_Pass = new Label();
            rjTextBoxAALF_DoctorSurname = new CustomTools.RJTextBox.RJTextBox();
            labelAALF_Surnam = new Label();
            rjTextBoxAALF_DoctorName = new CustomTools.RJTextBox.RJTextBox();
            labelAALF_Doc = new Label();
            dataGridViewAALF_Doctor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).BeginInit();
            SuspendLayout();
            // 
            // buttonAALF_DoctorSave
            // 
            buttonAALF_DoctorSave.BackColor = Color.Salmon;
            buttonAALF_DoctorSave.BackgroundColor = Color.Salmon;
            buttonAALF_DoctorSave.BorderColor = Color.Salmon;
            buttonAALF_DoctorSave.BorderRadius = 15;
            buttonAALF_DoctorSave.BorderSize = 0;
            buttonAALF_DoctorSave.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorSave.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorSave.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorSave.ForeColor = Color.White;
            buttonAALF_DoctorSave.Location = new Point(193, 410);
            buttonAALF_DoctorSave.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorSave.Name = "buttonAALF_DoctorSave";
            buttonAALF_DoctorSave.Size = new Size(286, 43);
            buttonAALF_DoctorSave.TabIndex = 72;
            buttonAALF_DoctorSave.Text = "Save";
            buttonAALF_DoctorSave.TextColor = Color.White;
            buttonAALF_DoctorSave.UseVisualStyleBackColor = false;
            // 
            // buttonAALF_DoctorDelete
            // 
            buttonAALF_DoctorDelete.BackColor = Color.Red;
            buttonAALF_DoctorDelete.BackgroundColor = Color.Red;
            buttonAALF_DoctorDelete.BorderColor = Color.Salmon;
            buttonAALF_DoctorDelete.BorderRadius = 10;
            buttonAALF_DoctorDelete.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorDelete.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorDelete.ForeColor = Color.White;
            buttonAALF_DoctorDelete.Location = new Point(193, 458);
            buttonAALF_DoctorDelete.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorDelete.Name = "buttonAALF_DoctorDelete";
            buttonAALF_DoctorDelete.Size = new Size(102, 36);
            buttonAALF_DoctorDelete.TabIndex = 71;
            buttonAALF_DoctorDelete.Text = "Delete";
            buttonAALF_DoctorDelete.TextColor = Color.White;
            buttonAALF_DoctorDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAALF_DoctorUpdate
            // 
            buttonAALF_DoctorUpdate.BackColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BackgroundColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BorderColor = Color.Salmon;
            buttonAALF_DoctorUpdate.BorderRadius = 10;
            buttonAALF_DoctorUpdate.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorUpdate.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorUpdate.ForeColor = Color.White;
            buttonAALF_DoctorUpdate.Location = new Point(301, 458);
            buttonAALF_DoctorUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorUpdate.Name = "buttonAALF_DoctorUpdate";
            buttonAALF_DoctorUpdate.Size = new Size(178, 36);
            buttonAALF_DoctorUpdate.TabIndex = 70;
            buttonAALF_DoctorUpdate.Text = "Update";
            buttonAALF_DoctorUpdate.TextColor = Color.White;
            buttonAALF_DoctorUpdate.UseVisualStyleBackColor = false;
            // 
            // labelAALF_Branch
            // 
            labelAALF_Branch.AutoSize = true;
            labelAALF_Branch.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Branch.Location = new Point(31, 345);
            labelAALF_Branch.Name = "labelAALF_Branch";
            labelAALF_Branch.Size = new Size(71, 25);
            labelAALF_Branch.TabIndex = 69;
            labelAALF_Branch.Text = "Branch";
            // 
            // labelAALF_phon
            // 
            labelAALF_phon.AutoSize = true;
            labelAALF_phon.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_phon.Location = new Point(29, 247);
            labelAALF_phon.Name = "labelAALF_phon";
            labelAALF_phon.Size = new Size(66, 25);
            labelAALF_phon.TabIndex = 68;
            labelAALF_phon.Text = "Phone";
            // 
            // labelAALF_ID
            // 
            labelAALF_ID.AutoSize = true;
            labelAALF_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_ID.Location = new Point(31, 197);
            labelAALF_ID.Name = "labelAALF_ID";
            labelAALF_ID.Size = new Size(157, 25);
            labelAALF_ID.TabIndex = 67;
            labelAALF_ID.Text = "Identification No";
            // 
            // labelAALF_Name
            // 
            labelAALF_Name.AutoSize = true;
            labelAALF_Name.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Name.Location = new Point(31, 99);
            labelAALF_Name.Name = "labelAALF_Name";
            labelAALF_Name.Size = new Size(64, 25);
            labelAALF_Name.TabIndex = 66;
            labelAALF_Name.Text = "Name";
            // 
            // rjTextBoxAALF_DoctorBranch
            // 
            rjTextBoxAALF_DoctorBranch.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorBranch.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorBranch.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorBranch.BorderRadius = 15;
            rjTextBoxAALF_DoctorBranch.BorderSize = 2;
            rjTextBoxAALF_DoctorBranch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorBranch.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorBranch.Location = new Point(193, 331);
            rjTextBoxAALF_DoctorBranch.Margin = new Padding(5);
            rjTextBoxAALF_DoctorBranch.Multiline = false;
            rjTextBoxAALF_DoctorBranch.Name = "rjTextBoxAALF_DoctorBranch";
            rjTextBoxAALF_DoctorBranch.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorBranch.PasswordChar = false;
            rjTextBoxAALF_DoctorBranch.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorBranch.PlaceholderText = "";
            rjTextBoxAALF_DoctorBranch.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorBranch.TabIndex = 65;
            rjTextBoxAALF_DoctorBranch.Texts = "";
            rjTextBoxAALF_DoctorBranch.UnderlinedStyle = false;
            // 
            // rjTextBoxAALF_DoctorPassword
            // 
            rjTextBoxAALF_DoctorPassword.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorPassword.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorPassword.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorPassword.BorderRadius = 15;
            rjTextBoxAALF_DoctorPassword.BorderSize = 2;
            rjTextBoxAALF_DoctorPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorPassword.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorPassword.Location = new Point(193, 282);
            rjTextBoxAALF_DoctorPassword.Margin = new Padding(5);
            rjTextBoxAALF_DoctorPassword.Multiline = false;
            rjTextBoxAALF_DoctorPassword.Name = "rjTextBoxAALF_DoctorPassword";
            rjTextBoxAALF_DoctorPassword.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorPassword.PasswordChar = false;
            rjTextBoxAALF_DoctorPassword.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorPassword.PlaceholderText = "";
            rjTextBoxAALF_DoctorPassword.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorPassword.TabIndex = 64;
            rjTextBoxAALF_DoctorPassword.Texts = "";
            rjTextBoxAALF_DoctorPassword.UnderlinedStyle = false;
            // 
            // rjTextBoxAALF_DoctorPhone
            // 
            rjTextBoxAALF_DoctorPhone.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorPhone.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorPhone.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorPhone.BorderRadius = 15;
            rjTextBoxAALF_DoctorPhone.BorderSize = 2;
            rjTextBoxAALF_DoctorPhone.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorPhone.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorPhone.Location = new Point(193, 233);
            rjTextBoxAALF_DoctorPhone.Margin = new Padding(5);
            rjTextBoxAALF_DoctorPhone.Multiline = false;
            rjTextBoxAALF_DoctorPhone.Name = "rjTextBoxAALF_DoctorPhone";
            rjTextBoxAALF_DoctorPhone.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorPhone.PasswordChar = false;
            rjTextBoxAALF_DoctorPhone.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorPhone.PlaceholderText = "";
            rjTextBoxAALF_DoctorPhone.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorPhone.TabIndex = 63;
            rjTextBoxAALF_DoctorPhone.Texts = "";
            rjTextBoxAALF_DoctorPhone.UnderlinedStyle = false;
            // 
            // rjTextBoxAALF_DoctorIDentification
            // 
            rjTextBoxAALF_DoctorIDentification.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorIDentification.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorIDentification.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorIDentification.BorderRadius = 15;
            rjTextBoxAALF_DoctorIDentification.BorderSize = 2;
            rjTextBoxAALF_DoctorIDentification.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorIDentification.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorIDentification.Location = new Point(193, 183);
            rjTextBoxAALF_DoctorIDentification.Margin = new Padding(5);
            rjTextBoxAALF_DoctorIDentification.Multiline = false;
            rjTextBoxAALF_DoctorIDentification.Name = "rjTextBoxAALF_DoctorIDentification";
            rjTextBoxAALF_DoctorIDentification.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorIDentification.PasswordChar = false;
            rjTextBoxAALF_DoctorIDentification.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorIDentification.PlaceholderText = "";
            rjTextBoxAALF_DoctorIDentification.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorIDentification.TabIndex = 62;
            rjTextBoxAALF_DoctorIDentification.Texts = "";
            rjTextBoxAALF_DoctorIDentification.UnderlinedStyle = false;
            // 
            // labelAALF_Pass
            // 
            labelAALF_Pass.AutoSize = true;
            labelAALF_Pass.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Pass.Location = new Point(31, 296);
            labelAALF_Pass.Name = "labelAALF_Pass";
            labelAALF_Pass.Size = new Size(92, 25);
            labelAALF_Pass.TabIndex = 61;
            labelAALF_Pass.Text = "Password";
            // 
            // rjTextBoxAALF_DoctorSurname
            // 
            rjTextBoxAALF_DoctorSurname.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorSurname.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorSurname.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorSurname.BorderRadius = 15;
            rjTextBoxAALF_DoctorSurname.BorderSize = 2;
            rjTextBoxAALF_DoctorSurname.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorSurname.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorSurname.Location = new Point(193, 134);
            rjTextBoxAALF_DoctorSurname.Margin = new Padding(5);
            rjTextBoxAALF_DoctorSurname.Multiline = false;
            rjTextBoxAALF_DoctorSurname.Name = "rjTextBoxAALF_DoctorSurname";
            rjTextBoxAALF_DoctorSurname.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorSurname.PasswordChar = false;
            rjTextBoxAALF_DoctorSurname.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorSurname.PlaceholderText = "";
            rjTextBoxAALF_DoctorSurname.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorSurname.TabIndex = 60;
            rjTextBoxAALF_DoctorSurname.Texts = "";
            rjTextBoxAALF_DoctorSurname.UnderlinedStyle = false;
            // 
            // labelAALF_Surnam
            // 
            labelAALF_Surnam.AutoSize = true;
            labelAALF_Surnam.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Surnam.Location = new Point(31, 148);
            labelAALF_Surnam.Name = "labelAALF_Surnam";
            labelAALF_Surnam.Size = new Size(88, 25);
            labelAALF_Surnam.TabIndex = 59;
            labelAALF_Surnam.Text = "Surname";
            // 
            // rjTextBoxAALF_DoctorName
            // 
            rjTextBoxAALF_DoctorName.BackColor = SystemColors.Window;
            rjTextBoxAALF_DoctorName.BorderColor = Color.Salmon;
            rjTextBoxAALF_DoctorName.BorderFocusColor = Color.HotPink;
            rjTextBoxAALF_DoctorName.BorderRadius = 15;
            rjTextBoxAALF_DoctorName.BorderSize = 2;
            rjTextBoxAALF_DoctorName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBoxAALF_DoctorName.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBoxAALF_DoctorName.Location = new Point(193, 85);
            rjTextBoxAALF_DoctorName.Margin = new Padding(5);
            rjTextBoxAALF_DoctorName.Multiline = false;
            rjTextBoxAALF_DoctorName.Name = "rjTextBoxAALF_DoctorName";
            rjTextBoxAALF_DoctorName.Padding = new Padding(11, 9, 11, 9);
            rjTextBoxAALF_DoctorName.PasswordChar = false;
            rjTextBoxAALF_DoctorName.PlaceholderColor = Color.DarkGray;
            rjTextBoxAALF_DoctorName.PlaceholderText = "";
            rjTextBoxAALF_DoctorName.Size = new Size(286, 39);
            rjTextBoxAALF_DoctorName.TabIndex = 58;
            rjTextBoxAALF_DoctorName.Texts = "";
            rjTextBoxAALF_DoctorName.UnderlinedStyle = false;
            // 
            // labelAALF_Doc
            // 
            labelAALF_Doc.AutoSize = true;
            labelAALF_Doc.Font = new Font("Yu Gothic UI Semibold", 13F);
            labelAALF_Doc.Location = new Point(31, 50);
            labelAALF_Doc.Name = "labelAALF_Doc";
            labelAALF_Doc.Size = new Size(81, 30);
            labelAALF_Doc.TabIndex = 57;
            labelAALF_Doc.Text = "Doctor";
            // 
            // dataGridViewAALF_Doctor
            // 
            dataGridViewAALF_Doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAALF_Doctor.Location = new Point(487, 85);
            dataGridViewAALF_Doctor.Name = "dataGridViewAALF_Doctor";
            dataGridViewAALF_Doctor.RowHeadersWidth = 51;
            dataGridViewAALF_Doctor.Size = new Size(487, 406);
            dataGridViewAALF_Doctor.TabIndex = 56;
            // 
            // AALF_DoctorEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 553);
            Controls.Add(buttonAALF_DoctorSave);
            Controls.Add(buttonAALF_DoctorDelete);
            Controls.Add(buttonAALF_DoctorUpdate);
            Controls.Add(labelAALF_Branch);
            Controls.Add(labelAALF_phon);
            Controls.Add(labelAALF_ID);
            Controls.Add(labelAALF_Name);
            Controls.Add(rjTextBoxAALF_DoctorBranch);
            Controls.Add(rjTextBoxAALF_DoctorPassword);
            Controls.Add(rjTextBoxAALF_DoctorPhone);
            Controls.Add(rjTextBoxAALF_DoctorIDentification);
            Controls.Add(labelAALF_Pass);
            Controls.Add(rjTextBoxAALF_DoctorSurname);
            Controls.Add(labelAALF_Surnam);
            Controls.Add(rjTextBoxAALF_DoctorName);
            Controls.Add(labelAALF_Doc);
            Controls.Add(dataGridViewAALF_Doctor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AALF_DoctorEdit";
            Text = "AALF_DoctorEdit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton buttonAALF_DoctorSave;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorDelete;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorUpdate;
        private Label labelAALF_Branch;
        private Label labelAALF_phon;
        private Label labelAALF_ID;
        private Label labelAALF_Name;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorBranch;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorPassword;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorPhone;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorIDentification;
        private Label labelAALF_Pass;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorSurname;
        private Label labelAALF_Surnam;
        private CustomTools.RJTextBox.RJTextBox rjTextBoxAALF_DoctorName;
        private Label labelAALF_Doc;
        private DataGridView dataGridViewAALF_Doctor;
    }
}