namespace proiectII
{
    partial class appointmentsform
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
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label doctor_IDLabel;
            System.Windows.Forms.Label employee_IDLabel;
            System.Windows.Forms.Label appointmentDateTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointmentsform));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.databaseDataSet1 = new proiectII.DatabaseDataSet1();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new proiectII.DatabaseDataSet1TableAdapters.AppointmentsTableAdapter();
            this.tableAdapterManager = new proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Appointment_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.doctor_IDTextBox = new System.Windows.Forms.TextBox();
            this.employee_IDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            patient_IDLabel = new System.Windows.Forms.Label();
            doctor_IDLabel = new System.Windows.Forms.Label();
            employee_IDLabel = new System.Windows.Forms.Label();
            appointmentDateTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Century", 10.2F);
            patient_IDLabel.Location = new System.Drawing.Point(213, 188);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(93, 21);
            patient_IDLabel.TabIndex = 28;
            patient_IDLabel.Text = "Patient ID";
            // 
            // doctor_IDLabel
            // 
            doctor_IDLabel.AutoSize = true;
            doctor_IDLabel.Font = new System.Drawing.Font("Century", 10.2F);
            doctor_IDLabel.Location = new System.Drawing.Point(217, 241);
            doctor_IDLabel.Name = "doctor_IDLabel";
            doctor_IDLabel.Size = new System.Drawing.Size(89, 21);
            doctor_IDLabel.TabIndex = 30;
            doctor_IDLabel.Text = "Doctor ID";
            // 
            // employee_IDLabel
            // 
            employee_IDLabel.AutoSize = true;
            employee_IDLabel.Font = new System.Drawing.Font("Century", 10.2F);
            employee_IDLabel.Location = new System.Drawing.Point(193, 290);
            employee_IDLabel.Name = "employee_IDLabel";
            employee_IDLabel.Size = new System.Drawing.Size(113, 21);
            employee_IDLabel.TabIndex = 32;
            employee_IDLabel.Text = "Employee ID";
            // 
            // appointmentDateTimeLabel
            // 
            appointmentDateTimeLabel.AutoSize = true;
            appointmentDateTimeLabel.Font = new System.Drawing.Font("Century", 10.2F);
            appointmentDateTimeLabel.Location = new System.Drawing.Point(104, 341);
            appointmentDateTimeLabel.Name = "appointmentDateTimeLabel";
            appointmentDateTimeLabel.Size = new System.Drawing.Size(202, 21);
            appointmentDateTimeLabel.TabIndex = 34;
            appointmentDateTimeLabel.Text = "Appointment Date Time";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century", 10.2F);
            descriptionLabel.Location = new System.Drawing.Point(204, 389);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(102, 21);
            descriptionLabel.TabIndex = 36;
            descriptionLabel.Text = "Description";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(422, 423);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 28);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(189, 423);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(103, 28);
            this.insertBtn.TabIndex = 24;
            this.insertBtn.Text = "INSERT";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(313, 423);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 28);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            this.appointmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.appointmentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.appointmentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appointment_ID,
            this.patientIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.appointmentDateTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.appointmentsDataGridView.DataSource = this.appointmentsBindingSource;
            this.appointmentsDataGridView.GridColor = System.Drawing.Color.Gray;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(1, 2);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 51;
            this.appointmentsDataGridView.RowTemplate.Height = 24;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(756, 163);
            this.appointmentsDataGridView.TabIndex = 38;
            // 
            // Appointment_ID
            // 
            this.Appointment_ID.DataPropertyName = "Appointment_ID";
            this.Appointment_ID.HeaderText = "Appointment_ID";
            this.Appointment_ID.MinimumWidth = 6;
            this.Appointment_ID.Name = "Appointment_ID";
            this.Appointment_ID.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentDateTimeDataGridViewTextBoxColumn
            // 
            this.appointmentDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDateTime";
            this.appointmentDateTimeDataGridViewTextBoxColumn.HeaderText = "AppointmentDateTime";
            this.appointmentDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentDateTimeDataGridViewTextBoxColumn.Name = "appointmentDateTimeDataGridViewTextBoxColumn";
            this.appointmentDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 432);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.patient_IDTextBox.Location = new System.Drawing.Point(320, 189);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(205, 22);
            this.patient_IDTextBox.TabIndex = 40;
            this.patient_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_IDTextBox_KeyPress_1);
            // 
            // doctor_IDTextBox
            // 
            this.doctor_IDTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.doctor_IDTextBox.Location = new System.Drawing.Point(320, 240);
            this.doctor_IDTextBox.Name = "doctor_IDTextBox";
            this.doctor_IDTextBox.Size = new System.Drawing.Size(205, 22);
            this.doctor_IDTextBox.TabIndex = 41;
            this.doctor_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doctor_IDTextBox_KeyPress_1);
            // 
            // employee_IDTextBox
            // 
            this.employee_IDTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.employee_IDTextBox.Location = new System.Drawing.Point(320, 291);
            this.employee_IDTextBox.Name = "employee_IDTextBox";
            this.employee_IDTextBox.Size = new System.Drawing.Size(205, 22);
            this.employee_IDTextBox.TabIndex = 42;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.descriptionTextBox.Location = new System.Drawing.Point(320, 388);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(205, 22);
            this.descriptionTextBox.TabIndex = 43;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.CustomFormat = "dd/MM/yyyy HH:00";
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(320, 340);
            this.appointmentDateTimePicker.MaxDate = new System.DateTime(2050, 12, 31, 19, 0, 0, 0);
            this.appointmentDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.ShowUpDown = true;
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(205, 22);
            this.appointmentDateTimePicker.TabIndex = 44;
            this.appointmentDateTimePicker.ValueChanged += new System.EventHandler(this.appointmentDateTimePicker_ValueChanged_1);
            // 
            // appointmentsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 505);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.employee_IDTextBox);
            this.Controls.Add(this.doctor_IDTextBox);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(doctor_IDLabel);
            this.Controls.Add(employee_IDLabel);
            this.Controls.Add(appointmentDateTimeLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.deleteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "appointmentsform";
            this.Text = "appointmentsform";
            this.Load += new System.EventHandler(this.appointmentsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private DatabaseDataSet1TableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox doctor_IDTextBox;
        private System.Windows.Forms.TextBox employee_IDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}