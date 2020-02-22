namespace BudgetTrackingSoftware
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIncomeInfo = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblExpenseInfo = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.flowLayoutExpenses = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutIncomes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeExpInc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRecur = new System.Windows.Forms.ComboBox();
            this.numRecur = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.picManageTypes = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioTotal = new System.Windows.Forms.RadioButton();
            this.radioToDate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTypes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartExpenses
            // 
            this.chartExpenses.BackColor = System.Drawing.Color.Transparent;
            this.chartExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartExpenses.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartExpenses.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea4.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea4);
            this.chartExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend4);
            this.chartExpenses.Location = new System.Drawing.Point(46, 9);
            this.chartExpenses.Name = "chartExpenses";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "ExpenseData";
            this.chartExpenses.Series.Add(series4);
            this.chartExpenses.Size = new System.Drawing.Size(237, 239);
            this.chartExpenses.TabIndex = 0;
            this.chartExpenses.Text = "chart1";
            this.toolTip1.SetToolTip(this.chartExpenses, "View Monthly Details");
            this.chartExpenses.Click += new System.EventHandler(this.ChartExpenses_Click);
            // 
            // lblIncomeInfo
            // 
            this.lblIncomeInfo.AutoSize = true;
            this.lblIncomeInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIncomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeInfo.Location = new System.Drawing.Point(42, 261);
            this.lblIncomeInfo.Name = "lblIncomeInfo";
            this.lblIncomeInfo.Size = new System.Drawing.Size(149, 20);
            this.lblIncomeInfo.TabIndex = 12;
            this.lblIncomeInfo.Text = "Select Income Type";
            this.lblIncomeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(336, 53);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(132, 37);
            this.lblBalanceText.TabIndex = 16;
            this.lblBalanceText.Text = "Balance";
            // 
            // lblExpenseInfo
            // 
            this.lblExpenseInfo.AutoSize = true;
            this.lblExpenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblExpenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseInfo.Location = new System.Drawing.Point(273, 261);
            this.lblExpenseInfo.Name = "lblExpenseInfo";
            this.lblExpenseInfo.Size = new System.Drawing.Size(127, 20);
            this.lblExpenseInfo.TabIndex = 36;
            this.lblExpenseInfo.Text = "or Expense Type";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(341, 107);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(231, 108);
            this.lblBalance.TabIndex = 37;
            this.lblBalance.Text = "0.00";
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(616, 19);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(139, 28);
            this.btnViewHistory.TabIndex = 38;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.BtnViewHistory_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.Location = new System.Drawing.Point(616, 53);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(139, 28);
            this.btnExchange.TabIndex = 64;
            this.btnExchange.Text = "View Exchange Rates";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // flowLayoutExpenses
            // 
            this.flowLayoutExpenses.AutoScroll = true;
            this.flowLayoutExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutExpenses.Location = new System.Drawing.Point(242, 297);
            this.flowLayoutExpenses.Name = "flowLayoutExpenses";
            this.flowLayoutExpenses.Size = new System.Drawing.Size(263, 181);
            this.flowLayoutExpenses.TabIndex = 65;
            // 
            // flowLayoutIncomes
            // 
            this.flowLayoutIncomes.AutoScroll = true;
            this.flowLayoutIncomes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutIncomes.Location = new System.Drawing.Point(30, 297);
            this.flowLayoutIncomes.Name = "flowLayoutIncomes";
            this.flowLayoutIncomes.Size = new System.Drawing.Size(178, 181);
            this.flowLayoutIncomes.TabIndex = 66;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 67;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Select Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimeExpInc
            // 
            this.dateTimeExpInc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpInc.Location = new System.Drawing.Point(116, 13);
            this.dateTimeExpInc.Name = "dateTimeExpInc";
            this.dateTimeExpInc.Size = new System.Drawing.Size(100, 20);
            this.dateTimeExpInc.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBoxRecur);
            this.panel1.Controls.Add(this.numRecur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeExpInc);
            this.panel1.Location = new System.Drawing.Point(537, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 181);
            this.panel1.TabIndex = 74;
            // 
            // comboBoxRecur
            // 
            this.comboBoxRecur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxRecur.FormattingEnabled = true;
            this.comboBoxRecur.Items.AddRange(new object[] {
            "Months",
            "Weeks"});
            this.comboBoxRecur.Location = new System.Drawing.Point(156, 53);
            this.comboBoxRecur.Name = "comboBoxRecur";
            this.comboBoxRecur.Size = new System.Drawing.Size(60, 21);
            this.comboBoxRecur.TabIndex = 81;
            // 
            // numRecur
            // 
            this.numRecur.Location = new System.Drawing.Point(116, 54);
            this.numRecur.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRecur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecur.Name = "numRecur";
            this.numRecur.Size = new System.Drawing.Size(34, 20);
            this.numRecur.TabIndex = 80;
            this.numRecur.ThousandsSeparator = true;
            this.numRecur.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Recurs for:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(116, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(116, 94);
            this.numAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(100, 20);
            this.numAmount.TabIndex = 75;
            this.numAmount.ThousandsSeparator = true;
            this.numAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumAmount_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picManageTypes
            // 
            this.picManageTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picManageTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManageTypes.Image = global::BudgetTrackingSoftware.Properties.Resources.icons8_settings_48;
            this.picManageTypes.Location = new System.Drawing.Point(442, 243);
            this.picManageTypes.Name = "picManageTypes";
            this.picManageTypes.Size = new System.Drawing.Size(48, 48);
            this.picManageTypes.TabIndex = 13;
            this.picManageTypes.TabStop = false;
            this.toolTip1.SetToolTip(this.picManageTypes, "Manage Types");
            this.picManageTypes.Click += new System.EventHandler(this.PicManageTypes_Click);
            // 
            // radioTotal
            // 
            this.radioTotal.AutoSize = true;
            this.radioTotal.Checked = true;
            this.radioTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioTotal.Location = new System.Drawing.Point(3, 3);
            this.radioTotal.Name = "radioTotal";
            this.radioTotal.Size = new System.Drawing.Size(55, 18);
            this.radioTotal.TabIndex = 75;
            this.radioTotal.TabStop = true;
            this.radioTotal.Text = "Total";
            this.radioTotal.UseVisualStyleBackColor = true;
            this.radioTotal.CheckedChanged += new System.EventHandler(this.RadioTotal_CheckedChanged);
            // 
            // radioToDate
            // 
            this.radioToDate.AutoSize = true;
            this.radioToDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioToDate.Location = new System.Drawing.Point(3, 26);
            this.radioToDate.Name = "radioToDate";
            this.radioToDate.Size = new System.Drawing.Size(67, 18);
            this.radioToDate.TabIndex = 76;
            this.radioToDate.Text = "ToDate";
            this.radioToDate.UseVisualStyleBackColor = true;
            this.radioToDate.CheckedChanged += new System.EventHandler(this.RadioToDate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioTotal);
            this.panel2.Controls.Add(this.radioToDate);
            this.panel2.Location = new System.Drawing.Point(474, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 47);
            this.panel2.TabIndex = 77;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.flowLayoutIncomes);
            this.Controls.Add(this.flowLayoutExpenses);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblExpenseInfo);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.picManageTypes);
            this.Controls.Add(this.lblIncomeInfo);
            this.Controls.Add(this.chartExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Budget Tracking Software";
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTypes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Label lblIncomeInfo;
        private System.Windows.Forms.PictureBox picManageTypes;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblExpenseInfo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutExpenses;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutIncomes;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeExpInc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numRecur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRecur;
        private System.Windows.Forms.RadioButton radioTotal;
        private System.Windows.Forms.RadioButton radioToDate;
        private System.Windows.Forms.Panel panel2;
    }
}