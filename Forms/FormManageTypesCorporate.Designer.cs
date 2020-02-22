namespace BudgetTrackingSoftware
{
    partial class FormManageTypesCorporate
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
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.grpAddType = new System.Windows.Forms.GroupBox();
            this.grpDeleteIncomeType = new System.Windows.Forms.GroupBox();
            this.listIncomeTypes = new System.Windows.Forms.ListBox();
            this.btnDeleteIncomeType = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listExpenseTypes = new System.Windows.Forms.ListBox();
            this.btnDeleteExpenseType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listExpenseCategories = new System.Windows.Forms.ListBox();
            this.btnDeleteExpenseCategory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listIncomeCategories = new System.Windows.Forms.ListBox();
            this.btnDeleteIncomeCategory = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.radioCategoryExpense = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCategoryIncome = new System.Windows.Forms.RadioButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listExpenseCategories2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listIncomeCategories2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAddType.SuspendLayout();
            this.grpDeleteIncomeType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(121, 57);
            this.txtTypeName.MaxLength = 13;
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(107, 26);
            this.txtTypeName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // btnAddType
            // 
            this.btnAddType.AutoSize = true;
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(144, 130);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 30);
            this.btnAddType.TabIndex = 5;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // grpAddType
            // 
            this.grpAddType.Controls.Add(this.lblName);
            this.grpAddType.Controls.Add(this.btnAddType);
            this.grpAddType.Controls.Add(this.txtTypeName);
            this.grpAddType.Location = new System.Drawing.Point(535, 33);
            this.grpAddType.Name = "grpAddType";
            this.grpAddType.Size = new System.Drawing.Size(244, 202);
            this.grpAddType.TabIndex = 6;
            this.grpAddType.TabStop = false;
            this.grpAddType.Text = "Add Type";
            // 
            // grpDeleteIncomeType
            // 
            this.grpDeleteIncomeType.Controls.Add(this.listIncomeTypes);
            this.grpDeleteIncomeType.Controls.Add(this.btnDeleteIncomeType);
            this.grpDeleteIncomeType.Location = new System.Drawing.Point(13, 247);
            this.grpDeleteIncomeType.Name = "grpDeleteIncomeType";
            this.grpDeleteIncomeType.Size = new System.Drawing.Size(244, 193);
            this.grpDeleteIncomeType.TabIndex = 7;
            this.grpDeleteIncomeType.TabStop = false;
            this.grpDeleteIncomeType.Text = "Delete Income Type";
            // 
            // listIncomeTypes
            // 
            this.listIncomeTypes.FormattingEnabled = true;
            this.listIncomeTypes.Location = new System.Drawing.Point(23, 24);
            this.listIncomeTypes.Name = "listIncomeTypes";
            this.listIncomeTypes.Size = new System.Drawing.Size(192, 121);
            this.listIncomeTypes.TabIndex = 6;
            // 
            // btnDeleteIncomeType
            // 
            this.btnDeleteIncomeType.AutoSize = true;
            this.btnDeleteIncomeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncomeType.Location = new System.Drawing.Point(128, 151);
            this.btnDeleteIncomeType.Name = "btnDeleteIncomeType";
            this.btnDeleteIncomeType.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteIncomeType.TabIndex = 5;
            this.btnDeleteIncomeType.Text = "Delete";
            this.btnDeleteIncomeType.UseVisualStyleBackColor = true;
            this.btnDeleteIncomeType.Click += new System.EventHandler(this.BtnDeleteIncomeType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listExpenseTypes);
            this.groupBox1.Controls.Add(this.btnDeleteExpenseType);
            this.groupBox1.Location = new System.Drawing.Point(276, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Expense Type";
            // 
            // listExpenseTypes
            // 
            this.listExpenseTypes.FormattingEnabled = true;
            this.listExpenseTypes.Location = new System.Drawing.Point(23, 32);
            this.listExpenseTypes.Name = "listExpenseTypes";
            this.listExpenseTypes.Size = new System.Drawing.Size(192, 121);
            this.listExpenseTypes.TabIndex = 6;
            // 
            // btnDeleteExpenseType
            // 
            this.btnDeleteExpenseType.AutoSize = true;
            this.btnDeleteExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpenseType.Location = new System.Drawing.Point(128, 159);
            this.btnDeleteExpenseType.Name = "btnDeleteExpenseType";
            this.btnDeleteExpenseType.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteExpenseType.TabIndex = 5;
            this.btnDeleteExpenseType.Text = "Delete";
            this.btnDeleteExpenseType.UseVisualStyleBackColor = true;
            this.btnDeleteExpenseType.Click += new System.EventHandler(this.BtnDeleteExpenseType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listExpenseCategories);
            this.groupBox2.Controls.Add(this.btnDeleteExpenseCategory);
            this.groupBox2.Location = new System.Drawing.Point(539, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 206);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Expense Category";
            // 
            // listExpenseCategories
            // 
            this.listExpenseCategories.FormattingEnabled = true;
            this.listExpenseCategories.Location = new System.Drawing.Point(23, 33);
            this.listExpenseCategories.Name = "listExpenseCategories";
            this.listExpenseCategories.Size = new System.Drawing.Size(192, 108);
            this.listExpenseCategories.TabIndex = 6;
            // 
            // btnDeleteExpenseCategory
            // 
            this.btnDeleteExpenseCategory.AutoSize = true;
            this.btnDeleteExpenseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpenseCategory.Location = new System.Drawing.Point(122, 157);
            this.btnDeleteExpenseCategory.Name = "btnDeleteExpenseCategory";
            this.btnDeleteExpenseCategory.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteExpenseCategory.TabIndex = 5;
            this.btnDeleteExpenseCategory.Text = "Delete";
            this.btnDeleteExpenseCategory.UseVisualStyleBackColor = true;
            this.btnDeleteExpenseCategory.Click += new System.EventHandler(this.BtnDeleteExpenseCategory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listIncomeCategories);
            this.groupBox3.Controls.Add(this.btnDeleteIncomeCategory);
            this.groupBox3.Location = new System.Drawing.Point(276, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 206);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Income Category";
            // 
            // listIncomeCategories
            // 
            this.listIncomeCategories.FormattingEnabled = true;
            this.listIncomeCategories.Location = new System.Drawing.Point(23, 33);
            this.listIncomeCategories.Name = "listIncomeCategories";
            this.listIncomeCategories.Size = new System.Drawing.Size(192, 108);
            this.listIncomeCategories.TabIndex = 6;
            // 
            // btnDeleteIncomeCategory
            // 
            this.btnDeleteIncomeCategory.AutoSize = true;
            this.btnDeleteIncomeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncomeCategory.Location = new System.Drawing.Point(128, 157);
            this.btnDeleteIncomeCategory.Name = "btnDeleteIncomeCategory";
            this.btnDeleteIncomeCategory.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteIncomeCategory.TabIndex = 5;
            this.btnDeleteIncomeCategory.Text = "Delete";
            this.btnDeleteIncomeCategory.UseVisualStyleBackColor = true;
            this.btnDeleteIncomeCategory.Click += new System.EventHandler(this.BtnDeleteIncomeCategory_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnAddCategory);
            this.groupBox4.Controls.Add(this.radioCategoryExpense);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.radioCategoryIncome);
            this.groupBox4.Controls.Add(this.txtCategoryName);
            this.groupBox4.Location = new System.Drawing.Point(13, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 206);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(133, 157);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 30);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // radioCategoryExpense
            // 
            this.radioCategoryExpense.AutoSize = true;
            this.radioCategoryExpense.Checked = true;
            this.radioCategoryExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioCategoryExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCategoryExpense.Location = new System.Drawing.Point(122, 110);
            this.radioCategoryExpense.Name = "radioCategoryExpense";
            this.radioCategoryExpense.Size = new System.Drawing.Size(95, 25);
            this.radioCategoryExpense.TabIndex = 0;
            this.radioCategoryExpense.TabStop = true;
            this.radioCategoryExpense.Text = "Expense";
            this.radioCategoryExpense.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // radioCategoryIncome
            // 
            this.radioCategoryIncome.AutoSize = true;
            this.radioCategoryIncome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioCategoryIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCategoryIncome.Location = new System.Drawing.Point(122, 79);
            this.radioCategoryIncome.Name = "radioCategoryIncome";
            this.radioCategoryIncome.Size = new System.Drawing.Size(86, 25);
            this.radioCategoryIncome.TabIndex = 1;
            this.radioCategoryIncome.Text = "Income";
            this.radioCategoryIncome.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(122, 33);
            this.txtCategoryName.MaxLength = 13;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(107, 26);
            this.txtCategoryName.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listExpenseCategories2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.listIncomeCategories2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(13, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 202);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Category";
            // 
            // listExpenseCategories2
            // 
            this.listExpenseCategories2.FormattingEnabled = true;
            this.listExpenseCategories2.Location = new System.Drawing.Point(284, 40);
            this.listExpenseCategories2.Name = "listExpenseCategories2";
            this.listExpenseCategories2.Size = new System.Drawing.Size(194, 147);
            this.listExpenseCategories2.TabIndex = 3;
            this.listExpenseCategories2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListExpenseCategories2_MouseClick);
            this.listExpenseCategories2.SelectedIndexChanged += new System.EventHandler(this.ListExpenseCategories2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expense Categories";
            // 
            // listIncomeCategories2
            // 
            this.listIncomeCategories2.FormattingEnabled = true;
            this.listIncomeCategories2.Location = new System.Drawing.Point(23, 40);
            this.listIncomeCategories2.Name = "listIncomeCategories2";
            this.listIncomeCategories2.Size = new System.Drawing.Size(194, 147);
            this.listIncomeCategories2.TabIndex = 1;
            this.listIncomeCategories2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListIncomeCategories2_MouseClick);
            this.listIncomeCategories2.SelectedIndexChanged += new System.EventHandler(this.ListIncomeCategories2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Income Categories";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 254);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Edit Categories";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.grpAddType);
            this.panel2.Controls.Add(this.grpDeleteIncomeType);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(1, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 454);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edit Types";
            // 
            // FormManageTypesCorporate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(794, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormManageTypesCorporate";
            this.Text = "Manage Types";
            this.grpAddType.ResumeLayout(false);
            this.grpAddType.PerformLayout();
            this.grpDeleteIncomeType.ResumeLayout(false);
            this.grpDeleteIncomeType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.GroupBox grpAddType;
        private System.Windows.Forms.GroupBox grpDeleteIncomeType;
        private System.Windows.Forms.ListBox listIncomeTypes;
        private System.Windows.Forms.Button btnDeleteIncomeType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listExpenseTypes;
        private System.Windows.Forms.Button btnDeleteExpenseType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listExpenseCategories;
        private System.Windows.Forms.Button btnDeleteExpenseCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listIncomeCategories;
        private System.Windows.Forms.Button btnDeleteIncomeCategory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.RadioButton radioCategoryExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCategoryIncome;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listExpenseCategories2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listIncomeCategories2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}