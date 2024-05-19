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
            labelAALF_AdminName = new Label();
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
            panel1.Controls.Add(labelAALF_AdminName);
            panel1.Controls.Add(labelAALF_AdminID);
            panel1.Controls.Add(labelAALF_AdminN);
            panel1.Controls.Add(buttonAALF_DoctorEdit);
            panel1.Controls.Add(buttonAALF_DoctorReviews);
            panel1.Controls.Add(labelAALF_AdminI);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 415);
            panel1.TabIndex = 0;
            // 
            // buttonAALF_Secretary
            // 
            buttonAALF_Secretary.Dock = DockStyle.Bottom;
            buttonAALF_Secretary.Location = new Point(0, 136);
            buttonAALF_Secretary.Margin = new Padding(3, 2, 3, 2);
            buttonAALF_Secretary.Name = "buttonAALF_Secretary";
            buttonAALF_Secretary.Size = new Size(261, 33);
            buttonAALF_Secretary.TabIndex = 10;
            buttonAALF_Secretary.Text = "Secretary Edit";
            buttonAALF_Secretary.UseVisualStyleBackColor = true;
            buttonAALF_Secretary.Click += buttonAALF_Secretary_Click;
            // 
            // labelAALF_AdminName
            // 
            labelAALF_AdminName.AutoSize = true;
            labelAALF_AdminName.BackColor = Color.White;
            labelAALF_AdminName.Location = new Point(163, 74);
            labelAALF_AdminName.Name = "labelAALF_AdminName";
            labelAALF_AdminName.Size = new Size(38, 15);
            labelAALF_AdminName.TabIndex = 9;
            labelAALF_AdminName.Text = "label2";
            // 
            // labelAALF_AdminID
            // 
            labelAALF_AdminID.AutoSize = true;
            labelAALF_AdminID.BackColor = Color.White;
            labelAALF_AdminID.Location = new Point(163, 49);
            labelAALF_AdminID.Name = "labelAALF_AdminID";
            labelAALF_AdminID.Size = new Size(32, 15);
            labelAALF_AdminID.TabIndex = 0;
            labelAALF_AdminID.Text = "label";
            // 
            // labelAALF_AdminN
            // 
            labelAALF_AdminN.AutoSize = true;
            labelAALF_AdminN.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelAALF_AdminN.Location = new Point(46, 71);
            labelAALF_AdminN.Name = "labelAALF_AdminN";
            labelAALF_AdminN.Size = new Size(105, 19);
            labelAALF_AdminN.TabIndex = 8;
            labelAALF_AdminN.Text = "Admin Name =";
            // 
            // buttonAALF_DoctorEdit
            // 
            buttonAALF_DoctorEdit.Dock = DockStyle.Bottom;
            buttonAALF_DoctorEdit.Location = new Point(0, 169);
            buttonAALF_DoctorEdit.Margin = new Padding(3, 2, 3, 2);
            buttonAALF_DoctorEdit.Name = "buttonAALF_DoctorEdit";
            buttonAALF_DoctorEdit.Size = new Size(261, 32);
            buttonAALF_DoctorEdit.TabIndex = 7;
            buttonAALF_DoctorEdit.Text = "Doctor Edit";
            buttonAALF_DoctorEdit.UseVisualStyleBackColor = true;
            buttonAALF_DoctorEdit.Click += buttonAALF_DoctorEdit_Click;
            // 
            // buttonAALF_DoctorReviews
            // 
            buttonAALF_DoctorReviews.Dock = DockStyle.Bottom;
            buttonAALF_DoctorReviews.Location = new Point(0, 201);
            buttonAALF_DoctorReviews.Margin = new Padding(3, 2, 3, 2);
            buttonAALF_DoctorReviews.Name = "buttonAALF_DoctorReviews";
            buttonAALF_DoctorReviews.Size = new Size(261, 32);
            buttonAALF_DoctorReviews.TabIndex = 0;
            buttonAALF_DoctorReviews.Text = "Doctor Reviews";
            buttonAALF_DoctorReviews.UseVisualStyleBackColor = true;
            buttonAALF_DoctorReviews.Click += buttonAALF_DoctorReviews_Click;
            // 
            // labelAALF_AdminI
            // 
            labelAALF_AdminI.AutoSize = true;
            labelAALF_AdminI.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelAALF_AdminI.Location = new Point(46, 47);
            labelAALF_AdminI.Name = "labelAALF_AdminI";
            labelAALF_AdminI.Size = new Size(82, 19);
            labelAALF_AdminI.TabIndex = 0;
            labelAALF_AdminI.Text = "Admin ID =";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelAdminALF
            // 
            panelAdminALF.BackColor = Color.White;
            panelAdminALF.Dock = DockStyle.Fill;
            panelAdminALF.Location = new Point(261, 0);
            panelAdminALF.Margin = new Padding(3, 2, 3, 2);
            panelAdminALF.Name = "panelAdminALF";
            panelAdminALF.Size = new Size(870, 415);
            panelAdminALF.TabIndex = 1;
            // 
            // AdminALF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 415);
            Controls.Add(panelAdminALF);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminALF";
            Text = "AdminALF";
            FormClosed += AdminALF_FormClosed;
            Load += AdminALF_Load;
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
        private Label labelAALF_AdminName;
        private Label labelAALF_AdminID;
        private Label labelAALF_AdminN;
        private Button buttonAALF_Secretary;
    }
}