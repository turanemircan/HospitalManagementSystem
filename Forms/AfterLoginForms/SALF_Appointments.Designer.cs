namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SALF_Appointments
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
            DataGridSALF_Appointments = new DataGridView();
            LabelSALF_AllAppointments = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Appointments).BeginInit();
            SuspendLayout();
            // 
            // DataGridSALF_Appointments
            // 
            DataGridSALF_Appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridSALF_Appointments.Location = new Point(12, 42);
            DataGridSALF_Appointments.Margin = new Padding(3, 2, 3, 2);
            DataGridSALF_Appointments.Name = "DataGridSALF_Appointments";
            DataGridSALF_Appointments.RowHeadersWidth = 51;
            DataGridSALF_Appointments.Size = new Size(676, 285);
            DataGridSALF_Appointments.TabIndex = 0;
            DataGridSALF_Appointments.MouseEnter += DataGridSALF_Appointments_MouseEnter;
            // 
            // LabelSALF_AllAppointments
            // 
            LabelSALF_AllAppointments.AutoSize = true;
            LabelSALF_AllAppointments.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_AllAppointments.Location = new Point(37, 20);
            LabelSALF_AllAppointments.Name = "LabelSALF_AllAppointments";
            LabelSALF_AllAppointments.Size = new Size(127, 20);
            LabelSALF_AllAppointments.TabIndex = 53;
            LabelSALF_AllAppointments.Text = "All Appointments";
            // 
            // SALF_Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(LabelSALF_AllAppointments);
            Controls.Add(DataGridSALF_Appointments);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SALF_Appointments";
            Text = "SALF_Appointments";
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridSALF_Appointments;
        private Label LabelSALF_AllAppointments;
    }
}