namespace proiectII
{
    partial class patientsform
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientsform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
           
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Century", 10.2F);
            firstNameLabel.Location = new System.Drawing.Point(213, 188);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(101, 21);
            firstNameLabel.TabIndex = 30;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Century", 10.2F);
            lastNameLabel.Location = new System.Drawing.Point(217, 241);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(97, 21);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century", 10.2F);
            emailLabel.Location = new System.Drawing.Point(258, 291);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 21);
            emailLabel.TabIndex = 34;
            emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Century", 10.2F);
            phoneNumberLabel.Location = new System.Drawing.Point(185, 341);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(129, 21);
            phoneNumberLabel.TabIndex = 36;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Century", 10.2F);
            birthDateLabel.Location = new System.Drawing.Point(219, 390);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(95, 21);
            birthDateLabel.TabIndex = 38;
            birthDateLabel.Text = "Birth Date";
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.birthDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
            this.birthDateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.LightBlue;
            this.birthDateDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.LightBlue;
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(320, 389);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(205, 22);
            this.birthDateDateTimePicker.TabIndex = 39;
            this.birthDateDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateDateTimePicker_ValueChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(313, 423);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 28);
            this.updateBtn.TabIndex = 42;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.insertBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(189, 423);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(103, 28);
            this.insertBtn.TabIndex = 41;
            this.insertBtn.Text = "INSERT";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(422, 423);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 28);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.firstNameTextBox.Location = new System.Drawing.Point(320, 187);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.firstNameTextBox.TabIndex = 43;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.lastNameTextBox.Location = new System.Drawing.Point(320, 240);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameTextBox.TabIndex = 44;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.emailTextBox.Location = new System.Drawing.Point(320, 291);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 22);
            this.emailTextBox.TabIndex = 45;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(320, 340);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(205, 22);
            this.phoneNumberTextBox.TabIndex = 46;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1,
            this.birthDateDataGridViewTextBoxColumn1});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.GridColor = System.Drawing.Color.Gray;
            this.patientsDataGridView.Location = new System.Drawing.Point(1, 2);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.RowHeadersWidth = 51;
            this.patientsDataGridView.RowTemplate.Height = 24;
            this.patientsDataGridView.Size = new System.Drawing.Size(756, 163);
            this.patientsDataGridView.TabIndex = 48;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            this.phoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn1
            // 
            this.birthDateDataGridViewTextBoxColumn1.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn1.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn1.Name = "birthDateDataGridViewTextBoxColumn1";
            this.birthDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(759, 504);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientsform";
            this.Text = "patientsform";
            this.Load += new System.EventHandler(this.patientsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
       private DatabaseDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn1;
    }
}