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
    public partial class FormExchangeRates : Form
    {
        #region Members
        private readonly ApiHelper _ApiHelper = new ApiHelper();
        #endregion

        #region Initialization
        public FormExchangeRates()
        {
            InitializeComponent();
            _ApiHelper.RefreshRates();
            PopulateGrid();
        }
        #endregion

        #region Events
        private void BtnShowLatest_Click(object sender, EventArgs e)
        {
            dataGridExchange.Rows.Clear();
            _ApiHelper.RefreshRates();
            PopulateGrid();
        }

        private void BtnShowSelected_Click(object sender, EventArgs e)
        {
            dataGridExchange.Rows.Clear();
            _ApiHelper.GetRates(dateTimePicker.Value);
            PopulateGrid();
        }
        #endregion

        #region Private Methods
        private void PopulateGrid()
        {
            dataGridExchange.Rows.Add("USD", Math.Round(1 / _ApiHelper.MyExRates.rates.USD, 4));
            dataGridExchange.Rows.Add("EUR", Math.Round(1 / _ApiHelper.MyExRates.rates.EUR, 4));
            dataGridExchange.Rows.Add("GBP", Math.Round(1 / _ApiHelper.MyExRates.rates.GBP, 4));
            dataGridExchange.Rows.Add("AUD", Math.Round(1 / _ApiHelper.MyExRates.rates.AUD, 4));
            dataGridExchange.Rows.Add("CHF", Math.Round(1 / _ApiHelper.MyExRates.rates.CHF, 4));
            dataGridExchange.Rows.Add("CAD", Math.Round(1 / _ApiHelper.MyExRates.rates.CAD, 4));
        }
        #endregion
    }
}
