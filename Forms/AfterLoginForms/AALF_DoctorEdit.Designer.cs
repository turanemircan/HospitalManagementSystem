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
            labelAALF_Doc = new Label();
            dataGridViewAALF_Doctor = new DataGridView();
            tabControlAALF_Doctor = new TabControl();
            tabPageAALF_DoctorEdit = new TabPage();
            textboxAALF_DoctorBranch = new TextBox();
            textboxAALF_DoctorPassword = new TextBox();
            textboxAALF_DoctorPhone = new TextBox();
            textboxAALF_DoctorSurname = new TextBox();
            textboxAALF_DoctorName = new TextBox();
            textboxAALF_DoctorId = new TextBox();
            buttonAALF_DoctorSave = new CustomTools.RJButton.RJButton();
            buttonAALF_DoctorDelete = new CustomTools.RJButton.RJButton();
            labelAALF_Branch = new Label();
            labelAALF_phon = new Label();
            labelAALF_ID = new Label();
            labelAALF_Name = new Label();
            labelAALF_Pass = new Label();
            labelAALF_Surnam = new Label();
            tabPageAALF_DoktorUpdate = new TabPage();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            rjButton2 = new CustomTools.RJButton.RJButton();
            rjButton3 = new CustomTools.RJButton.RJButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            rjButton1 = new CustomTools.RJButton.RJButton();
            rjButton4 = new CustomTools.RJButton.RJButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).BeginInit();
            tabControlAALF_Doctor.SuspendLayout();
            tabPageAALF_DoctorEdit.SuspendLayout();
            tabPageAALF_DoktorUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // labelAALF_Doc
            // 
            labelAALF_Doc.AutoSize = true;
            labelAALF_Doc.Font = new Font("Yu Gothic UI Semibold", 13F);
            labelAALF_Doc.Location = new Point(31, 32);
            labelAALF_Doc.Name = "labelAALF_Doc";
            labelAALF_Doc.Size = new Size(81, 30);
            labelAALF_Doc.TabIndex = 57;
            labelAALF_Doc.Text = "Doctor";
            // 
            // dataGridViewAALF_Doctor
            // 
            dataGridViewAALF_Doctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAALF_Doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAALF_Doctor.Location = new Point(487, 94);
            dataGridViewAALF_Doctor.Name = "dataGridViewAALF_Doctor";
            dataGridViewAALF_Doctor.RowHeadersWidth = 51;
            dataGridViewAALF_Doctor.Size = new Size(935, 417);
            dataGridViewAALF_Doctor.TabIndex = 56;
            dataGridViewAALF_Doctor.CellClick += dataGridViewAALF_Doctor_CellClick;
            dataGridViewAALF_Doctor.CellEndEdit += dataGridViewAALF_Doctor_CellEndEdit;
            dataGridViewAALF_Doctor.CellFormatting += dataGridViewAALF_Doctor_CellFormatting;
            // 
            // tabControlAALF_Doctor
            // 
            tabControlAALF_Doctor.Controls.Add(tabPageAALF_DoctorEdit);
            tabControlAALF_Doctor.Controls.Add(tabPageAALF_DoktorUpdate);
            tabControlAALF_Doctor.Location = new Point(31, 65);
            tabControlAALF_Doctor.Name = "tabControlAALF_Doctor";
            tabControlAALF_Doctor.SelectedIndex = 0;
            tabControlAALF_Doctor.Size = new Size(450, 446);
            tabControlAALF_Doctor.TabIndex = 81;
            // 
            // tabPageAALF_DoctorEdit
            // 
            tabPageAALF_DoctorEdit.Controls.Add(rjButton4);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorBranch);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorPassword);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorPhone);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorSurname);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorName);
            tabPageAALF_DoctorEdit.Controls.Add(textboxAALF_DoctorId);
            tabPageAALF_DoctorEdit.Controls.Add(buttonAALF_DoctorSave);
            tabPageAALF_DoctorEdit.Controls.Add(buttonAALF_DoctorDelete);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_Branch);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_phon);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_ID);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_Name);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_Pass);
            tabPageAALF_DoctorEdit.Controls.Add(labelAALF_Surnam);
            tabPageAALF_DoctorEdit.Location = new Point(4, 29);
            tabPageAALF_DoctorEdit.Name = "tabPageAALF_DoctorEdit";
            tabPageAALF_DoctorEdit.Padding = new Padding(3);
            tabPageAALF_DoctorEdit.Size = new Size(442, 413);
            tabPageAALF_DoctorEdit.TabIndex = 0;
            tabPageAALF_DoctorEdit.Text = "Doctor Edit";
            tabPageAALF_DoctorEdit.UseVisualStyleBackColor = true;
            // 
            // textboxAALF_DoctorBranch
            // 
            textboxAALF_DoctorBranch.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorBranch.Location = new Point(168, 256);
            textboxAALF_DoctorBranch.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorBranch.Name = "textboxAALF_DoctorBranch";
            textboxAALF_DoctorBranch.PlaceholderText = "Branch";
            textboxAALF_DoctorBranch.Size = new Size(260, 29);
            textboxAALF_DoctorBranch.TabIndex = 95;
            // 
            // textboxAALF_DoctorPassword
            // 
            textboxAALF_DoctorPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorPassword.Location = new Point(169, 207);
            textboxAALF_DoctorPassword.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorPassword.Name = "textboxAALF_DoctorPassword";
            textboxAALF_DoctorPassword.PlaceholderText = "Password";
            textboxAALF_DoctorPassword.Size = new Size(260, 29);
            textboxAALF_DoctorPassword.TabIndex = 94;
            // 
            // textboxAALF_DoctorPhone
            // 
            textboxAALF_DoctorPhone.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorPhone.Location = new Point(168, 158);
            textboxAALF_DoctorPhone.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorPhone.Name = "textboxAALF_DoctorPhone";
            textboxAALF_DoctorPhone.PlaceholderText = "Phone Number";
            textboxAALF_DoctorPhone.Size = new Size(260, 29);
            textboxAALF_DoctorPhone.TabIndex = 93;
            // 
            // textboxAALF_DoctorSurname
            // 
            textboxAALF_DoctorSurname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorSurname.Location = new Point(168, 55);
            textboxAALF_DoctorSurname.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorSurname.Name = "textboxAALF_DoctorSurname";
            textboxAALF_DoctorSurname.PlaceholderText = "Surname";
            textboxAALF_DoctorSurname.Size = new Size(260, 29);
            textboxAALF_DoctorSurname.TabIndex = 92;
            // 
            // textboxAALF_DoctorName
            // 
            textboxAALF_DoctorName.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorName.Location = new Point(168, 10);
            textboxAALF_DoctorName.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorName.Name = "textboxAALF_DoctorName";
            textboxAALF_DoctorName.PlaceholderText = "Name";
            textboxAALF_DoctorName.Size = new Size(260, 29);
            textboxAALF_DoctorName.TabIndex = 91;
            // 
            // textboxAALF_DoctorId
            // 
            textboxAALF_DoctorId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorId.Location = new Point(169, 108);
            textboxAALF_DoctorId.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_DoctorId.Name = "textboxAALF_DoctorId";
            textboxAALF_DoctorId.PlaceholderText = "ID";
            textboxAALF_DoctorId.Size = new Size(260, 29);
            textboxAALF_DoctorId.TabIndex = 90;
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
            buttonAALF_DoctorSave.Location = new Point(168, 305);
            buttonAALF_DoctorSave.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorSave.Name = "buttonAALF_DoctorSave";
            buttonAALF_DoctorSave.Size = new Size(260, 43);
            buttonAALF_DoctorSave.TabIndex = 89;
            buttonAALF_DoctorSave.Text = "Save";
            buttonAALF_DoctorSave.TextColor = Color.White;
            buttonAALF_DoctorSave.UseVisualStyleBackColor = false;
            // 
            // buttonAALF_DoctorDelete
            // 
            buttonAALF_DoctorDelete.BackColor = Color.Red;
            buttonAALF_DoctorDelete.BackgroundColor = Color.Red;
            buttonAALF_DoctorDelete.BorderColor = Color.Salmon;
            buttonAALF_DoctorDelete.BorderRadius = 15;
            buttonAALF_DoctorDelete.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorDelete.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorDelete.ForeColor = Color.White;
            buttonAALF_DoctorDelete.Location = new Point(168, 353);
            buttonAALF_DoctorDelete.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorDelete.Name = "buttonAALF_DoctorDelete";
            buttonAALF_DoctorDelete.Size = new Size(261, 36);
            buttonAALF_DoctorDelete.TabIndex = 88;
            buttonAALF_DoctorDelete.Text = "Delete";
            buttonAALF_DoctorDelete.TextColor = Color.White;
            buttonAALF_DoctorDelete.UseVisualStyleBackColor = false;
            // 
            // labelAALF_Branch
            // 
            labelAALF_Branch.AutoSize = true;
            labelAALF_Branch.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Branch.Location = new Point(6, 258);
            labelAALF_Branch.Name = "labelAALF_Branch";
            labelAALF_Branch.Size = new Size(71, 25);
            labelAALF_Branch.TabIndex = 86;
            labelAALF_Branch.Text = "Branch";
            // 
            // labelAALF_phon
            // 
            labelAALF_phon.AutoSize = true;
            labelAALF_phon.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_phon.Location = new Point(4, 160);
            labelAALF_phon.Name = "labelAALF_phon";
            labelAALF_phon.Size = new Size(66, 25);
            labelAALF_phon.TabIndex = 85;
            labelAALF_phon.Text = "Phone";
            // 
            // labelAALF_ID
            // 
            labelAALF_ID.AutoSize = true;
            labelAALF_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_ID.Location = new Point(6, 110);
            labelAALF_ID.Name = "labelAALF_ID";
            labelAALF_ID.Size = new Size(157, 25);
            labelAALF_ID.TabIndex = 84;
            labelAALF_ID.Text = "Identification No";
            // 
            // labelAALF_Name
            // 
            labelAALF_Name.AutoSize = true;
            labelAALF_Name.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Name.Location = new Point(6, 12);
            labelAALF_Name.Name = "labelAALF_Name";
            labelAALF_Name.Size = new Size(64, 25);
            labelAALF_Name.TabIndex = 83;
            labelAALF_Name.Text = "Name";
            // 
            // labelAALF_Pass
            // 
            labelAALF_Pass.AutoSize = true;
            labelAALF_Pass.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Pass.Location = new Point(6, 210);
            labelAALF_Pass.Name = "labelAALF_Pass";
            labelAALF_Pass.Size = new Size(92, 25);
            labelAALF_Pass.TabIndex = 82;
            labelAALF_Pass.Text = "Password";
            // 
            // labelAALF_Surnam
            // 
            labelAALF_Surnam.AutoSize = true;
            labelAALF_Surnam.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Surnam.Location = new Point(6, 58);
            labelAALF_Surnam.Name = "labelAALF_Surnam";
            labelAALF_Surnam.Size = new Size(88, 25);
            labelAALF_Surnam.TabIndex = 81;
            labelAALF_Surnam.Text = "Surname";
            // 
            // tabPageAALF_DoktorUpdate
            // 
            tabPageAALF_DoktorUpdate.Controls.Add(rjButton1);
            tabPageAALF_DoktorUpdate.Controls.Add(textBox1);
            tabPageAALF_DoktorUpdate.Controls.Add(textBox3);
            tabPageAALF_DoktorUpdate.Controls.Add(textBox4);
            tabPageAALF_DoktorUpdate.Controls.Add(textBox5);
            tabPageAALF_DoktorUpdate.Controls.Add(textBox6);
            tabPageAALF_DoktorUpdate.Controls.Add(rjButton2);
            tabPageAALF_DoktorUpdate.Controls.Add(rjButton3);
            tabPageAALF_DoktorUpdate.Controls.Add(label1);
            tabPageAALF_DoktorUpdate.Controls.Add(label2);
            tabPageAALF_DoktorUpdate.Controls.Add(label3);
            tabPageAALF_DoktorUpdate.Controls.Add(label4);
            tabPageAALF_DoktorUpdate.Controls.Add(label6);
            tabPageAALF_DoktorUpdate.Location = new Point(4, 29);
            tabPageAALF_DoktorUpdate.Name = "tabPageAALF_DoktorUpdate";
            tabPageAALF_DoktorUpdate.Padding = new Padding(3);
            tabPageAALF_DoktorUpdate.Size = new Size(442, 413);
            tabPageAALF_DoktorUpdate.TabIndex = 1;
            tabPageAALF_DoktorUpdate.Text = "Doktor Update";
            tabPageAALF_DoktorUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBox1.Location = new Point(168, 211);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Branch";
            textBox1.Size = new Size(260, 29);
            textBox1.TabIndex = 110;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBox3.Location = new Point(168, 158);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Phone Number";
            textBox3.Size = new Size(260, 29);
            textBox3.TabIndex = 108;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBox4.Location = new Point(168, 55);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Surname";
            textBox4.Size = new Size(260, 29);
            textBox4.TabIndex = 107;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBox5.Location = new Point(168, 10);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Name";
            textBox5.Size = new Size(260, 29);
            textBox5.TabIndex = 106;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBox6.Location = new Point(169, 108);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "ID";
            textBox6.Size = new Size(260, 29);
            textBox6.TabIndex = 105;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Red;
            rjButton2.BackgroundColor = Color.Red;
            rjButton2.BorderColor = Color.Salmon;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(168, 310);
            rjButton2.Margin = new Padding(3, 4, 3, 4);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(261, 36);
            rjButton2.TabIndex = 103;
            rjButton2.Text = "Delete";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.SkyBlue;
            rjButton3.BackgroundColor = Color.SkyBlue;
            rjButton3.BorderColor = Color.Salmon;
            rjButton3.BorderRadius = 15;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(169, 262);
            rjButton3.Margin = new Padding(3, 4, 3, 4);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(259, 43);
            rjButton3.TabIndex = 102;
            rjButton3.Text = "Update";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(6, 211);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 101;
            label1.Text = "Branch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(4, 160);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 100;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11F);
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 99;
            label3.Text = "Identification No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 11F);
            label4.Location = new Point(6, 12);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 98;
            label4.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Semibold", 11F);
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 96;
            label6.Text = "Surname";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.RosyBrown;
            rjButton1.BackgroundColor = Color.RosyBrown;
            rjButton1.BorderColor = Color.Salmon;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(10, 265);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(153, 36);
            rjButton1.TabIndex = 111;
            rjButton1.Text = "Clear";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.RosyBrown;
            rjButton4.BackgroundColor = Color.RosyBrown;
            rjButton4.BorderColor = Color.Salmon;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(9, 308);
            rjButton4.Margin = new Padding(3, 4, 3, 4);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(153, 36);
            rjButton4.TabIndex = 96;
            rjButton4.Text = "Clear";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // AALF_DoctorEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1448, 553);
            Controls.Add(tabControlAALF_Doctor);
            Controls.Add(labelAALF_Doc);
            Controls.Add(dataGridViewAALF_Doctor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AALF_DoctorEdit";
            Text = "AALF_DoctorEdit";
            Load += AALF_DoctorEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).EndInit();
            tabControlAALF_Doctor.ResumeLayout(false);
            tabPageAALF_DoctorEdit.ResumeLayout(false);
            tabPageAALF_DoctorEdit.PerformLayout();
            tabPageAALF_DoktorUpdate.ResumeLayout(false);
            tabPageAALF_DoktorUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAALF_Doc;
        private DataGridView dataGridViewAALF_Doctor;
        private TabControl tabControlAALF_Doctor;
        private TabPage tabPageAALF_DoctorEdit;
        private TabPage tabPageAALF_DoktorUpdate;
        private TextBox textboxAALF_DoctorBranch;
        private TextBox textboxAALF_DoctorPassword;
        private TextBox textboxAALF_DoctorPhone;
        private TextBox textboxAALF_DoctorSurname;
        private TextBox textboxAALF_DoctorName;
        private TextBox textboxAALF_DoctorId;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorSave;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorDelete;
        private Label labelAALF_Branch;
        private Label labelAALF_phon;
        private Label labelAALF_ID;
        private Label labelAALF_Name;
        private Label labelAALF_Pass;
        private Label labelAALF_Surnam;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private CustomTools.RJButton.RJButton rjButton2;
        private CustomTools.RJButton.RJButton rjButton3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private CustomTools.RJButton.RJButton rjButton4;
        private CustomTools.RJButton.RJButton rjButton1;
    }
}