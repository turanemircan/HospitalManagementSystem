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
            SALF_PatientNameTextbox = new CustomTools.RJTextBox.RJTextBox();
            SALF_AvailableAppointments = new Label();
            SALF_DateLabel = new Label();
            SALF_PoliclinicLabel = new Label();
            SALF_DoctorLabel = new Label();
            SALF_MakeAnAppointment = new CustomTools.RJButton.RJButton();
            SALF_PatientIdLabel = new Label();
            SALF_NameLabel = new Label();
            SALF_SurnameLabel = new Label();
            SALF_ShowButton = new CustomTools.RJButton.RJButton();
            SALF_PatientSurnameTextbox = new CustomTools.RJTextBox.RJTextBox();
            SALF_DoctorCombo = new ComboBox();
            SALF_PoliclinicCombo = new ComboBox();
            SALF_DateTime = new DateTimePicker();
            SALF_MakeDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SALF_MakeDataGrid).BeginInit();
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
            TextboxSALF_PatientID.Location = new Point(172, 120);
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
            // SALF_PatientNameTextbox
            // 
            SALF_PatientNameTextbox.BackColor = SystemColors.Window;
            SALF_PatientNameTextbox.BorderColor = Color.Salmon;
            SALF_PatientNameTextbox.BorderFocusColor = Color.HotPink;
            SALF_PatientNameTextbox.BorderRadius = 15;
            SALF_PatientNameTextbox.BorderSize = 2;
            SALF_PatientNameTextbox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SALF_PatientNameTextbox.ForeColor = Color.FromArgb(64, 64, 64);
            SALF_PatientNameTextbox.Location = new Point(172, 206);
            SALF_PatientNameTextbox.Margin = new Padding(5);
            SALF_PatientNameTextbox.Multiline = false;
            SALF_PatientNameTextbox.Name = "SALF_PatientNameTextbox";
            SALF_PatientNameTextbox.Padding = new Padding(11, 9, 11, 9);
            SALF_PatientNameTextbox.PasswordChar = false;
            SALF_PatientNameTextbox.PlaceholderColor = Color.DarkGray;
            SALF_PatientNameTextbox.PlaceholderText = "";
            SALF_PatientNameTextbox.Size = new Size(192, 39);
            SALF_PatientNameTextbox.TabIndex = 69;
            SALF_PatientNameTextbox.Texts = "";
            SALF_PatientNameTextbox.UnderlinedStyle = false;
            // 
            // SALF_AvailableAppointments
            // 
            SALF_AvailableAppointments.AutoSize = true;
            SALF_AvailableAppointments.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_AvailableAppointments.Location = new Point(774, 74);
            SALF_AvailableAppointments.Name = "SALF_AvailableAppointments";
            SALF_AvailableAppointments.Size = new Size(218, 25);
            SALF_AvailableAppointments.TabIndex = 68;
            SALF_AvailableAppointments.Text = "Available Appointments";
            // 
            // SALF_DateLabel
            // 
            SALF_DateLabel.AutoSize = true;
            SALF_DateLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_DateLabel.Location = new Point(385, 131);
            SALF_DateLabel.Name = "SALF_DateLabel";
            SALF_DateLabel.Size = new Size(53, 25);
            SALF_DateLabel.TabIndex = 67;
            SALF_DateLabel.Text = "Date";
            // 
            // SALF_PoliclinicLabel
            // 
            SALF_PoliclinicLabel.AutoSize = true;
            SALF_PoliclinicLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_PoliclinicLabel.Location = new Point(385, 194);
            SALF_PoliclinicLabel.Name = "SALF_PoliclinicLabel";
            SALF_PoliclinicLabel.Size = new Size(88, 25);
            SALF_PoliclinicLabel.TabIndex = 66;
            SALF_PoliclinicLabel.Text = "Policlinic";
            // 
            // SALF_DoctorLabel
            // 
            SALF_DoctorLabel.AutoSize = true;
            SALF_DoctorLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_DoctorLabel.Location = new Point(385, 267);
            SALF_DoctorLabel.Name = "SALF_DoctorLabel";
            SALF_DoctorLabel.Size = new Size(71, 25);
            SALF_DoctorLabel.TabIndex = 65;
            SALF_DoctorLabel.Text = "Doctor";
            // 
            // SALF_MakeAnAppointment
            // 
            SALF_MakeAnAppointment.BackColor = Color.SkyBlue;
            SALF_MakeAnAppointment.BackgroundColor = Color.SkyBlue;
            SALF_MakeAnAppointment.BorderColor = Color.Salmon;
            SALF_MakeAnAppointment.BorderRadius = 10;
            SALF_MakeAnAppointment.BorderSize = 0;
            SALF_MakeAnAppointment.FlatAppearance.BorderSize = 0;
            SALF_MakeAnAppointment.FlatStyle = FlatStyle.Flat;
            SALF_MakeAnAppointment.Font = new Font("Yu Gothic UI Semibold", 10F);
            SALF_MakeAnAppointment.ForeColor = Color.White;
            SALF_MakeAnAppointment.Location = new Point(774, 447);
            SALF_MakeAnAppointment.Margin = new Padding(3, 4, 3, 4);
            SALF_MakeAnAppointment.Name = "SALF_MakeAnAppointment";
            SALF_MakeAnAppointment.Size = new Size(224, 36);
            SALF_MakeAnAppointment.TabIndex = 64;
            SALF_MakeAnAppointment.Text = "Make An Appointment";
            SALF_MakeAnAppointment.TextColor = Color.White;
            SALF_MakeAnAppointment.UseVisualStyleBackColor = false;
            // 
            // SALF_PatientIdLabel
            // 
            SALF_PatientIdLabel.AutoSize = true;
            SALF_PatientIdLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_PatientIdLabel.Location = new Point(42, 127);
            SALF_PatientIdLabel.Name = "SALF_PatientIdLabel";
            SALF_PatientIdLabel.Size = new Size(98, 25);
            SALF_PatientIdLabel.TabIndex = 63;
            SALF_PatientIdLabel.Text = "Patient ID";
            // 
            // SALF_NameLabel
            // 
            SALF_NameLabel.AutoSize = true;
            SALF_NameLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_NameLabel.Location = new Point(34, 206);
            SALF_NameLabel.Name = "SALF_NameLabel";
            SALF_NameLabel.Size = new Size(130, 25);
            SALF_NameLabel.TabIndex = 62;
            SALF_NameLabel.Text = "Patient Name";
            // 
            // SALF_SurnameLabel
            // 
            SALF_SurnameLabel.AutoSize = true;
            SALF_SurnameLabel.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_SurnameLabel.Location = new Point(10, 288);
            SALF_SurnameLabel.Name = "SALF_SurnameLabel";
            SALF_SurnameLabel.Size = new Size(154, 25);
            SALF_SurnameLabel.TabIndex = 61;
            SALF_SurnameLabel.Text = "Patient Surname";
            // 
            // SALF_ShowButton
            // 
            SALF_ShowButton.BackColor = Color.Salmon;
            SALF_ShowButton.BackgroundColor = Color.Salmon;
            SALF_ShowButton.BorderColor = Color.Salmon;
            SALF_ShowButton.BorderRadius = 15;
            SALF_ShowButton.BorderSize = 0;
            SALF_ShowButton.FlatAppearance.BorderSize = 0;
            SALF_ShowButton.FlatStyle = FlatStyle.Flat;
            SALF_ShowButton.Font = new Font("Yu Gothic UI Semibold", 10F);
            SALF_ShowButton.ForeColor = Color.White;
            SALF_ShowButton.Location = new Point(545, 324);
            SALF_ShowButton.Margin = new Padding(3, 4, 3, 4);
            SALF_ShowButton.Name = "SALF_ShowButton";
            SALF_ShowButton.Size = new Size(90, 43);
            SALF_ShowButton.TabIndex = 60;
            SALF_ShowButton.Text = "Show";
            SALF_ShowButton.TextColor = Color.White;
            SALF_ShowButton.UseVisualStyleBackColor = false;
            // 
            // SALF_PatientSurnameTextbox
            // 
            SALF_PatientSurnameTextbox.BackColor = SystemColors.Window;
            SALF_PatientSurnameTextbox.BorderColor = Color.Salmon;
            SALF_PatientSurnameTextbox.BorderFocusColor = Color.HotPink;
            SALF_PatientSurnameTextbox.BorderRadius = 15;
            SALF_PatientSurnameTextbox.BorderSize = 2;
            SALF_PatientSurnameTextbox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SALF_PatientSurnameTextbox.ForeColor = Color.FromArgb(64, 64, 64);
            SALF_PatientSurnameTextbox.Location = new Point(172, 288);
            SALF_PatientSurnameTextbox.Margin = new Padding(5);
            SALF_PatientSurnameTextbox.Multiline = false;
            SALF_PatientSurnameTextbox.Name = "SALF_PatientSurnameTextbox";
            SALF_PatientSurnameTextbox.Padding = new Padding(11, 9, 11, 9);
            SALF_PatientSurnameTextbox.PasswordChar = false;
            SALF_PatientSurnameTextbox.PlaceholderColor = Color.DarkGray;
            SALF_PatientSurnameTextbox.PlaceholderText = "";
            SALF_PatientSurnameTextbox.Size = new Size(192, 39);
            SALF_PatientSurnameTextbox.TabIndex = 59;
            SALF_PatientSurnameTextbox.Texts = "";
            SALF_PatientSurnameTextbox.UnderlinedStyle = false;
            // 
            // SALF_DoctorCombo
            // 
            SALF_DoctorCombo.FormattingEnabled = true;
            SALF_DoctorCombo.Location = new Point(492, 267);
            SALF_DoctorCombo.Name = "SALF_DoctorCombo";
            SALF_DoctorCombo.Size = new Size(197, 28);
            SALF_DoctorCombo.TabIndex = 58;
            // 
            // SALF_PoliclinicCombo
            // 
            SALF_PoliclinicCombo.FormattingEnabled = true;
            SALF_PoliclinicCombo.Location = new Point(492, 194);
            SALF_PoliclinicCombo.Name = "SALF_PoliclinicCombo";
            SALF_PoliclinicCombo.Size = new Size(197, 28);
            SALF_PoliclinicCombo.TabIndex = 57;
            // 
            // SALF_DateTime
            // 
            SALF_DateTime.Location = new Point(492, 131);
            SALF_DateTime.Name = "SALF_DateTime";
            SALF_DateTime.Size = new Size(197, 27);
            SALF_DateTime.TabIndex = 56;
            // 
            // SALF_MakeDataGrid
            // 
            SALF_MakeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SALF_MakeDataGrid.Location = new Point(774, 127);
            SALF_MakeDataGrid.Name = "SALF_MakeDataGrid";
            SALF_MakeDataGrid.RowHeadersWidth = 51;
            SALF_MakeDataGrid.Size = new Size(457, 303);
            SALF_MakeDataGrid.TabIndex = 55;
            // 
            // SALF_MadeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 555);
            Controls.Add(TextboxSALF_PatientID);
            Controls.Add(SALF_PatientNameTextbox);
            Controls.Add(SALF_AvailableAppointments);
            Controls.Add(SALF_DateLabel);
            Controls.Add(SALF_PoliclinicLabel);
            Controls.Add(SALF_DoctorLabel);
            Controls.Add(SALF_MakeAnAppointment);
            Controls.Add(SALF_PatientIdLabel);
            Controls.Add(SALF_NameLabel);
            Controls.Add(SALF_SurnameLabel);
            Controls.Add(SALF_ShowButton);
            Controls.Add(SALF_PatientSurnameTextbox);
            Controls.Add(SALF_DoctorCombo);
            Controls.Add(SALF_PoliclinicCombo);
            Controls.Add(SALF_DateTime);
            Controls.Add(SALF_MakeDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALF_MadeAppointment";
            Text = "SALF_MadeAppointment";
            ((System.ComponentModel.ISupportInitialize)SALF_MakeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJTextBox.RJTextBox TextboxSALF_PatientID;
        private CustomTools.RJTextBox.RJTextBox SALF_PatientNameTextbox;
        private Label SALF_AvailableAppointments;
        private Label SALF_DateLabel;
        private Label SALF_PoliclinicLabel;
        private Label SALF_DoctorLabel;
        private CustomTools.RJButton.RJButton SALF_MakeAnAppointment;
        private Label SALF_PatientIdLabel;
        private Label SALF_NameLabel;
        private Label SALF_SurnameLabel;
        private CustomTools.RJButton.RJButton SALF_ShowButton;
        private CustomTools.RJTextBox.RJTextBox SALF_PatientSurnameTextbox;
        private ComboBox SALF_DoctorCombo;
        private ComboBox SALF_PoliclinicCombo;
        private DateTimePicker SALF_DateTime;
        private DataGridView SALF_MakeDataGrid;
    }
}