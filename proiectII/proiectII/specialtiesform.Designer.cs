namespace proiectII
{
    partial class specialtiesform
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(specialtiesform));
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet1 = new proiectII.DatabaseDataSet1();
            this.specialtiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtiesTableAdapter = new proiectII.DatabaseDataSet1TableAdapters.SpecialtiesTableAdapter();
            this.tableAdapterManager = new proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.specialtiesDataGridView = new System.Windows.Forms.DataGridView();
            this.specialtyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertDoctorBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century", 10.2F);
            nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            nameLabel.Image = ((System.Drawing.Image)(resources.GetObject("nameLabel.Image")));
            nameLabel.Location = new System.Drawing.Point(257, 186);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 21);
            nameLabel.TabIndex = 33;
            nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century", 10.2F);
            descriptionLabel.Image = ((System.Drawing.Image)(resources.GetObject("descriptionLabel.Image")));
            descriptionLabel.Location = new System.Drawing.Point(213, 241);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(102, 21);
            descriptionLabel.TabIndex = 35;
            descriptionLabel.Text = "Description";
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtiesBindingSource
            // 
            this.specialtiesBindingSource.DataMember = "Specialties";
            this.specialtiesBindingSource.DataSource = this.databaseDataSet1;
            // 
            // specialtiesTableAdapter
            // 
            this.specialtiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = this.specialtiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = proiectII.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialtiesDataGridView
            // 
            this.specialtiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialtiesDataGridView.AutoGenerateColumns = false;
            this.specialtiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specialtiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.specialtiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialtiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialtiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.specialtiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specialtyIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.specialtiesDataGridView.DataSource = this.specialtiesBindingSource;
            this.specialtiesDataGridView.GridColor = System.Drawing.Color.Gray;
            this.specialtiesDataGridView.Location = new System.Drawing.Point(1, 2);
            this.specialtiesDataGridView.Name = "specialtiesDataGridView";
            this.specialtiesDataGridView.RowHeadersWidth = 51;
            this.specialtiesDataGridView.RowTemplate.Height = 24;
            this.specialtiesDataGridView.Size = new System.Drawing.Size(756, 163);
            this.specialtiesDataGridView.TabIndex = 28;
            // 
            // specialtyIDDataGridViewTextBoxColumn
            // 
            this.specialtyIDDataGridViewTextBoxColumn.DataPropertyName = "Specialty_ID";
            this.specialtyIDDataGridViewTextBoxColumn.HeaderText = "Specialty_ID";
            this.specialtyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialtyIDDataGridViewTextBoxColumn.Name = "specialtyIDDataGridViewTextBoxColumn";
            this.specialtyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.Font = new System.Drawing.Font("Century", 10F);
            this.updateBtn.Location = new System.Drawing.Point(320, 392);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 28);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.Font = new System.Drawing.Font("Century", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(436, 392);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 28);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertDoctorBtn
            // 
            this.insertDoctorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insertDoctorBtn.BackgroundImage")));
            this.insertDoctorBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDoctorBtn.Location = new System.Drawing.Point(202, 392);
            this.insertDoctorBtn.Name = "insertDoctorBtn";
            this.insertDoctorBtn.Size = new System.Drawing.Size(98, 28);
            this.insertDoctorBtn.TabIndex = 29;
            this.insertDoctorBtn.Text = "INSERT";
            this.insertDoctorBtn.UseVisualStyleBackColor = true;
            this.insertDoctorBtn.Click += new System.EventHandler(this.insertDoctorBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nameTextBox.Location = new System.Drawing.Point(320, 187);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 22);
            this.nameTextBox.TabIndex = 37;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.descriptionTextBox.Location = new System.Drawing.Point(320, 240);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(205, 22);
            this.descriptionTextBox.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // specialtiesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertDoctorBtn);
            this.Controls.Add(this.specialtiesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(232, 30);
            this.Name = "specialtiesform";
            this.Text = "specialtiesform";
            this.Load += new System.EventHandler(this.specialtiesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource specialtiesBindingSource;
        private DatabaseDataSet1TableAdapters.SpecialtiesTableAdapter specialtiesTableAdapter;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView specialtiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertDoctorBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}