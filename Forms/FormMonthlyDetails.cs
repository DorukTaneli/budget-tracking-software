using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackingSoftware.Forms
{
    public partial class FormMonthlyDetails : Form
    {
        #region Members
        public int UserID { get; set; }
        #endregion

        #region Initialization
        public FormMonthlyDetails(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            UpdateChart();
            UpdateDataGrids();
            UpdateBalance();
        }
        #endregion

        #region Events
        private void BtnView_Click(object sender, EventArgs e)
        {
            UpdateChart();
            UpdateDataGrids();
            UpdateBalance();
        }
        #endregion

        #region Private Methods
        private void UpdateChart()
        {
            Dictionary<String, decimal> ExpenseDict = DBMethods.GetExpenseDictionary(UserID, MonthYearPicker.Value);

            chartExpenses.Series["ExpenseData"].Points.DataBindXY(ExpenseDict.Keys, ExpenseDict.Values);
        }

        private void UpdateDataGrids()
        {
            dataGridExpenses.DataSource = DBMethods.GetExpenseHistory(UserID, MonthYearPicker.Value);
            dataGridIncomes.DataSource = DBMethods.GetIncomeHistory(UserID, MonthYearPicker.Value);
        }

        private void UpdateBalance()
        {
            decimal balance = DBMethods.CalculateBalanceTotal(UserID, MonthYearPicker.Value);
            lblBalance.Text = balance.ToString();
        }
        #endregion
    }
}
