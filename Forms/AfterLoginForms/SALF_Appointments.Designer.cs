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
            SALF_AppointmentsDataGrid = new DataGridView();
            SALF_AllAppointments = new Label();
            ((System.ComponentModel.ISupportInitialize)SALF_AppointmentsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // SALF_AppointmentsDataGrid
            // 
            SALF_AppointmentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SALF_AppointmentsDataGrid.Location = new Point(42, 74);
            SALF_AppointmentsDataGrid.Name = "SALF_AppointmentsDataGrid";
            SALF_AppointmentsDataGrid.RowHeadersWidth = 51;
            SALF_AppointmentsDataGrid.Size = new Size(694, 309);
            SALF_AppointmentsDataGrid.TabIndex = 0;
            // 
            // SALF_AllAppointments
            // 
            SALF_AllAppointments.AutoSize = true;
            SALF_AllAppointments.Font = new Font("Yu Gothic UI Semibold", 11F);
            SALF_AllAppointments.Location = new Point(42, 26);
            SALF_AllAppointments.Name = "SALF_AllAppointments";
            SALF_AllAppointments.Size = new Size(162, 25);
            SALF_AllAppointments.TabIndex = 53;
            SALF_AllAppointments.Text = "All Appointments";
            // 
            // SALF_Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SALF_AllAppointments);
            Controls.Add(SALF_AppointmentsDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALF_Appointments";
            Text = "SALF_Appointments";
            ((System.ComponentModel.ISupportInitialize)SALF_AppointmentsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SALF_AppointmentsDataGrid;
        private Label SALF_AllAppointments;
    }
}