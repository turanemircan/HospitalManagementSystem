namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SALF_MadeAppointment
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
            TextboxSALF_PatientID = new CustomTools.RJTextBox.RJTextBox();
            TextboxSALF_PatientName = new CustomTools.RJTextBox.RJTextBox();
            LabelSALF_AvailableAppointments = new Label();
            LabelSALF_Time = new Label();
            LabelSALF_Policlinic = new Label();
            LabelSALF_Doctor = new Label();
            ButtonSALF_MakeAnAppointment = new CustomTools.RJButton.RJButton();
            LabelSALF_PatientId = new Label();
            LabelSALF_Name = new Label();
            LabelSALF_Surname = new Label();
            ButtonSALF_Show = new CustomTools.RJButton.RJButton();
            TextboxSALF_PatientSurname = new CustomTools.RJTextBox.RJTextBox();
            ComboBoxSALF_Doctor = new ComboBox();
            ComboBoxSALF_Policlinic = new ComboBox();
            DataGridSALF_Make = new DataGridView();
            checkedListBoxSALF_Time = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Make).BeginInit();
            SuspendLayout();
            // 
            // TextboxSALF_PatientID
            // 
            TextboxSALF_PatientID.BackColor = SystemColors.Window;
            TextboxSALF_PatientID.BorderColor = Color.Salmon;
            TextboxSALF_PatientID.BorderFocusColor = Color.HotPink;
            TextboxSALF_PatientID.BorderRadius = 15;
            TextboxSALF_PatientID.BorderSize = 2;
            TextboxSALF_PatientID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextboxSALF_PatientID.ForeColor = Color.FromArgb(64, 64, 64);
            TextboxSALF_PatientID.Location = new Point(177, 74);
            TextboxSALF_PatientID.Margin = new Padding(5);
            TextboxSALF_PatientID.Multiline = false;
            TextboxSALF_PatientID.Name = "TextboxSALF_PatientID";
            TextboxSALF_PatientID.Padding = new Padding(11, 9, 11, 9);
            TextboxSALF_PatientID.PasswordChar = false;
            TextboxSALF_PatientID.PlaceholderColor = Color.DarkGray;
            TextboxSALF_PatientID.PlaceholderText = "";
            TextboxSALF_PatientID.Size = new Size(192, 39);
            TextboxSALF_PatientID.TabIndex = 70;
            TextboxSALF_PatientID.Texts = "";
            TextboxSALF_PatientID.UnderlinedStyle = false;
            // 
            // TextboxSALF_PatientName
            // 
            TextboxSALF_PatientName.BackColor = SystemColors.Window;
            TextboxSALF_PatientName.BorderColor = Color.Salmon;
            TextboxSALF_PatientName.BorderFocusColor = Color.HotPink;
            TextboxSALF_PatientName.BorderRadius = 15;
            TextboxSALF_PatientName.BorderSize = 2;
            TextboxSALF_PatientName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextboxSALF_PatientName.ForeColor = Color.FromArgb(64, 64, 64);
            TextboxSALF_PatientName.Location = new Point(177, 123);
            TextboxSALF_PatientName.Margin = new Padding(5);
            TextboxSALF_PatientName.Multiline = false;
            TextboxSALF_PatientName.Name = "TextboxSALF_PatientName";
            TextboxSALF_PatientName.Padding = new Padding(11, 9, 11, 9);
            TextboxSALF_PatientName.PasswordChar = false;
            TextboxSALF_PatientName.PlaceholderColor = Color.DarkGray;
            TextboxSALF_PatientName.PlaceholderText = "";
            TextboxSALF_PatientName.Size = new Size(192, 39);
            TextboxSALF_PatientName.TabIndex = 69;
            TextboxSALF_PatientName.Texts = "";
            TextboxSALF_PatientName.UnderlinedStyle = false;
            // 
            // LabelSALF_AvailableAppointments
            // 
            LabelSALF_AvailableAppointments.AutoSize = true;
            LabelSALF_AvailableAppointments.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_AvailableAppointments.Location = new Point(434, 74);
            LabelSALF_AvailableAppointments.Name = "LabelSALF_AvailableAppointments";
            LabelSALF_AvailableAppointments.Size = new Size(218, 25);
            LabelSALF_AvailableAppointments.TabIndex = 68;
            LabelSALF_AvailableAppointments.Text = "Available Appointments";
            // 
            // LabelSALF_Time
            // 
            LabelSALF_Time.AutoSize = true;
            LabelSALF_Time.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_Time.Location = new Point(100, 295);
            LabelSALF_Time.Name = "LabelSALF_Time";
            LabelSALF_Time.Size = new Size(54, 25);
            LabelSALF_Time.TabIndex = 67;
            LabelSALF_Time.Text = "Time";
            // 
            // LabelSALF_Policlinic
            // 
            LabelSALF_Policlinic.AutoSize = true;
            LabelSALF_Policlinic.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_Policlinic.Location = new Point(66, 349);
            LabelSALF_Policlinic.Name = "LabelSALF_Policlinic";
            LabelSALF_Policlinic.Size = new Size(88, 25);
            LabelSALF_Policlinic.TabIndex = 66;
            LabelSALF_Policlinic.Text = "Policlinic";
            // 
            // LabelSALF_Doctor
            // 
            LabelSALF_Doctor.AutoSize = true;
            LabelSALF_Doctor.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_Doctor.Location = new Point(83, 412);
            LabelSALF_Doctor.Name = "LabelSALF_Doctor";
            LabelSALF_Doctor.Size = new Size(71, 25);
            LabelSALF_Doctor.TabIndex = 65;
            LabelSALF_Doctor.Text = "Doctor";
            // 
            // ButtonSALF_MakeAnAppointment
            // 
            ButtonSALF_MakeAnAppointment.BackColor = Color.SkyBlue;
            ButtonSALF_MakeAnAppointment.BackgroundColor = Color.SkyBlue;
            ButtonSALF_MakeAnAppointment.BorderColor = Color.Salmon;
            ButtonSALF_MakeAnAppointment.BorderRadius = 10;
            ButtonSALF_MakeAnAppointment.BorderSize = 0;
            ButtonSALF_MakeAnAppointment.FlatAppearance.BorderSize = 0;
            ButtonSALF_MakeAnAppointment.FlatStyle = FlatStyle.Flat;
            ButtonSALF_MakeAnAppointment.Font = new Font("Yu Gothic UI Semibold", 10F);
            ButtonSALF_MakeAnAppointment.ForeColor = Color.White;
            ButtonSALF_MakeAnAppointment.Location = new Point(434, 461);
            ButtonSALF_MakeAnAppointment.Margin = new Padding(3, 4, 3, 4);
            ButtonSALF_MakeAnAppointment.Name = "ButtonSALF_MakeAnAppointment";
            ButtonSALF_MakeAnAppointment.Size = new Size(224, 36);
            ButtonSALF_MakeAnAppointment.TabIndex = 64;
            ButtonSALF_MakeAnAppointment.Text = "Make An Appointment";
            ButtonSALF_MakeAnAppointment.TextColor = Color.White;
            ButtonSALF_MakeAnAppointment.UseVisualStyleBackColor = false;
            // 
            // LabelSALF_PatientId
            // 
            LabelSALF_PatientId.AutoSize = true;
            LabelSALF_PatientId.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_PatientId.Location = new Point(56, 81);
            LabelSALF_PatientId.Name = "LabelSALF_PatientId";
            LabelSALF_PatientId.Size = new Size(98, 25);
            LabelSALF_PatientId.TabIndex = 63;
            LabelSALF_PatientId.Text = "Patient ID";
            // 
            // LabelSALF_Name
            // 
            LabelSALF_Name.AutoSize = true;
            LabelSALF_Name.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_Name.Location = new Point(24, 130);
            LabelSALF_Name.Name = "LabelSALF_Name";
            LabelSALF_Name.Size = new Size(130, 25);
            LabelSALF_Name.TabIndex = 62;
            LabelSALF_Name.Text = "Patient Name";
            // 
            // LabelSALF_Surname
            // 
            LabelSALF_Surname.AutoSize = true;
            LabelSALF_Surname.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_Surname.Location = new Point(15, 179);
            LabelSALF_Surname.Name = "LabelSALF_Surname";
            LabelSALF_Surname.Size = new Size(154, 25);
            LabelSALF_Surname.TabIndex = 61;
            LabelSALF_Surname.Text = "Patient Surname";
            // 
            // ButtonSALF_Show
            // 
            ButtonSALF_Show.BackColor = Color.Salmon;
            ButtonSALF_Show.BackgroundColor = Color.Salmon;
            ButtonSALF_Show.BorderColor = Color.Salmon;
            ButtonSALF_Show.BorderRadius = 15;
            ButtonSALF_Show.BorderSize = 0;
            ButtonSALF_Show.FlatAppearance.BorderSize = 0;
            ButtonSALF_Show.FlatStyle = FlatStyle.Flat;
            ButtonSALF_Show.Font = new Font("Yu Gothic UI Semibold", 10F);
            ButtonSALF_Show.ForeColor = Color.White;
            ButtonSALF_Show.Location = new Point(205, 477);
            ButtonSALF_Show.Margin = new Padding(3, 4, 3, 4);
            ButtonSALF_Show.Name = "ButtonSALF_Show";
            ButtonSALF_Show.Size = new Size(90, 43);
            ButtonSALF_Show.TabIndex = 60;
            ButtonSALF_Show.Text = "Show";
            ButtonSALF_Show.TextColor = Color.White;
            ButtonSALF_Show.UseVisualStyleBackColor = false;
            // 
            // TextboxSALF_PatientSurname
            // 
            TextboxSALF_PatientSurname.BackColor = SystemColors.Window;
            TextboxSALF_PatientSurname.BorderColor = Color.Salmon;
            TextboxSALF_PatientSurname.BorderFocusColor = Color.HotPink;
            TextboxSALF_PatientSurname.BorderRadius = 15;
            TextboxSALF_PatientSurname.BorderSize = 2;
            TextboxSALF_PatientSurname.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextboxSALF_PatientSurname.ForeColor = Color.FromArgb(64, 64, 64);
            TextboxSALF_PatientSurname.Location = new Point(177, 172);
            TextboxSALF_PatientSurname.Margin = new Padding(5);
            TextboxSALF_PatientSurname.Multiline = false;
            TextboxSALF_PatientSurname.Name = "TextboxSALF_PatientSurname";
            TextboxSALF_PatientSurname.Padding = new Padding(11, 9, 11, 9);
            TextboxSALF_PatientSurname.PasswordChar = false;
            TextboxSALF_PatientSurname.PlaceholderColor = Color.DarkGray;
            TextboxSALF_PatientSurname.PlaceholderText = "";
            TextboxSALF_PatientSurname.Size = new Size(192, 39);
            TextboxSALF_PatientSurname.TabIndex = 59;
            TextboxSALF_PatientSurname.Texts = "";
            TextboxSALF_PatientSurname.UnderlinedStyle = false;
            // 
            // ComboBoxSALF_Doctor
            // 
            ComboBoxSALF_Doctor.FormattingEnabled = true;
            ComboBoxSALF_Doctor.Location = new Point(172, 410);
            ComboBoxSALF_Doctor.Name = "ComboBoxSALF_Doctor";
            ComboBoxSALF_Doctor.Size = new Size(197, 28);
            ComboBoxSALF_Doctor.TabIndex = 58;
            // 
            // ComboBoxSALF_Policlinic
            // 
            ComboBoxSALF_Policlinic.FormattingEnabled = true;
            ComboBoxSALF_Policlinic.Location = new Point(172, 347);
            ComboBoxSALF_Policlinic.Name = "ComboBoxSALF_Policlinic";
            ComboBoxSALF_Policlinic.Size = new Size(197, 28);
            ComboBoxSALF_Policlinic.TabIndex = 57;
            // 
            // DataGridSALF_Make
            // 
            DataGridSALF_Make.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridSALF_Make.Location = new Point(434, 123);
            DataGridSALF_Make.Name = "DataGridSALF_Make";
            DataGridSALF_Make.RowHeadersWidth = 51;
            DataGridSALF_Make.Size = new Size(457, 303);
            DataGridSALF_Make.TabIndex = 55;
            // 
            // checkedListBoxSALF_Time
            // 
            checkedListBoxSALF_Time.FormattingEnabled = true;
            checkedListBoxSALF_Time.Items.AddRange(new object[] { "06:00", "06:15", "06:30", "06:45", "07:00" });
            checkedListBoxSALF_Time.Location = new Point(172, 294);
            checkedListBoxSALF_Time.Name = "checkedListBoxSALF_Time";
            checkedListBoxSALF_Time.Size = new Size(197, 26);
            checkedListBoxSALF_Time.TabIndex = 71;
            checkedListBoxSALF_Time.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // SALF_MadeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 555);
            Controls.Add(checkedListBoxSALF_Time);
            Controls.Add(TextboxSALF_PatientID);
            Controls.Add(TextboxSALF_PatientName);
            Controls.Add(LabelSALF_AvailableAppointments);
            Controls.Add(LabelSALF_Time);
            Controls.Add(LabelSALF_Policlinic);
            Controls.Add(LabelSALF_Doctor);
            Controls.Add(ButtonSALF_MakeAnAppointment);
            Controls.Add(LabelSALF_PatientId);
            Controls.Add(LabelSALF_Name);
            Controls.Add(LabelSALF_Surname);
            Controls.Add(ButtonSALF_Show);
            Controls.Add(TextboxSALF_PatientSurname);
            Controls.Add(ComboBoxSALF_Doctor);
            Controls.Add(ComboBoxSALF_Policlinic);
            Controls.Add(DataGridSALF_Make);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALF_MadeAppointment";
            Text = "SALF_MadeAppointment";
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Make).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJTextBox.RJTextBox TextboxSALF_PatientID;
        private CustomTools.RJTextBox.RJTextBox TextboxSALF_PatientName;
        private Label LabelSALF_AvailableAppointments;
        private Label LabelSALF_Time;
        private Label LabelSALF_Policlinic;
        private Label LabelSALF_Doctor;
        private CustomTools.RJButton.RJButton ButtonSALF_MakeAnAppointment;
        private Label LabelSALF_PatientId;
        private Label LabelSALF_Name;
        private Label LabelSALF_Surname;
        private CustomTools.RJButton.RJButton ButtonSALF_Show;
        private CustomTools.RJTextBox.RJTextBox TextboxSALF_PatientSurname;
        private ComboBox ComboBoxSALF_Doctor;
        private ComboBox ComboBoxSALF_Policlinic;
        private DataGridView DataGridSALF_Make;
        private CheckedListBox checkedListBoxSALF_Time;
    }
}