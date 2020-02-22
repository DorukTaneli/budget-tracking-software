using BudgetTrackingSoftware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackingSoftware
{
    public partial class FormMain : Form, IMainUI
    {
        #region Members
        private readonly DomainController _DomainController;
        private FormHistory _FormHistory;
        private int UserID { get; set; }
        #endregion

        #region Initialization
        public FormMain(int userID, DomainController domainController)
        {
            this._DomainController = domainController;
            this.UserID = userID;
            InitializeComponent();
            InitializeUI();
            lblUsername.Text = DBMethods.GetUser(userID).UserName;
        }
        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddIncomeOrExpense();
        }
        private void BtnExchange_Click(object sender, EventArgs e)
        {
            Boolean isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Exchange Rates")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                FormExchangeRates f1 = new FormExchangeRates();
                f1.Show();
            }
        }
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            if (!FormHistory._Instance)
            {
                _FormHistory = new FormHistory(UserID, this);
                _FormHistory.UpdateDataGrids();
                _FormHistory.Show();
            }
        }
        private void ChartExpenses_Click(object sender, EventArgs e)
        {
            Boolean isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Monthly Details")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                FormMonthlyDetails f = new FormMonthlyDetails(UserID);
                f.Show();
            }
        }
        private void ExpenseTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = flowLayoutIncomes.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (selected != null)
                selected.Checked = false;
        }
        private void IncomeTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = flowLayoutExpenses.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);

            if (selected != null)
                selected.Checked = false;
        }
        private void NumAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddIncomeOrExpense();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Boolean isAdmin = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Admin Panel")
                {
                    isAdmin = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isAdmin)
                Application.Exit();
        }
        private void PicManageTypes_Click(object sender, EventArgs e)
        {
            Boolean isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Create Account")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                FormManageTypes f = new FormManageTypes(_DomainController, UserID, this);
                f.Show();
            }
        }
        private void RadioToDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBalance();
        }
        private void RadioTotal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBalance();
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Adds Expense Radio Buttons to UI
        /// </summary>
        public void AddExpenseControls()
        {
            List<string> ExpenseTypes = DBMethods.GetExpenseTypeNames(UserID);

            foreach (string e in ExpenseTypes)
            {
                AddExpenseTypeRadiotoUI(e);
            }
        }

        /// <summary>
        /// Adds expense radio button for given type
        /// </summary>
        /// <param name="eType">Expense Type String</param>
        public void AddExpenseTypeRadiotoUI(string eType)
        {
            RadioButton radio = new RadioButton
            {
                Name = "radio" + eType,
                Text = eType,
                Size = new System.Drawing.Size(80, 35),
                Appearance = System.Windows.Forms.Appearance.Button,
                UseVisualStyleBackColor = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            radio.CheckedChanged += new System.EventHandler(this.ExpenseTypeRadio_CheckedChanged);
            flowLayoutExpenses.Controls.Add(radio);
        }

        /// <summary>
        /// Adds Income Radio Buttons to UI
        /// </summary>
        public void AddIncomeControls()
        {
            List<string> IncomeTypes = DBMethods.GetIncomeTypeNames(UserID);

            foreach (string i in IncomeTypes)
            {
                AddIncomeTypeRadiotoUI(i);
            }
        }

        /// <summary>
        /// Adds expense radio button for given type
        /// </summary>
        /// <param name="iType">Income Type String</param>
        public void AddIncomeTypeRadiotoUI(string iType)
        {
            RadioButton radio = new RadioButton
            {
                Name = "radio" + iType,
                Text = iType,
                Size = new System.Drawing.Size(80, 35),
                Appearance = System.Windows.Forms.Appearance.Button,
                UseVisualStyleBackColor = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            radio.CheckedChanged += new System.EventHandler(this.IncomeTypeRadio_CheckedChanged);
            flowLayoutIncomes.Controls.Add(radio);
        }

        /// <summary>
        /// Initialize UI
        /// </summary>
        public void InitializeUI()
        {
            UpdateFormHistory();
            UpdateBalance();
            UpdateCharts();
            AddExpenseControls();
            AddIncomeControls();
        }

        /// <summary>
        /// Clear all expense radio buttons
        /// </summary>
        public void RemoveExpenseControls()
        {
            List<Control> controls = flowLayoutExpenses.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutExpenses.Controls.Remove(c);
                c.Dispose();
            }
        }

        /// <summary>
        /// Clear all income radio buttons
        /// </summary>
        public void RemoveIncomeControls()
        {
            List<Control> controls = flowLayoutIncomes.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutIncomes.Controls.Remove(c);
                c.Dispose();
            }
        }

        public void UpdateBalance()
        {
            if (radioTotal.Checked)
            {
                decimal balance = DBMethods.CalculateBalance(UserID);
                lblBalance.Text = balance.ToString();
            }
            else if (radioToDate.Checked)
            {
                decimal balance = DBMethods.CalculateBalanceToDate(UserID);
                lblBalance.Text = balance.ToString();
            }
            else
            {
                lblBalance.Text = "How?";
            }
        }

        public void UpdateCharts()
        {
            Dictionary<String, decimal> ExpenseDict = DBMethods.GetExpenseData(UserID);

            chartExpenses.Series["ExpenseData"].Points.DataBindXY(ExpenseDict.Keys, ExpenseDict.Values);
        }

        /// <summary>
        /// Update Expense Radio Buttons
        /// </summary>
        public void UpdateExpenseControls()
        {
            RemoveExpenseControls();
            AddExpenseControls();
        }

        public void UpdateFormHistory()
        {
            if (_FormHistory != null)
                _FormHistory.UpdateDataGrids();
        }

        /// <summary>
        /// Update Income Radio Buttons
        /// </summary>
        public void UpdateIncomeControls()
        {
            RemoveIncomeControls();
            AddIncomeControls();
        }

        /// <summary>
        /// Update all UI components
        /// </summary>
        public void UpdateUI()
        {
            UpdateFormHistory();
            UpdateBalance();
            UpdateCharts();
            UpdateExpenseControls();
            UpdateIncomeControls();
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Method to use for clicking enter or add button
        /// </summary>
        private void AddIncomeOrExpense()
        {
            RadioButton selectedExp = flowLayoutExpenses.Controls.OfType<RadioButton>()
                        .FirstOrDefault(r => r.Checked);

            RadioButton selectedInc = flowLayoutIncomes.Controls.OfType<RadioButton>()
                        .FirstOrDefault(r => r.Checked);

            if (selectedExp == null && selectedInc == null)
            {
                MessageBox.Show("Please select a type");
                return;
            }

            int recur = (int)numRecur.Value;

            if (recur > 1 && comboBoxRecur.Text == "")
            {
                MessageBox.Show("Please select recurring interval");
                return;
            }


            if (selectedExp != null)
            {
                string eType = selectedExp.Text;

                DBMethods.AddExpense(numAmount.Value, eType, UserID, dateTimeExpInc.Value);

                if (recur > 1)
                    DBMethods.AddRecurringExpense(recur, comboBoxRecur.Text, numAmount.Value, eType, UserID, dateTimeExpInc.Value);

                MessageBox.Show("Expense added!");

            }
            else if (selectedInc != null)
            {
                string iType = selectedInc.Text;

                DBMethods.AddIncome(numAmount.Value, iType, UserID, dateTimeExpInc.Value);

                if (recur > 1)
                    DBMethods.AddRecurringIncome(recur, comboBoxRecur.Text, numAmount.Value, iType, UserID, dateTimeExpInc.Value);

                MessageBox.Show("Income added!");
            }

            UpdateFormHistory();
            UpdateBalance();
            UpdateCharts();
        }
        #endregion

    }

}
