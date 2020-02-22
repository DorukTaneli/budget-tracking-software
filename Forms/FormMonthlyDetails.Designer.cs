namespace BudgetTrackingSoftware.Forms
{
    partial class FormMonthlyDetails
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthYearPicker = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dataGridIncomes = new System.Windows.Forms.DataGridView();
            this.dataGridExpenses = new System.Windows.Forms.DataGridView();
            this.lblIncomes = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthYearPicker
            // 
            this.MonthYearPicker.CustomFormat = "MM/yyyy";
            this.MonthYearPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYearPicker.Location = new System.Drawing.Point(593, 26);
            this.MonthYearPicker.Name = "MonthYearPicker";
            this.MonthYearPicker.ShowUpDown = true;
            this.MonthYearPicker.Size = new System.Drawing.Size(96, 26);
            this.MonthYearPicker.TabIndex = 70;
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(604, 58);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 71;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // chartExpenses
            // 
            this.chartExpenses.BackColor = System.Drawing.Color.Transparent;
            this.chartExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartExpenses.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartExpenses.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(12, 12);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "ExpenseData";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(237, 239);
            this.chartExpenses.TabIndex = 72;
            this.chartExpenses.Text = "chart1";
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(286, 50);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(252, 37);
            this.lblBalanceText.TabIndex = 73;
            this.lblBalanceText.Text = "Monthly Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(286, 117);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(231, 108);
            this.lblBalance.TabIndex = 74;
            this.lblBalance.Text = "0.00";
            // 
            // dataGridIncomes
            // 
            this.dataGridIncomes.AllowUserToAddRows = false;
            this.dataGridIncomes.AllowUserToDeleteRows = false;
            this.dataGridIncomes.AllowUserToResizeRows = false;
            this.dataGridIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIncomes.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIncomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIncomes.Location = new System.Drawing.Point(25, 285);
            this.dataGridIncomes.MultiSelect = false;
            this.dataGridIncomes.Name = "dataGridIncomes";
            this.dataGridIncomes.ReadOnly = true;
            this.dataGridIncomes.RowHeadersVisible = false;
            this.dataGridIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIncomes.Size = new System.Drawing.Size(313, 203);
            this.dataGridIncomes.TabIndex = 75;
            // 
            // dataGridExpenses
            // 
            this.dataGridExpenses.AllowUserToAddRows = false;
            this.dataGridExpenses.AllowUserToDeleteRows = false;
            this.dataGridExpenses.AllowUserToResizeRows = false;
            this.dataGridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExpenses.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpenses.Location = new System.Drawing.Point(392, 285);
            this.dataGridExpenses.MultiSelect = false;
            this.dataGridExpenses.Name = "dataGridExpenses";
            this.dataGridExpenses.ReadOnly = true;
            this.dataGridExpenses.RowHeadersVisible = false;
            this.dataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpenses.Size = new System.Drawing.Size(313, 203);
            this.dataGridExpenses.TabIndex = 76;
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomes.Location = new System.Drawing.Point(39, 254);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(70, 20);
            this.lblIncomes.TabIndex = 77;
            this.lblIncomes.Text = "Incomes";
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(404, 254);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(79, 20);
            this.lblExpenses.TabIndex = 78;
            this.lblExpenses.Text = "Expenses";
            // 
            // FormMonthlyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(731, 515);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblIncomes);
            this.Controls.Add(this.dataGridExpenses);
            this.Controls.Add(this.dataGridIncomes);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.MonthYearPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMonthlyDetails";
            this.Text = "Monthly Details";
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker MonthYearPicker;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dataGridIncomes;
        private System.Windows.Forms.DataGridView dataGridExpenses;
        private System.Windows.Forms.Label lblIncomes;
        private System.Windows.Forms.Label lblExpenses;
    }
}