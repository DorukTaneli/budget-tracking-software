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
    public partial class FormManageTypesCorporate : Form
    {
        #region Members
        private readonly DomainController dc;
        private readonly FormMainCorporate fm;
        private readonly int UserID;
        #endregion

        #region Initialization
        public FormManageTypesCorporate(DomainController dc, int userID, FormMainCorporate fm)
        {
            InitializeComponent();
            this.dc = dc;
            this.UserID = userID;
            this.fm = fm;
            UpdateCategoryListBoxs();
            listExpenseCategories2.SelectedIndex = -1;
        }
        #endregion

        #region Events
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            string incexp;

            if (radioCategoryExpense.Checked)
                incexp = "Expense";
            else if (radioCategoryIncome.Checked)
                incexp = "Income";
            else
            {
                MessageBox.Show("Please Select Type");
                return;
            }

            dc.AddCategory(txtCategoryName.Text, incexp, UserID);

            UpdateCategoryListBoxs();
            fm.UpdateExpenseControls();
            fm.UpdateIncomeControls();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            if (listIncomeCategories2.SelectedItems.Count > 0)
            {
                dc.AddTypetoCategory(txtTypeName.Text, "Income", listIncomeCategories2.Text, UserID);
                fm.UpdateIncomeTypeControls();
                UpdateListIncomeTypes();
            }
            else if (listExpenseCategories2.SelectedItems.Count > 0)
            {
                dc.AddTypetoCategory(txtTypeName.Text, "Expense", listExpenseCategories2.Text, UserID);
                fm.UpdateExpenseTypeControls();
                UpdateListExpenseTypes();
            }
            else
            {
                MessageBox.Show("Please Select Category");
                return;
            }
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
            UpdateListExpenseTypes();
            fm.UpdateUI();
        }

        private void BtnDeleteIncomeCategory_Click(object sender, EventArgs e)
        {
            if (DBMethods.TypeOfIncomeCategoryExists(listIncomeCategories.Text, UserID))
            {
                DialogResult result = MessageBox.Show("This action will also delete types and incomes of the selected category. Do you wish to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBMethods.DeleteTypesAndIncomesofIncomeCategory(listIncomeCategories.Text, UserID);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            DBMethods.DeleteIncomeCategory(listIncomeCategories.Text, UserID);
            UpdateCategoryListBoxs();
            fm.UpdateUI();
        }

        private void BtnDeleteExpenseCategory_Click(object sender, EventArgs e)
        {
            if (DBMethods.TypeOfExpenseCategoryExists(listExpenseCategories.Text, UserID))
            {
                DialogResult result = MessageBox.Show("This action will also delete types and expenses of the selected category. Do you wish to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBMethods.DeleteTypesAndExpensesofExpenseCategory(listExpenseCategories.Text, UserID);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            DBMethods.DeleteExpenseCategory(listExpenseCategories.Text, UserID);
            UpdateCategoryListBoxs();
            fm.UpdateUI();
        }

        private void BtnDeleteIncomeType_Click(object sender, EventArgs e)
        {
            if (DBMethods.IncomeOfTypeExists(listIncomeTypes.Text, UserID))
            {
                DialogResult result = MessageBox.Show("This action will also delete recorded incomes of the selected type. Do you wish to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBMethods.DeleteIncomesOfType(listIncomeTypes.Text, UserID);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            DBMethods.DeleteIncomeType(listIncomeTypes.Text, UserID);
            UpdateListIncomeTypes();
            fm.UpdateUI();
        }

        private void ListExpenseCategories2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListExpenseTypes();
        }

        private void ListIncomeCategories2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListIncomeTypes();
        }

        private void ListIncomeCategories2_MouseClick(object sender, MouseEventArgs e)
        {
            listExpenseCategories2.SelectedIndex = -1;
        }

        private void ListExpenseCategories2_MouseClick(object sender, MouseEventArgs e)
        {
            listIncomeCategories2.SelectedIndex = -1;
        }
        #endregion

        #region Private Methods
        private void UpdateCategoryListBoxs()
        {
            List<String> inc1 = DBMethods.GetIncomeCats(UserID);
            List<String> exp1 = DBMethods.GetExpenseCats(UserID);
            List<String> inc2 = DBMethods.GetIncomeCats(UserID);
            List<String> exp2 = DBMethods.GetExpenseCats(UserID);

            listIncomeCategories.DataSource = inc1;
            listIncomeCategories2.DataSource = inc2;
            listExpenseCategories.DataSource = exp1;
            listExpenseCategories2.DataSource = exp2;
        }

        private void UpdateListExpenseTypes()
        {
            listExpenseTypes.DataSource = DBMethods.GetExpenseTypesOfCat(listExpenseCategories2.Text, UserID);
        }

        private void UpdateListIncomeTypes()
        {
            listIncomeTypes.DataSource = DBMethods.GetIncomeTypesOfCat(listIncomeCategories2.Text, UserID);
        }
        #endregion
    }
}
