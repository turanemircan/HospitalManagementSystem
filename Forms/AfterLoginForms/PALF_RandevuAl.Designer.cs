namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_RandevuAl
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
            label1 = new Label();
            dtpRandevuTarihSec = new DateTimePicker();
            label2 = new Label();
            cBoxRandevuDoktorSec = new ComboBox();
            label3 = new Label();
            cBoxRandevuPoliklinikSec = new ComboBox();
            btnRandevuAl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 13F);
            label1.Location = new Point(153, 125);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dtpRandevuTarihSec
            // 
            dtpRandevuTarihSec.Font = new Font("Yu Gothic UI Semibold", 12F);
            dtpRandevuTarihSec.Location = new Point(276, 123);
            dtpRandevuTarihSec.Name = "dtpRandevuTarihSec";
            dtpRandevuTarihSec.Size = new Size(200, 29);
            dtpRandevuTarihSec.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 13F);
            label2.Location = new Point(134, 198);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 2;
            label2.Text = "Doktor Seçiniz:";
            // 
            // cBoxRandevuDoktorSec
            // 
            cBoxRandevuDoktorSec.FormattingEnabled = true;
            cBoxRandevuDoktorSec.Location = new Point(276, 201);
            cBoxRandevuDoktorSec.Name = "cBoxRandevuDoktorSec";
            cBoxRandevuDoktorSec.Size = new Size(200, 23);
            cBoxRandevuDoktorSec.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 13F);
            label3.Location = new Point(116, 164);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 4;
            label3.Text = "Poliklinik Seçiniz:";
            // 
            // cBoxRandevuPoliklinikSec
            // 
            cBoxRandevuPoliklinikSec.FormattingEnabled = true;
            cBoxRandevuPoliklinikSec.Location = new Point(276, 167);
            cBoxRandevuPoliklinikSec.Name = "cBoxRandevuPoliklinikSec";
            cBoxRandevuPoliklinikSec.Size = new Size(200, 23);
            cBoxRandevuPoliklinikSec.TabIndex = 5;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Font = new Font("Yu Gothic UI Semibold", 10F);
            btnRandevuAl.Location = new Point(276, 240);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(200, 29);
            btnRandevuAl.TabIndex = 6;
            btnRandevuAl.Text = "RandevuAl";
            btnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // PALF_RandevuAl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 402);
            Controls.Add(btnRandevuAl);
            Controls.Add(cBoxRandevuPoliklinikSec);
            Controls.Add(label3);
            Controls.Add(cBoxRandevuDoktorSec);
            Controls.Add(label2);
            Controls.Add(dtpRandevuTarihSec);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PALF_RandevuAl";
            Text = "PALF_RandevuAl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpRandevuTarihSec;
        private Label label2;
        private ComboBox cBoxRandevuDoktorSec;
        private Label label3;
        private ComboBox cBoxRandevuPoliklinikSec;
        private Button btnRandevuAl;
    }
}