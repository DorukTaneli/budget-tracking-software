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
    public partial class FormCreateAccount : Form
    {
        #region Members
        private readonly DomainController _DomainController;
        #endregion

        #region Initialization
        public FormCreateAccount(DomainController domainController)
        {
            this._DomainController = domainController;
            InitializeComponent();
        }
        #endregion

        #region Events
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Please enter Username");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter Password");
                return;
            }

            string userType = panelAccountTypes.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked).Text;

            if (txtPass.Text == txtRptPass.Text)
            {
                if(_DomainController.CreateAccount(txtUser.Text, txtPass.Text, userType) == 0)
                {
                    MessageBox.Show("Username is already on use, please try another one");
                } else
                {
                    MessageBox.Show("Account Created!");
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
        }
        #endregion
    }
}
