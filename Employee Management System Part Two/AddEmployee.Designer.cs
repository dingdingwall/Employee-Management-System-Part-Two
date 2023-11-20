namespace Employee_Management_System_Part_Two
{
    partial class AddEmployee
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
            this.txtbox_EmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_contact = new System.Windows.Forms.TextBox();
            this.txtbox_Date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMS_DATABASEDataSet = new Employee_Management_System_Part_Two.EMS_DATABASEDataSet();
            this.eMPLOYEETableAdapter = new Employee_Management_System_Part_Two.EMS_DATABASEDataSetTableAdapters.EMPLOYEETableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_delete = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMS_DATABASEDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_EmployeeName
            // 
            this.txtbox_EmployeeName.Location = new System.Drawing.Point(214, 158);
            this.txtbox_EmployeeName.Multiline = true;
            this.txtbox_EmployeeName.Name = "txtbox_EmployeeName";
            this.txtbox_EmployeeName.Size = new System.Drawing.Size(140, 28);
            this.txtbox_EmployeeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(412, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(451, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(506, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "LIST OF EMPLOYEES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtbox_ID);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtbox_contact);
            this.panel1.Controls.Add(this.txtbox_Date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtbox_Email);
            this.panel1.Controls.Add(this.txtbox_Address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbox_EmployeeName);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 652);
            this.panel1.TabIndex = 7;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(202, 549);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 37);
            this.btn_Reset.TabIndex = 22;
            this.btn_Reset.Text = "CLEAR";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(73, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Employee  ID";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(214, 86);
            this.txtbox_ID.Multiline = true;
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(140, 28);
            this.txtbox_ID.TabIndex = 20;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(77, 549);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(119, 37);
            this.btn_Insert.TabIndex = 16;
            this.btn_Insert.Text = "ADD ";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(43, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contact Number";
            // 
            // txtbox_contact
            // 
            this.txtbox_contact.Location = new System.Drawing.Point(214, 454);
            this.txtbox_contact.Multiline = true;
            this.txtbox_contact.Name = "txtbox_contact";
            this.txtbox_contact.Size = new System.Drawing.Size(140, 28);
            this.txtbox_contact.TabIndex = 14;
            // 
            // txtbox_Date
            // 
            this.txtbox_Date.Location = new System.Drawing.Point(214, 385);
            this.txtbox_Date.Multiline = true;
            this.txtbox_Date.Name = "txtbox_Date";
            this.txtbox_Date.Size = new System.Drawing.Size(140, 28);
            this.txtbox_Date.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(55, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date of Joining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(142, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(121, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.Location = new System.Drawing.Point(214, 311);
            this.txtbox_Email.Multiline = true;
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(140, 28);
            this.txtbox_Email.TabIndex = 9;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Location = new System.Drawing.Point(214, 238);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(140, 28);
            this.txtbox_Address.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(43, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(107)))), ((int)(((byte)(139)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(380, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 385);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.eMS_DATABASEDataSet;
            // 
            // eMS_DATABASEDataSet
            // 
            this.eMS_DATABASEDataSet.DataSetName = "EMS_DATABASEDataSet";
            this.eMS_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(497, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID ";
            // 
            // txtbox_delete
            // 
            this.txtbox_delete.Location = new System.Drawing.Point(171, 118);
            this.txtbox_delete.Multiline = true;
            this.txtbox_delete.Name = "txtbox_delete";
            this.txtbox_delete.Size = new System.Drawing.Size(160, 36);
            this.txtbox_delete.TabIndex = 21;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(340, 118);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 36);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txtbox_delete);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Location = new System.Drawing.Point(377, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 207);
            this.panel2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label11.Location = new System.Drawing.Point(165, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 35);
            this.label11.TabIndex = 23;
            this.label11.Text = "DELETE EMPLOYEE";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMS_DATABASEDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_EmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_contact;
        private System.Windows.Forms.TextBox txtbox_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_ID;
        private EMS_DATABASEDataSet eMS_DATABASEDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private EMS_DATABASEDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_delete;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
    }
}