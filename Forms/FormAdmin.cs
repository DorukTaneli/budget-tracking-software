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
    public partial class FormAdmin : Form
    {
        #region Members
        readonly private DomainController _DomainController;
        private IMainUI _MainUI;
        #endregion

        #region Initialization
        public FormAdmin(DomainController domainController, FormMain fm)
        {
            this._DomainController = domainController;
            this._MainUI = fm;
            InitializeComponent();
            UpdateList();
        }
        #endregion

        #region Events
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
                Application.Exit();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            _MainUI.Close();

            int userID = DBMethods.GetUserID(listUsers.Text);

            if (DBMethods.GetAccountType(userID) == "Corporate")
            {
                FormMainCorporate f = new FormMainCorporate(userID, _DomainController);
                f.Show();
                _MainUI = f;
            }
            else
            {
                FormMain f = new FormMain(userID, _DomainController);
                f.Show();
                _MainUI = f;
            }
        }
        #endregion

        #region Public Methods
        public void UpdateList()
        {
            listUsers.DataSource = DBMethods.GetUserNames();
        }
        #endregion

    }
}
