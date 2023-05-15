namespace proiectII
{
    partial class doctorsform
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
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label specialty_IDLabel;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorsform));
            this.insertDoctorBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new proiectII.DatabaseDataSet1();
            this.doctorsTableAdapter1 = new proiectII.DatabaseDataSet1TableAdapters.DoctorsTableAdapter();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.specialtyIDTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel1 = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            specialty_IDLabel = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(277, 230);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(75, 16);
            firstNameLabel1.TabIndex = 30;
            firstNameLabel1.Text = "First Name:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(277, 258);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(75, 16);
            lastNameLabel1.TabIndex = 32;
            lastNameLabel1.Text = "Last Name:";
            // 
            // specialty_IDLabel
            // 
            specialty_IDLabel.AutoSize = true;
            specialty_IDLabel.Location = new System.Drawing.Point(277, 286);
            specialty_IDLabel.Name = "specialty_IDLabel";
            specialty_IDLabel.Size = new System.Drawing.Size(82, 16);
            specialty_IDLabel.TabIndex = 34;
            specialty_IDLabel.Text = "Specialty ID:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(277, 314);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(100, 16);
            phoneNumberLabel1.TabIndex = 36;
            phoneNumberLabel1.Text = "Phone Number:";
            // 
            // insertDoctorBtn
            // 
            this.insertDoctorBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDoctorBtn.Location = new System.Drawing.Point(202, 392);
            this.insertDoctorBtn.Name = "insertDoctorBtn";
            this.insertDoctorBtn.Size = new System.Drawing.Size(98, 28);
            this.insertDoctorBtn.TabIndex = 11;
            this.insertDoctorBtn.Text = "INSERT";
            this.insertDoctorBtn.UseVisualStyleBackColor = true;
            this.insertDoctorBtn.Click += new System.EventHandler(this.insertDoctorBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(436, 392);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 28);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Century", 10F);
            this.updateBtn.Location = new System.Drawing.Point(320, 392);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 28);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorsDataGridView.AutoGenerateColumns = false;
            this.doctorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.doctorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.specialtyIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.doctorsDataGridView.DataSource = this.doctorsBindingSource1;
            this.doctorsDataGridView.GridColor = System.Drawing.Color.Gray;
            this.doctorsDataGridView.Location = new System.Drawing.Point(1, 2);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.RowHeadersWidth = 51;
            this.doctorsDataGridView.RowTemplate.Height = 24;
            this.doctorsDataGridView.Size = new System.Drawing.Size(825, 184);
            this.doctorsDataGridView.TabIndex = 27;
            this.doctorsDataGridView.AllowUserToAddRowsChanged += new System.EventHandler(this.insertDoctorBtn_Click);
            this.doctorsDataGridView.AllowUserToDeleteRowsChanged += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Doctor_ID";
            this.Column1.HeaderText = "Doctor_ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialtyIDDataGridViewTextBoxColumn
            // 
            this.specialtyIDDataGridViewTextBoxColumn.DataPropertyName = "Specialty_ID";
            this.specialtyIDDataGridViewTextBoxColumn.HeaderText = "Specialty_ID";
            this.specialtyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialtyIDDataGridViewTextBoxColumn.Name = "specialtyIDDataGridViewTextBoxColumn";
            this.specialtyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.databaseDataSet1BindingSource;
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataMember = "Doctors";
            this.doctorsBindingSource2.DataSource = this.databaseDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = this.doctorsTableAdapter1;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(375, 224);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 37;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(375, 252);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 38;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // specialtyIDTextBox
            // 
            this.specialtyIDTextBox.Location = new System.Drawing.Point(375, 280);
            this.specialtyIDTextBox.Name = "specialtyIDTextBox";
            this.specialtyIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.specialtyIDTextBox.TabIndex = 38;
            this.specialtyIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialtyIDTextBox_KeyPress);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(375, 308);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumberTextBox.TabIndex = 39;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // doctorsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(828, 525);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.specialtyIDTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(firstNameLabel1);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(specialty_IDLabel);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.doctorsDataGridView);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertDoctorBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(232, 30);
            this.Name = "doctorsform";
            this.Text = "doctorsform";
            this.Load += new System.EventHandler(this.doctorsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insertDoctorBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.BindingSource databaseDataSet1BindingSource;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private DatabaseDataSet1TableAdapters.DoctorsTableAdapter doctorsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox specialtyIDTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
    }
}