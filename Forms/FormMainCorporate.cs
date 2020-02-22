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
    public partial class FormMainCorporate : Form, IMainUI
    {
        #region Members
        private readonly DomainController _DomainController;
        private FormHistory formHistory;
        public int UserID { get; set; }
        #endregion

        #region Initialization
        public FormMainCorporate(int userID, DomainController domainController)
        {
            this._DomainController = domainController;
            this.UserID = userID;
            InitializeComponent();
            InitializeUI();
            lblUsername.Text = DBMethods.GetUser(userID).UserName;
            listBoxEmployees.SelectedIndex = -1;
        }
        #endregion

        #region Events
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
                formHistory = new FormHistory(UserID, this);
                formHistory.UpdateDataGrids();
                formHistory.Show();
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

        private void ExpenseCatRadio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpenseTypeControls();
        }

        private void ExpenseTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = flowLayoutIncomeTypes.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (selected != null)
                selected.Checked = false;
        }

        private void IncomeCatRadio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateIncomeTypeControls();
        }

        private void IncomeTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = flowLayoutExpenseTypes.Controls.OfType<RadioButton>()
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
                FormManageTypesCorporate f = new FormManageTypesCorporate(_DomainController, UserID, this);
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Boolean isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Manage Employees")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!isOpen)
            {
                FormManageEmployees f = new FormManageEmployees(UserID, this);
                f.Show();
            }
        }

        private void ListBoxEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            int index = listBoxEmployees.IndexFromPoint(pt);

            if (index <= -1)
            {
                listBoxEmployees.SelectedItems.Clear();
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Adds Expense Cattegory Radio Buttons to UI
        /// </summary>
        public void AddExpenseControls()
        {
            List<string> Cats = DBMethods.GetExpenseCats(UserID);

            foreach (string c in Cats)
            {
                AddExpenseCatRadiotoUI(c);
            }
        }

        /// <summary>
        /// Add expense types radio buttons of given category
        /// </summary>
        /// <param name="eCat"></param>
        public void AddExpenseTypeControls(string eCat)
        {
            List<string> ExpenseTypes = DBMethods.GetExpenseTypesOfCat(eCat, UserID);

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
            flowLayoutExpenseTypes.Controls.Add(radio);
        }

        /// <summary>
        /// Adds Income Radio Buttons to UI
        /// </summary>
        public void AddIncomeControls()
        {
            List<string> Cats = DBMethods.GetIncomeCats(UserID);

            foreach (string c in Cats)
            {
                AddIncomeCatRadiotoUI(c);
            }
        }

        /// <summary>
        /// Add income types radio buttons of given category
        /// </summary>
        /// <param name="iCat"></param>
        public void AddIncomeTypeControls(string iCat)
        {
            List<string> IncomeTypes = DBMethods.GetIncomeTypesOfCat(iCat, UserID);

            foreach (string i in IncomeTypes)
            {
                AddIncomeTypeRadiotoUI(i);
            }
        }

        /// <summary>
        /// Adds income radio button for given type
        /// </summary>
        /// <param name="iType">Expense Type String</param>
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
            flowLayoutIncomeTypes.Controls.Add(radio);
        }

        public void InitializeUI()
        {
            UpdateFormHistory();
            UpdateBalance();
            UpdateCharts();
            AddExpenseControls();
            AddIncomeControls();
            UpdateEmployees();
        }

        /// <summary>
        /// Clear all expense category radio buttons
        /// </summary>
        public void RemoveExpenseControls()
        {
            List<Control> controls = flowLayoutExpenseCat.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutExpenseCat.Controls.Remove(c);
                c.Dispose();
            }
        }

        /// <summary>
        /// Clear all expense type radio buttons
        /// </summary>
        public void RemoveExpenseTypeControls()
        {
            List<Control> controls = flowLayoutExpenseTypes.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutExpenseTypes.Controls.Remove(c);
                c.Dispose();
            }
        }

        /// <summary>
        /// Clear all income category radio buttons
        /// </summary>
        public void RemoveIncomeControls()
        {
            List<Control> controls = flowLayoutIncomeCat.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutIncomeCat.Controls.Remove(c);
                c.Dispose();
            }
        }

        /// <summary>
        /// Clear all income type radio buttons
        /// </summary>
        public void RemoveIncomeTypeControls()
        {
            List<Control> controls = flowLayoutIncomeTypes.Controls.Cast<Control>().ToList();

            foreach (Control c in controls)
            {
                flowLayoutIncomeTypes.Controls.Remove(c);
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

            Dictionary<String, decimal> CategoryDict = DBMethods.GetCategoryExpenseDictionary(UserID);

            chartCategoryExpenses.Series["ExpenseData"].Points.DataBindXY(CategoryDict.Keys, CategoryDict.Values);
        }

        /// <summary>
        /// Update expense categories
        /// </summary>
        public void UpdateExpenseControls()
        {
            RemoveExpenseControls();
            AddExpenseControls();
        }

        /// <summary>
        /// update expense types
        /// </summary>
        public void UpdateExpenseTypeControls()
        {
            RadioButton selected = flowLayoutExpenseCat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            RemoveExpenseTypeControls();
            if (selected != null)
                AddExpenseTypeControls(selected.Text);
        }

        public void UpdateFormHistory()
        {
            if (formHistory != null)
                formHistory.UpdateDataGrids();
        }

        /// <summary>
        /// update income categories
        /// </summary>
        public void UpdateIncomeControls()
        {
            RemoveIncomeControls();
            AddIncomeControls();
        }

        /// <summary>
        /// update income types
        /// </summary>
        public void UpdateIncomeTypeControls()
        {
            RadioButton selected = flowLayoutIncomeCat.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);
            RemoveIncomeTypeControls();
            if (selected != null)
                AddIncomeTypeControls(selected.Text);
        }

        /// <summary>
        /// Update All UI
        /// </summary>
        public void UpdateUI()
        {
            UpdateFormHistory();
            UpdateBalance();
            UpdateCharts();
            UpdateExpenseControls();
            UpdateIncomeControls();
            UpdateExpenseTypeControls();
            UpdateIncomeTypeControls();

        }

        /// <summary>
        /// update employee listbox
        /// </summary>
        public void UpdateEmployees()
        {
            listBoxEmployees.DataSource = DBMethods.GetEmployeeNames(UserID);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Add Expense Category Radio Buttons to Main UI
        /// </summary>
        /// <param name="cat">category name</param>
        private void AddExpenseCatRadiotoUI(string cat)
        {
            RadioButton radio = new RadioButton
            {
                Name = "radio" + cat,
                Text = cat,
                Size = new System.Drawing.Size(80, 35),
                Appearance = System.Windows.Forms.Appearance.Button,
                UseVisualStyleBackColor = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            radio.CheckedChanged += new System.EventHandler(this.ExpenseCatRadio_CheckedChanged);
            flowLayoutExpenseCat.Controls.Add(radio);
        }

        /// <summary>
        /// Add Income Category Radio Buttons to Main UI
        /// </summary>
        /// <param name="cat">category name</param>
        private void AddIncomeCatRadiotoUI(string cat)
        {
            RadioButton radio = new RadioButton
            {
                Name = "radio" + cat,
                Text = cat,
                Size = new System.Drawing.Size(80, 35),
                Appearance = System.Windows.Forms.Appearance.Button,
                UseVisualStyleBackColor = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            radio.CheckedChanged += new System.EventHandler(this.IncomeCatRadio_CheckedChanged);
            flowLayoutIncomeCat.Controls.Add(radio);
        }

        /// <summary>
        /// Method to use for clicking enter or add button
        /// </summary>
        private void AddIncomeOrExpense()
        {
            RadioButton selectedExp = flowLayoutExpenseTypes.Controls.OfType<RadioButton>()
                        .FirstOrDefault(r => r.Checked);

            RadioButton selectedInc = flowLayoutIncomeTypes.Controls.OfType<RadioButton>()
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

                if (listBoxEmployees.SelectedIndex != -1)
                {
                    int employeeID = DBMethods.GetUserID(listBoxEmployees.Text);
                    DBMethods.AddAsIncomeToEmployee(numAmount.Value, UserID, employeeID, dateTimeExpInc.Value);
                }

                if (recur > 1)
                {
                    DBMethods.AddRecurringExpense(recur, comboBoxRecur.Text, numAmount.Value, eType, UserID, dateTimeExpInc.Value);

                    if (listBoxEmployees.SelectedIndex != -1)
                    {
                        int employeeID = DBMethods.GetUserID(listBoxEmployees.Text);
                        DBMethods.AddAsRecurringIncomeToEmployee(recur, comboBoxRecur.Text, numAmount.Value, UserID, employeeID, dateTimeExpInc.Value);
                    }
                }

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
