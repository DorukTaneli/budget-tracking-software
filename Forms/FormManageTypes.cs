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
    public partial class FormManageTypes : Form
    {
        #region Members
        private readonly DomainController dc;
        private readonly int UserID;
        private readonly IMainUI formMain;
        #endregion

        #region Initialization
        public FormManageTypes(DomainController dc, int userID, IMainUI formMain)
        {
            InitializeComponent();
            this.dc = dc;
            this.UserID = userID;
            this.formMain = formMain;
            PopulateListBoxs();
        }
        #endregion

        #region Events
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            string type;

            if (radioExpense.Checked)
                type = "Expense";
            else if (radioIncome.Checked)
                type = "Income";
            else {
                MessageBox.Show("Please Select Type");
                return;
            }

            dc.AddType(txtTypeName.Text, type, UserID);

            UpdateListBoxs();
            formMain.UpdateExpenseControls();
            formMain.UpdateIncomeControls();
        }

        private void BtnDeleteExpenseType_Click(object sender, EventArgs e)
        {
            if (DBMethods.ExpenseOfTypeExists(listExpenseTypes.Text, UserID))
            {
                DialogResult result = MessageBox.Show("This action will also delete recorded expenses of the selected type. Do you wish to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBMethods.DeleteExpensesOfType(listExpenseTypes.Text, UserID);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            dc.DeleteExpenseType(listExpenseTypes.Text, UserID);
            UpdateListBoxs();
            formMain.UpdateUI();
        }

        private void BtnDeleteIncomeType_Click(object sender, EventArgs e)
        {
            if (DBMethods.IncomeOfTypeExists(listExpenseTypes.Text, UserID))
            {
                DialogResult result = MessageBox.Show("This action will also delete recorded incomes of the selected type. Do you wish to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBMethods.DeleteIncomesOfType(listExpenseTypes.Text, UserID);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            dc.DeleteIncomeType(listIncomeTypes.Text, UserID);
            UpdateListBoxs();
            formMain.UpdateUI();
        }
        #endregion

        #region Private Methods
        private void UpdateListBoxs()
        {
            ClearListBoxs();
            PopulateListBoxs();
        }

        private void PopulateListBoxs()
        {
            foreach (string e in DBMethods.GetExpenseTypeNames(UserID))
            {
                listExpenseTypes.Items.Add(e);
            }

            foreach (string i in DBMethods.GetIncomeTypeNames(UserID))
            {
                listIncomeTypes.Items.Add(i);
            }
        }

        private void ClearListBoxs()
        {
            listExpenseTypes.Items.Clear();
            listIncomeTypes.Items.Clear();
        }

        #endregion

    }
}
