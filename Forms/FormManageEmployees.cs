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
    public partial class FormManageEmployees : Form
    {
        #region Members
        private readonly int UserID;
        private readonly FormMainCorporate fmc;
        #endregion

        #region Initialization
        public FormManageEmployees(int userID, FormMainCorporate fmc)
        {
            InitializeComponent();
            this.UserID = userID;
            this.fmc = fmc;
            InitializeListBoxUsers();
            UpdateListBoxEmployee();
        }
        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int employeeID = DBMethods.GetUserID(listBoxUsers.Text);
            DBMethods.AddEmployee(UserID, employeeID);
            UpdateListBoxEmployee();
            fmc.UpdateEmployees();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<String> searchResult = DBMethods.NoncorporateUsernamesThatContain(txtSearch.Text);
            listBoxUsers.DataSource = searchResult;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int employeeID = DBMethods.GetUserID(listBoxEmployees.Text);
            DBMethods.RemoveEmployee(UserID, employeeID);
            UpdateListBoxEmployee();
            fmc.UpdateEmployees();
        }
        #endregion

        #region Private Methods
        private void InitializeListBoxUsers()
        {
            listBoxUsers.DataSource = DBMethods.NoncorporateUsernamesThatContain("");
        }

        private void UpdateListBoxEmployee()
        {
            listBoxEmployees.DataSource = DBMethods.GetEmployeeNames(UserID);
        }
        #endregion

    }
}
