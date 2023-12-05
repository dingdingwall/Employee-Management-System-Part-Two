namespace Employee_Management_System_Part_Two
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.emS_DATABASEDataSet1 = new Employee_Management_System_Part_Two.EMS_DATABASEDataSet();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureboxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emS_DATABASEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(370, 191);
            this.SalaryTextBox.Multiline = true;
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(164, 31);
            this.SalaryTextBox.TabIndex = 0;
            // 
            // emS_DATABASEDataSet1
            // 
            this.emS_DATABASEDataSet1.DataSetName = "EMS_DATABASEDataSet";
            this.emS_DATABASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(370, 246);
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(164, 31);
            this.DateTextBox.TabIndex = 1;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(370, 141);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(164, 31);
            this.IDTextBox.TabIndex = 6;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalary.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddSalary.Location = new System.Drawing.Point(449, 311);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(113, 40);
            this.btnAddSalary.TabIndex = 7;
            this.btnAddSalary.Text = "Add";
            this.btnAddSalary.UseVisualStyleBackColor = false;
            this.btnAddSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Indigo;
            this.btnClear.Location = new System.Drawing.Point(330, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(269, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(305, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(316, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "EMPLOYEE\'S SALARY";
            // 
            // pictureboxBack
            // 
            this.pictureboxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxBack.Image")));
            this.pictureboxBack.Location = new System.Drawing.Point(688, 8);
            this.pictureboxBack.Name = "pictureboxBack";
            this.pictureboxBack.Size = new System.Drawing.Size(42, 33);
            this.pictureboxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxBack.TabIndex = 26;
            this.pictureboxBack.TabStop = false;
            this.pictureboxBack.Click += new System.EventHandler(this.pictureboxBack_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 653);
            this.Controls.Add(this.pictureboxBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emS_DATABASEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalaryTextBox;
        private EMS_DATABASEDataSet emS_DATABASEDataSet1;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureboxBack;
    }
}