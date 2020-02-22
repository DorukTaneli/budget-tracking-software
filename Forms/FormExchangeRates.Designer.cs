namespace BudgetTrackingSoftware
{
    partial class FormExchangeRates
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
            this.dataGridExchange = new System.Windows.Forms.DataGridView();
            this.CurrencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnShowLatest = new System.Windows.Forms.Button();
            this.btnShowSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExchange
            // 
            this.dataGridExchange.AllowUserToAddRows = false;
            this.dataGridExchange.AllowUserToDeleteRows = false;
            this.dataGridExchange.AllowUserToResizeColumns = false;
            this.dataGridExchange.AllowUserToResizeRows = false;
            this.dataGridExchange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExchange.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExchange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyColumn,
            this.ValueColumn});
            this.dataGridExchange.Location = new System.Drawing.Point(222, 12);
            this.dataGridExchange.Name = "dataGridExchange";
            this.dataGridExchange.ReadOnly = true;
            this.dataGridExchange.RowHeadersVisible = false;
            this.dataGridExchange.RowHeadersWidth = 4;
            this.dataGridExchange.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridExchange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExchange.Size = new System.Drawing.Size(256, 248);
            this.dataGridExchange.TabIndex = 0;
            // 
            // CurrencyColumn
            // 
            this.CurrencyColumn.HeaderText = "Currency";
            this.CurrencyColumn.Name = "CurrencyColumn";
            this.CurrencyColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // btnShowLatest
            // 
            this.btnShowLatest.Location = new System.Drawing.Point(114, 226);
            this.btnShowLatest.Name = "btnShowLatest";
            this.btnShowLatest.Size = new System.Drawing.Size(93, 23);
            this.btnShowLatest.TabIndex = 2;
            this.btnShowLatest.Text = "Show Latest";
            this.btnShowLatest.UseVisualStyleBackColor = true;
            this.btnShowLatest.Click += new System.EventHandler(this.BtnShowLatest_Click);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(15, 226);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(93, 23);
            this.btnShowSelected.TabIndex = 3;
            this.btnShowSelected.Text = "Show Selected";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.BtnShowSelected_Click);
            // 
            // FormExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(490, 274);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.btnShowLatest);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridExchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormExchangeRates";
            this.Text = "Exchange Rates";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnShowLatest;
        private System.Windows.Forms.Button btnShowSelected;
    }
}