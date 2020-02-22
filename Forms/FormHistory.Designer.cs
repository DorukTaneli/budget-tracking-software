namespace BudgetTrackingSoftware
{
    partial class FormHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridExpenses = new System.Windows.Forms.DataGridView();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblIncomes = new System.Windows.Forms.Label();
            this.dataGridIncomes = new System.Windows.Forms.DataGridView();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnDeleteIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExpenses
            // 
            this.dataGridExpenses.AllowUserToAddRows = false;
            this.dataGridExpenses.AllowUserToDeleteRows = false;
            this.dataGridExpenses.AllowUserToResizeColumns = false;
            this.dataGridExpenses.AllowUserToResizeRows = false;
            this.dataGridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridExpenses.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpenses.Location = new System.Drawing.Point(377, 32);
            this.dataGridExpenses.MultiSelect = false;
            this.dataGridExpenses.Name = "dataGridExpenses";
            this.dataGridExpenses.ReadOnly = true;
            this.dataGridExpenses.RowHeadersVisible = false;
            this.dataGridExpenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpenses.Size = new System.Drawing.Size(337, 359);
            this.dataGridExpenses.TabIndex = 0;
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(411, 9);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(79, 20);
            this.lblExpenses.TabIndex = 2;
            this.lblExpenses.Text = "Expenses";
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomes.Location = new System.Drawing.Point(27, 9);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(70, 20);
            this.lblIncomes.TabIndex = 3;
            this.lblIncomes.Text = "Incomes";
            // 
            // dataGridIncomes
            // 
            this.dataGridIncomes.AllowUserToAddRows = false;
            this.dataGridIncomes.AllowUserToDeleteRows = false;
            this.dataGridIncomes.AllowUserToResizeColumns = false;
            this.dataGridIncomes.AllowUserToResizeRows = false;
            this.dataGridIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridIncomes.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIncomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIncomes.Location = new System.Drawing.Point(12, 32);
            this.dataGridIncomes.MultiSelect = false;
            this.dataGridIncomes.Name = "dataGridIncomes";
            this.dataGridIncomes.ReadOnly = true;
            this.dataGridIncomes.RowHeadersVisible = false;
            this.dataGridIncomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridIncomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIncomes.Size = new System.Drawing.Size(337, 359);
            this.dataGridIncomes.TabIndex = 1;
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.AutoSize = true;
            this.btnDeleteExpense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.Location = new System.Drawing.Point(458, 412);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(199, 30);
            this.btnDeleteExpense.TabIndex = 4;
            this.btnDeleteExpense.Text = "Delete Selected Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.BtnDeleteExpense_Click);
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.AutoSize = true;
            this.btnDeleteIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIncome.Location = new System.Drawing.Point(75, 412);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(190, 30);
            this.btnDeleteIncome.TabIndex = 5;
            this.btnDeleteIncome.Text = "Delete Selected Income";
            this.btnDeleteIncome.UseVisualStyleBackColor = true;
            this.btnDeleteIncome.Click += new System.EventHandler(this.BtnDeleteIncome_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(726, 461);
            this.Controls.Add(this.btnDeleteIncome);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.lblIncomes);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.dataGridIncomes);
            this.Controls.Add(this.dataGridExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHistory";
            this.Text = "Budget Tracking Software";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExpenses;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblIncomes;
        private System.Windows.Forms.DataGridView dataGridIncomes;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnDeleteIncome;
    }
}