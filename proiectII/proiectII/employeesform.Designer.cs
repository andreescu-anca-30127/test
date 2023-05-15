namespace proiectII
{
    partial class employeesform
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label permissionlevellabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeesform));
            //this.databaseDataSet1 = new proiectII.DatabaseDataSet1();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
          //  this.employeesTableAdapter = new proiectII.DatabaseDataSet1TableAdapters.EmployeesTableAdapter();
          //  this.tableAdapterManager = new proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permissionLevelTextBox = new System.Windows.Forms.TextBox();
            this.databaseDataSet = new proiectII.DatabaseDataSet();
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter1 = new proiectII.DatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager1 = new proiectII.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.PermissionLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            permissionlevellabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
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
            lastNameLabel.Location = new System.Drawing.Point(213, 241);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(97, 21);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Last Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Century", 10.2F);
            passwordLabel.Location = new System.Drawing.Point(213, 294);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(85, 21);
            passwordLabel.TabIndex = 34;
            passwordLabel.Text = "Password";
            // 
            // permissionlevellabel
            // 
            permissionlevellabel.AutoSize = true;
            permissionlevellabel.Font = new System.Drawing.Font("Century", 10.2F);
            permissionlevellabel.Location = new System.Drawing.Point(164, 336);
            permissionlevellabel.Name = "permissionlevellabel";
            permissionlevellabel.Size = new System.Drawing.Size(146, 21);
            permissionlevellabel.TabIndex = 43;
            permissionlevellabel.Text = "Permission Level";
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.databaseDataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.PermissionLevel});
            this.employeesDataGridView.DataSource = this.employeesBindingSource2;
            this.employeesDataGridView.GridColor = System.Drawing.Color.Gray;
            this.employeesDataGridView.Location = new System.Drawing.Point(1, 2);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.Size = new System.Drawing.Size(777, 217);
            this.employeesDataGridView.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Employee_ID";
            this.Column1.HeaderText = "Employee_ID";
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
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(320, 392);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 28);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(202, 392);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(103, 28);
            this.insertBtn.TabIndex = 37;
            this.insertBtn.Text = "INSERT";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(436, 392);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 28);
            this.deleteBtn.TabIndex = 36;
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
            this.firstNameTextBox.TabIndex = 39;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.lastNameTextBox.Location = new System.Drawing.Point(320, 240);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameTextBox.TabIndex = 40;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.passwordTextBox.Location = new System.Drawing.Point(320, 291);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(205, 22);
            this.passwordTextBox.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // permissionLevelTextBox
            // 
            this.permissionLevelTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.permissionLevelTextBox.Location = new System.Drawing.Point(320, 337);
            this.permissionLevelTextBox.Name = "permissionLevelTextBox";
            this.permissionLevelTextBox.Size = new System.Drawing.Size(205, 22);
            this.permissionLevelTextBox.TabIndex = 44;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.databaseDataSet;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AppointmentsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DoctorsTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.PatientsTableAdapter = null;
            this.tableAdapterManager1.SpecialtiesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = proiectII.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PermissionLevel
            // 
            this.PermissionLevel.DataPropertyName = "PermissionLevel";
            this.PermissionLevel.HeaderText = "PermissionLevel";
            this.PermissionLevel.MinimumWidth = 6;
            this.PermissionLevel.Name = "PermissionLevel";
            this.PermissionLevel.ReadOnly = true;
            // 
            // employeesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(780, 579);
            this.Controls.Add(this.permissionLevelTextBox);
            this.Controls.Add(permissionlevellabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.employeesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeesform";
            this.Text = "z";
            this.Load += new System.EventHandler(this.employeesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private DatabaseDataSet1 databaseDataSet1;
       // private System.Windows.Forms.BindingSource employeesBindingSource;
      //  private DatabaseDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
      //  private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.TextBox permissionLevelTextBox;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private DatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionLevel;
    }
}