namespace BudgetTrackingSoftware
{
    partial class FormManageTypes
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
            this.radioExpense = new System.Windows.Forms.RadioButton();
            this.radioIncome = new System.Windows.Forms.RadioButton();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.grpAddType = new System.Windows.Forms.GroupBox();
            this.grpDeleteIncomeType = new System.Windows.Forms.GroupBox();
            this.listIncomeTypes = new System.Windows.Forms.ListBox();
            this.btnDeleteIncomeType = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listExpenseTypes = new System.Windows.Forms.ListBox();
            this.btnDeleteExpenseType = new System.Windows.Forms.Button();
            this.grpAddType.SuspendLayout();
            this.grpDeleteIncomeType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioExpense
            // 
            this.radioExpense.AutoSize = true;
            this.radioExpense.Checked = true;
            this.radioExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioExpense.Location = new System.Drawing.Point(122, 117);
            this.radioExpense.Name = "radioExpense";
            this.radioExpense.Size = new System.Drawing.Size(95, 25);
            this.radioExpense.TabIndex = 0;
            this.radioExpense.TabStop = true;
            this.radioExpense.Text = "Expense";
            this.radioExpense.UseVisualStyleBackColor = true;
            // 
            // radioIncome
            // 
            this.radioIncome.AutoSize = true;
            this.radioIncome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIncome.Location = new System.Drawing.Point(122, 86);
            this.radioIncome.Name = "radioIncome";
            this.radioIncome.Size = new System.Drawing.Size(86, 25);
            this.radioIncome.TabIndex = 1;
            this.radioIncome.Text = "Income";
            this.radioIncome.UseVisualStyleBackColor = true;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(122, 33);
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
            this.lblName.Location = new System.Drawing.Point(19, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(19, 100);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // btnAddType
            // 
            this.btnAddType.AutoSize = true;
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(133, 176);
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
            this.grpAddType.Controls.Add(this.radioExpense);
            this.grpAddType.Controls.Add(this.lblType);
            this.grpAddType.Controls.Add(this.radioIncome);
            this.grpAddType.Controls.Add(this.txtTypeName);
            this.grpAddType.Location = new System.Drawing.Point(12, 12);
            this.grpAddType.Name = "grpAddType";
            this.grpAddType.Size = new System.Drawing.Size(244, 236);
            this.grpAddType.TabIndex = 6;
            this.grpAddType.TabStop = false;
            this.grpAddType.Text = "Add Type";
            // 
            // grpDeleteIncomeType
            // 
            this.grpDeleteIncomeType.Controls.Add(this.listIncomeTypes);
            this.grpDeleteIncomeType.Controls.Add(this.btnDeleteIncomeType);
            this.grpDeleteIncomeType.Location = new System.Drawing.Point(275, 12);
            this.grpDeleteIncomeType.Name = "grpDeleteIncomeType";
            this.grpDeleteIncomeType.Size = new System.Drawing.Size(244, 236);
            this.grpDeleteIncomeType.TabIndex = 7;
            this.grpDeleteIncomeType.TabStop = false;
            this.grpDeleteIncomeType.Text = "Delete Income Type";
            // 
            // listIncomeTypes
            // 
            this.listIncomeTypes.FormattingEnabled = true;
            this.listIncomeTypes.Location = new System.Drawing.Point(23, 33);
            this.listIncomeTypes.Name = "listIncomeTypes";
            this.listIncomeTypes.Size = new System.Drawing.Size(192, 134);
            this.listIncomeTypes.TabIndex = 6;
            // 
            // btnDeleteIncomeType
            // 
            this.btnDeleteIncomeType.AutoSize = true;
            this.btnDeleteIncomeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncomeType.Location = new System.Drawing.Point(128, 176);
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
            this.groupBox1.Location = new System.Drawing.Point(538, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Expense Type";
            // 
            // listExpenseTypes
            // 
            this.listExpenseTypes.FormattingEnabled = true;
            this.listExpenseTypes.Location = new System.Drawing.Point(23, 33);
            this.listExpenseTypes.Name = "listExpenseTypes";
            this.listExpenseTypes.Size = new System.Drawing.Size(192, 134);
            this.listExpenseTypes.TabIndex = 6;
            // 
            // btnDeleteExpenseType
            // 
            this.btnDeleteExpenseType.AutoSize = true;
            this.btnDeleteExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpenseType.Location = new System.Drawing.Point(128, 176);
            this.btnDeleteExpenseType.Name = "btnDeleteExpenseType";
            this.btnDeleteExpenseType.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteExpenseType.TabIndex = 5;
            this.btnDeleteExpenseType.Text = "Delete";
            this.btnDeleteExpenseType.UseVisualStyleBackColor = true;
            this.btnDeleteExpenseType.Click += new System.EventHandler(this.BtnDeleteExpenseType_Click);
            // 
            // FormManageTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(794, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDeleteIncomeType);
            this.Controls.Add(this.grpAddType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormManageTypes";
            this.Text = "Manage Types";
            this.grpAddType.ResumeLayout(false);
            this.grpAddType.PerformLayout();
            this.grpDeleteIncomeType.ResumeLayout(false);
            this.grpDeleteIncomeType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.GroupBox grpAddType;
        private System.Windows.Forms.GroupBox grpDeleteIncomeType;
        private System.Windows.Forms.ListBox listIncomeTypes;
        private System.Windows.Forms.Button btnDeleteIncomeType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listExpenseTypes;
        private System.Windows.Forms.Button btnDeleteExpenseType;
    }
}