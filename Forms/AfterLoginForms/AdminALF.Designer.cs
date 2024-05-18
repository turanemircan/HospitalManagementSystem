namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class AdminALF
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
            panel1 = new Panel();
            buttonAALF_Secretary = new Button();
            labelAALF_AdminNamee = new Label();
            labelAALF_AdminID = new Label();
            labelAALF_AdminN = new Label();
            buttonAALF_DoctorEdit = new Button();
            buttonAALF_DoctorReviews = new Button();
            labelAALF_AdminI = new Label();
            pictureBox1 = new PictureBox();
            panelAdminALF = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(buttonAALF_Secretary);
            panel1.Controls.Add(labelAALF_AdminNamee);
            panel1.Controls.Add(labelAALF_AdminID);
            panel1.Controls.Add(labelAALF_AdminN);
            panel1.Controls.Add(buttonAALF_DoctorEdit);
            panel1.Controls.Add(buttonAALF_DoctorReviews);
            panel1.Controls.Add(labelAALF_AdminI);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 553);
            panel1.TabIndex = 0;
            // 
            // buttonAALF_Secretary
            // 
            buttonAALF_Secretary.Dock = DockStyle.Bottom;
            buttonAALF_Secretary.Location = new Point(0, 181);
            buttonAALF_Secretary.Name = "buttonAALF_Secretary";
            buttonAALF_Secretary.Size = new Size(298, 44);
            buttonAALF_Secretary.TabIndex = 10;
            buttonAALF_Secretary.Text = "Secretary Edit";
            buttonAALF_Secretary.UseVisualStyleBackColor = true;
            buttonAALF_Secretary.Click += buttonAALF_Secretary_Click;
            // 
            // labelAALF_AdminNamee
            // 
            labelAALF_AdminNamee.AutoSize = true;
            labelAALF_AdminNamee.BackColor = Color.White;
            labelAALF_AdminNamee.Location = new Point(186, 98);
            labelAALF_AdminNamee.Name = "labelAALF_AdminNamee";
            labelAALF_AdminNamee.Size = new Size(50, 20);
            labelAALF_AdminNamee.TabIndex = 9;
            labelAALF_AdminNamee.Text = "label2";
            // 
            // labelAALF_AdminID
            // 
            labelAALF_AdminID.AutoSize = true;
            labelAALF_AdminID.BackColor = Color.White;
            labelAALF_AdminID.Location = new Point(186, 65);
            labelAALF_AdminID.Name = "labelAALF_AdminID";
            labelAALF_AdminID.Size = new Size(42, 20);
            labelAALF_AdminID.TabIndex = 0;
            labelAALF_AdminID.Text = "label";
            // 
            // labelAALF_AdminN
            // 
            labelAALF_AdminN.AutoSize = true;
            labelAALF_AdminN.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelAALF_AdminN.Location = new Point(52, 95);
            labelAALF_AdminN.Name = "labelAALF_AdminN";
            labelAALF_AdminN.Size = new Size(128, 23);
            labelAALF_AdminN.TabIndex = 8;
            labelAALF_AdminN.Text = "Admin Name =";
            // 
            // buttonAALF_DoctorEdit
            // 
            buttonAALF_DoctorEdit.Dock = DockStyle.Bottom;
            buttonAALF_DoctorEdit.Location = new Point(0, 225);
            buttonAALF_DoctorEdit.Name = "buttonAALF_DoctorEdit";
            buttonAALF_DoctorEdit.Size = new Size(298, 43);
            buttonAALF_DoctorEdit.TabIndex = 7;
            buttonAALF_DoctorEdit.Text = "Doctor Edit";
            buttonAALF_DoctorEdit.UseVisualStyleBackColor = true;
            buttonAALF_DoctorEdit.Click += buttonAALF_DoctorEdit_Click;
            // 
            // buttonAALF_DoctorReviews
            // 
            buttonAALF_DoctorReviews.Dock = DockStyle.Bottom;
            buttonAALF_DoctorReviews.Location = new Point(0, 268);
            buttonAALF_DoctorReviews.Name = "buttonAALF_DoctorReviews";
            buttonAALF_DoctorReviews.Size = new Size(298, 42);
            buttonAALF_DoctorReviews.TabIndex = 0;
            buttonAALF_DoctorReviews.Text = "Doctor Reviews";
            buttonAALF_DoctorReviews.UseVisualStyleBackColor = true;
            buttonAALF_DoctorReviews.Click += buttonAALF_DoctorReviews_Click;
            // 
            // labelAALF_AdminI
            // 
            labelAALF_AdminI.AutoSize = true;
            labelAALF_AdminI.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelAALF_AdminI.Location = new Point(52, 63);
            labelAALF_AdminI.Name = "labelAALF_AdminI";
            labelAALF_AdminI.Size = new Size(99, 23);
            labelAALF_AdminI.TabIndex = 0;
            labelAALF_AdminI.Text = "Admin ID =";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 310);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelAdminALF
            // 
            panelAdminALF.BackColor = Color.White;
            panelAdminALF.Dock = DockStyle.Fill;
            panelAdminALF.Location = new Point(298, 0);
            panelAdminALF.Name = "panelAdminALF";
            panelAdminALF.Size = new Size(995, 553);
            panelAdminALF.TabIndex = 1;
            // 
            // AdminALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 553);
            Controls.Add(panelAdminALF);
            Controls.Add(panel1);
            Name = "AdminALF";
            Text = "AdminALF";
            FormClosed += AdminALF_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelAdminALF;
        private PictureBox pictureBox1;
        private Label labelAALF_AdminI;
        private Button buttonAALF_DoctorReviews;
        private Button buttonAALF_DoctorEdit;
        private Label labelAALF_AdminNamee;
        private Label labelAALF_AdminID;
        private Label labelAALF_AdminN;
        private Button buttonAALF_Secretary;
    }
}