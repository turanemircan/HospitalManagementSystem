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
            label1.Location = new Point(175, 167);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 0;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dtpRandevuTarihSec
            // 
            dtpRandevuTarihSec.Font = new Font("Yu Gothic UI Semibold", 12F);
            dtpRandevuTarihSec.Location = new Point(315, 164);
            dtpRandevuTarihSec.Margin = new Padding(3, 4, 3, 4);
            dtpRandevuTarihSec.Name = "dtpRandevuTarihSec";
            dtpRandevuTarihSec.Size = new Size(228, 34);
            dtpRandevuTarihSec.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 13F);
            label2.Location = new Point(153, 264);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 2;
            label2.Text = "Doktor Seçiniz:";
            // 
            // cBoxRandevuDoktorSec
            // 
            cBoxRandevuDoktorSec.FormattingEnabled = true;
            cBoxRandevuDoktorSec.Location = new Point(315, 268);
            cBoxRandevuDoktorSec.Margin = new Padding(3, 4, 3, 4);
            cBoxRandevuDoktorSec.Name = "cBoxRandevuDoktorSec";
            cBoxRandevuDoktorSec.Size = new Size(228, 28);
            cBoxRandevuDoktorSec.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 13F);
            label3.Location = new Point(133, 219);
            label3.Name = "label3";
            label3.Size = new Size(186, 30);
            label3.TabIndex = 4;
            label3.Text = "Poliklinik Seçiniz:";
            // 
            // cBoxRandevuPoliklinikSec
            // 
            cBoxRandevuPoliklinikSec.FormattingEnabled = true;
            cBoxRandevuPoliklinikSec.Location = new Point(315, 223);
            cBoxRandevuPoliklinikSec.Margin = new Padding(3, 4, 3, 4);
            cBoxRandevuPoliklinikSec.Name = "cBoxRandevuPoliklinikSec";
            cBoxRandevuPoliklinikSec.Size = new Size(228, 28);
            cBoxRandevuPoliklinikSec.TabIndex = 5;
            cBoxRandevuPoliklinikSec.SelectedIndexChanged += cBoxRandevuPoliklinikSec_SelectedIndexChanged;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Font = new Font("Yu Gothic UI Semibold", 10F);
            btnRandevuAl.Location = new Point(315, 320);
            btnRandevuAl.Margin = new Padding(3, 4, 3, 4);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(229, 39);
            btnRandevuAl.TabIndex = 6;
            btnRandevuAl.Text = "RandevuAl";
            btnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // PALF_RandevuAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 536);
            Controls.Add(btnRandevuAl);
            Controls.Add(cBoxRandevuPoliklinikSec);
            Controls.Add(label3);
            Controls.Add(cBoxRandevuDoktorSec);
            Controls.Add(label2);
            Controls.Add(dtpRandevuTarihSec);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ListView listView1;
    }
}