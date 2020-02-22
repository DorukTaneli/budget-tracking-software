namespace BudgetTrackingSoftware.Forms
{
    partial class FormManageEmployees
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBoxAddEmployee = new System.Windows.Forms.GroupBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxRemoveEmployee = new System.Windows.Forms.GroupBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBoxAddEmployee.SuspendLayout();
            this.groupBoxRemoveEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(38, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // groupBoxAddEmployee
            // 
            this.groupBoxAddEmployee.Controls.Add(this.listBoxUsers);
            this.groupBoxAddEmployee.Controls.Add(this.btnAdd);
            this.groupBoxAddEmployee.Controls.Add(this.lblSearch);
            this.groupBoxAddEmployee.Controls.Add(this.txtSearch);
            this.groupBoxAddEmployee.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddEmployee.Name = "groupBoxAddEmployee";
            this.groupBoxAddEmployee.Size = new System.Drawing.Size(235, 288);
            this.groupBoxAddEmployee.TabIndex = 2;
            this.groupBoxAddEmployee.TabStop = false;
            this.groupBoxAddEmployee.Text = "Add Employee";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(28, 89);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(179, 134);
            this.listBoxUsers.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBoxRemoveEmployee
            // 
            this.groupBoxRemoveEmployee.Controls.Add(this.listBoxEmployees);
            this.groupBoxRemoveEmployee.Controls.Add(this.btnRemove);
            this.groupBoxRemoveEmployee.Location = new System.Drawing.Point(278, 12);
            this.groupBoxRemoveEmployee.Name = "groupBoxRemoveEmployee";
            this.groupBoxRemoveEmployee.Size = new System.Drawing.Size(235, 288);
            this.groupBoxRemoveEmployee.TabIndex = 4;
            this.groupBoxRemoveEmployee.TabStop = false;
            this.groupBoxRemoveEmployee.Text = "Remove Employee";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(28, 53);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(179, 173);
            this.listBoxEmployees.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(132, 247);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // FormManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(525, 310);
            this.Controls.Add(this.groupBoxRemoveEmployee);
            this.Controls.Add(this.groupBoxAddEmployee);
            this.Name = "FormManageEmployees";
            this.Text = "Manage Employees";
            this.groupBoxAddEmployee.ResumeLayout(false);
            this.groupBoxAddEmployee.PerformLayout();
            this.groupBoxRemoveEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBoxAddEmployee;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxRemoveEmployee;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button btnRemove;
    }
}