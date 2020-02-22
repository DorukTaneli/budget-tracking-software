namespace BudgetTrackingSoftware
{
    partial class FormMainCorporate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIncomeInfo = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.flowLayoutExpenseTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutIncomeTypes = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioTotal = new System.Windows.Forms.RadioButton();
            this.radioToDate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutExpenseCat = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutIncomeCat = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chartCategoryExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryExpenses)).BeginInit();
            this.SuspendLayout();
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
            this.chartExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(218, 39);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "ExpenseData";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(220, 220);
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
            this.lblIncomeInfo.Location = new System.Drawing.Point(215, 495);
            this.lblIncomeInfo.Name = "lblIncomeInfo";
            this.lblIncomeInfo.Size = new System.Drawing.Size(92, 20);
            this.lblIncomeInfo.TabIndex = 12;
            this.lblIncomeInfo.Text = "Select Type";
            this.lblIncomeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(432, 53);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(132, 37);
            this.lblBalanceText.TabIndex = 16;
            this.lblBalanceText.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(444, 117);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(231, 108);
            this.lblBalance.TabIndex = 37;
            this.lblBalance.Text = "0.00";
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(694, 29);
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
            this.btnExchange.Location = new System.Drawing.Point(694, 63);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(139, 28);
            this.btnExchange.TabIndex = 64;
            this.btnExchange.Text = "View Exchange Rates";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // flowLayoutExpenseTypes
            // 
            this.flowLayoutExpenseTypes.AutoScroll = true;
            this.flowLayoutExpenseTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutExpenseTypes.Location = new System.Drawing.Point(288, 521);
            this.flowLayoutExpenseTypes.Name = "flowLayoutExpenseTypes";
            this.flowLayoutExpenseTypes.Size = new System.Drawing.Size(263, 186);
            this.flowLayoutExpenseTypes.TabIndex = 65;
            // 
            // flowLayoutIncomeTypes
            // 
            this.flowLayoutIncomeTypes.AutoScroll = true;
            this.flowLayoutIncomeTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutIncomeTypes.Location = new System.Drawing.Point(45, 521);
            this.flowLayoutIncomeTypes.Name = "flowLayoutIncomeTypes";
            this.flowLayoutIncomeTypes.Size = new System.Drawing.Size(178, 186);
            this.flowLayoutIncomeTypes.TabIndex = 66;
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
            this.label1.Location = new System.Drawing.Point(664, 498);
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
            this.panel1.Location = new System.Drawing.Point(605, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 186);
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
            this.picManageTypes.Location = new System.Drawing.Point(529, 276);
            this.picManageTypes.Name = "picManageTypes";
            this.picManageTypes.Size = new System.Drawing.Size(48, 48);
            this.picManageTypes.TabIndex = 13;
            this.picManageTypes.TabStop = false;
            this.toolTip1.SetToolTip(this.picManageTypes, "Manage Types");
            this.picManageTypes.Click += new System.EventHandler(this.PicManageTypes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BudgetTrackingSoftware.Properties.Resources.icons8_settings_48;
            this.pictureBox1.Location = new System.Drawing.Point(802, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Manage Employees");
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
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
            this.panel2.Location = new System.Drawing.Point(570, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 47);
            this.panel2.TabIndex = 77;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(648, 327);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(148, 147);
            this.listBoxEmployees.TabIndex = 78;
            this.listBoxEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxEmployees_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "paid to Employee?";
            // 
            // flowLayoutExpenseCat
            // 
            this.flowLayoutExpenseCat.AutoScroll = true;
            this.flowLayoutExpenseCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutExpenseCat.Location = new System.Drawing.Point(288, 327);
            this.flowLayoutExpenseCat.Name = "flowLayoutExpenseCat";
            this.flowLayoutExpenseCat.Size = new System.Drawing.Size(263, 147);
            this.flowLayoutExpenseCat.TabIndex = 66;
            // 
            // flowLayoutIncomeCat
            // 
            this.flowLayoutIncomeCat.AutoScroll = true;
            this.flowLayoutIncomeCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutIncomeCat.Location = new System.Drawing.Point(45, 327);
            this.flowLayoutIncomeCat.Name = "flowLayoutIncomeCat";
            this.flowLayoutIncomeCat.Size = new System.Drawing.Size(178, 147);
            this.flowLayoutIncomeCat.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Select Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Income";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Expense";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chartCategoryExpenses
            // 
            this.chartCategoryExpenses.BackColor = System.Drawing.Color.Transparent;
            this.chartCategoryExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartCategoryExpenses.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartCategoryExpenses.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea2.Name = "ChartArea1";
            this.chartCategoryExpenses.ChartAreas.Add(chartArea2);
            this.chartCategoryExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartCategoryExpenses.Legends.Add(legend2);
            this.chartCategoryExpenses.Location = new System.Drawing.Point(3, 39);
            this.chartCategoryExpenses.Name = "chartCategoryExpenses";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "ExpenseData";
            this.chartCategoryExpenses.Series.Add(series2);
            this.chartCategoryExpenses.Size = new System.Drawing.Size(220, 220);
            this.chartCategoryExpenses.TabIndex = 84;
            this.chartCategoryExpenses.Text = "chartCategoryExpenses";
            // 
            // FormMainCorporate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(881, 729);
            this.Controls.Add(this.chartCategoryExpenses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutIncomeCat);
            this.Controls.Add(this.flowLayoutExpenseCat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.flowLayoutIncomeTypes);
            this.Controls.Add(this.flowLayoutExpenseTypes);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.picManageTypes);
            this.Controls.Add(this.lblIncomeInfo);
            this.Controls.Add(this.chartExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainCorporate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Budget Tracking Software";
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Label lblIncomeInfo;
        private System.Windows.Forms.PictureBox picManageTypes;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutExpenseTypes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutIncomeTypes;
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
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutExpenseCat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutIncomeCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryExpenses;
    }
}