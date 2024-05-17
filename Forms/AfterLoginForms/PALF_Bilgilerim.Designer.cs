namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_Bilgilerim
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnBilgiGuncelle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(192, 95);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(172, 132);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11F);
            label3.Location = new Point(118, 168);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Identification No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 11F);
            label4.Location = new Point(172, 206);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "GSM No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 11F);
            label5.Location = new Point(169, 243);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(252, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(252, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(205, 23);
            textBox5.TabIndex = 9;
            // 
            // btnBilgiGuncelle
            // 
            btnBilgiGuncelle.Font = new Font("Yu Gothic UI Semibold", 10F);
            btnBilgiGuncelle.Location = new Point(252, 279);
            btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            btnBilgiGuncelle.Size = new Size(205, 39);
            btnBilgiGuncelle.TabIndex = 10;
            btnBilgiGuncelle.Text = "Guncelle";
            btnBilgiGuncelle.UseVisualStyleBackColor = true;
            // 
            // PALF_Bilgilerim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 402);
            Controls.Add(btnBilgiGuncelle);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PALF_Bilgilerim";
            Text = "PALF_Bilgilerim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnBilgiGuncelle;
    }
}