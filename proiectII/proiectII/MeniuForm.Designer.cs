namespace proiectII
{
    partial class MeniuForm
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
            this.components = new System.ComponentModel.Container();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.specialtiesBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.appointmentsBtn = new System.Windows.Forms.Button();
            this.doctorsBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.leftPanel.Controls.Add(this.logOutBtn);
            this.leftPanel.Controls.Add(this.specialtiesBtn);
            this.leftPanel.Controls.Add(this.patientsBtn);
            this.leftPanel.Controls.Add(this.appointmentsBtn);
            this.leftPanel.Controls.Add(this.doctorsBtn);
            this.leftPanel.Controls.Add(this.employeesBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftPanel.Location = new System.Drawing.Point(0, 30);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(232, 504);
            this.leftPanel.TabIndex = 0;
            // 
            // specialtiesBtn
            // 
            this.specialtiesBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.specialtiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialtiesBtn.Font = new System.Drawing.Font("Century", 10.8F);
            this.specialtiesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.specialtiesBtn.Location = new System.Drawing.Point(0, 349);
            this.specialtiesBtn.Name = "specialtiesBtn";
            this.specialtiesBtn.Size = new System.Drawing.Size(232, 90);
            this.specialtiesBtn.TabIndex = 6;
            this.specialtiesBtn.Text = "SPECIALTIES";
            this.specialtiesBtn.UseVisualStyleBackColor = false;
            this.specialtiesBtn.Click += new System.EventHandler(this.specialtiesBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Century", 10.2F);
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutBtn.Location = new System.Drawing.Point(0, 437);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(232, 67);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Century", 10.8F);
            this.patientsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientsBtn.Location = new System.Drawing.Point(0, 256);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(232, 90);
            this.patientsBtn.TabIndex = 3;
            this.patientsBtn.Text = "PATIENTS";
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // appointmentsBtn
            // 
            this.appointmentsBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.appointmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentsBtn.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appointmentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentsBtn.Location = new System.Drawing.Point(0, 0);
            this.appointmentsBtn.Name = "appointmentsBtn";
            this.appointmentsBtn.Size = new System.Drawing.Size(232, 90);
            this.appointmentsBtn.TabIndex = 0;
            this.appointmentsBtn.Text = "APPOINTMENTS";
            this.appointmentsBtn.UseVisualStyleBackColor = false;
            this.appointmentsBtn.Click += new System.EventHandler(this.appointmentsBtn_Click);
            // 
            // doctorsBtn
            // 
            this.doctorsBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.doctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsBtn.Font = new System.Drawing.Font("Century", 10.8F);
            this.doctorsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorsBtn.Location = new System.Drawing.Point(0, 172);
            this.doctorsBtn.Name = "doctorsBtn";
            this.doctorsBtn.Size = new System.Drawing.Size(232, 90);
            this.doctorsBtn.TabIndex = 2;
            this.doctorsBtn.Text = "DOCTORS";
            this.doctorsBtn.UseVisualStyleBackColor = false;
            this.doctorsBtn.Click += new System.EventHandler(this.doctorsBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Century", 10.8F);
            this.employeesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeesBtn.Location = new System.Drawing.Point(0, 86);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(232, 90);
            this.employeesBtn.TabIndex = 1;
            this.employeesBtn.Text = "EMPLOYEES";
            this.employeesBtn.UseVisualStyleBackColor = false;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.timeLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(991, 30);
            this.topPanel.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(874, 5);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 22);
            this.timeLabel.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(962, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(29, 30);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.LightBlue;
            this.mainPanel.Location = new System.Drawing.Point(232, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(759, 504);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MeniuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(991, 534);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeniuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuForm";
            this.Load += new System.EventHandler(this.MeniuForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button appointmentsBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button doctorsBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button specialtiesBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}