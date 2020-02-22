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
    public partial class FormLogin : Form
    {
        #region Methods
        private readonly DomainController _DomainController;
        #endregion

        #region Initialization
        public FormLogin(DomainController domainController)
        {
            this._DomainController = domainController;
            InitializeComponent();
        }
        #endregion

        #region Events
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void LinklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                FormCreateAccount formCreateAccount = new FormCreateAccount(_DomainController);
                formCreateAccount.Show();
            }
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryLogin();
        }
        #endregion

        #region Private Methods
        private void TryLogin()
        {
            int login = DBMethods.TryLogin(txtUser.Text, txtPass.Text);
            int userID = DBMethods.GetUserID(txtUser.Text);

            if (login == 0) //login failed
            {
                MessageBox.Show("Wrong username or password");
            }
            else //login successful
            {
                this.Hide();
                if (login == 3) //corporate
                {
                    FormMainCorporate f = new FormMainCorporate(userID, _DomainController);
                    f.Show();
                }
                else //not corporate
                {
                    FormMain formMain = new FormMain(userID, _DomainController);
                    formMain.Show();
                    if (login == 1) //admin 
                    {
                        FormAdmin formAdmin = new FormAdmin(_DomainController, formMain);
                        formAdmin.Show();
                    }
                }
            }
        }
        #endregion

    }
}
