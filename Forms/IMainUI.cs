using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    public interface IMainUI
    {
        void AddExpenseControls();
        void AddIncomeControls();
        void UpdateBalance();
        void UpdateCharts();
        void UpdateExpenseControls();
        void UpdateIncomeControls();
        void UpdateUI();
        void Close();
    }

}
