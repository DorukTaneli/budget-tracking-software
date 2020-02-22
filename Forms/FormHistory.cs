using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackingSoftware
{
    public partial class FormHistory : Form
    {
        #region Members
        private int UserID { get; set; }
        public static Boolean _Instance = false;
        private readonly IMainUI _MainUI;
        #endregion

        #region Initialization
        public FormHistory(int userID, IMainUI fm)
        {
            InitializeComponent();
            this.UserID = userID;
            UpdateDataGrids();
            _Instance = true;
            this._MainUI = fm;
        }
        #endregion

        #region Events
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _Instance = false;
        }

        private void BtnDeleteExpense_Click(object sender, EventArgs e)
        {
            int id = (int) dataGridExpenses.SelectedRows[0].Cells["ExpenseID"].Value;
            DBMethods.DeleteExpense(id);
            UpdateDataGrids();
            _MainUI.UpdateBalance();
            _MainUI.UpdateCharts(); 
        }

        private void BtnDeleteIncome_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridIncomes.SelectedRows[0].Cells["IncomeID"].Value;
            DBMethods.DeleteIncome(id);
            UpdateDataGrids();
            _MainUI.UpdateBalance();
            _MainUI.UpdateCharts();
        }
        #endregion

        #region Public Methods
        public void UpdateDataGrids()
        {
            dataGridExpenses.DataSource = DBMethods.GetExpenseHistory(UserID);
            dataGridIncomes.DataSource = DBMethods.GetIncomeHistory(UserID);
        }
        #endregion

    }
}
