namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_RandevuBilgileri
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
            dataGridViewAktifRandevu = new DataGridView();
            dataGridViewGecmisRandevu = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktifRandevu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGecmisRandevu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAktifRandevu
            // 
            dataGridViewAktifRandevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAktifRandevu.Location = new Point(12, 32);
            dataGridViewAktifRandevu.Name = "dataGridViewAktifRandevu";
            dataGridViewAktifRandevu.Size = new Size(577, 160);
            dataGridViewAktifRandevu.TabIndex = 0;
            // 
            // dataGridViewGecmisRandevu
            // 
            dataGridViewGecmisRandevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGecmisRandevu.Location = new Point(12, 230);
            dataGridViewGecmisRandevu.Name = "dataGridViewGecmisRandevu";
            dataGridViewGecmisRandevu.Size = new Size(577, 160);
            dataGridViewGecmisRandevu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "Aktif Randevular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Gecmis Randevular";
            // 
            // PALF_RandevuBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 402);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewGecmisRandevu);
            Controls.Add(dataGridViewAktifRandevu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PALF_RandevuBilgileri";
            Text = "PALF_RandevuBilgileri";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktifRandevu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGecmisRandevu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAktifRandevu;
        private DataGridView dataGridViewGecmisRandevu;
        private Label label1;
        private Label label2;
    }
}