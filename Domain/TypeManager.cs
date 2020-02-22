using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    static class TypeManager
    {
        #region Public Methods
        public static void AddType(string name, string type, int userID)
        {
            if (type == "Expense")
                DBMethods.AddExpenseType(name, userID);
            else if (type == "Income")
                DBMethods.AddIncomeType(name, userID);
            else
                throw new ArgumentException("Invalid Type");
        }

        public static void AddTypetoCategory(string name, string incexp, string cat, int userID)
        {
            if (incexp == "Expense")
                DBMethods.AddExpenseTypetoCategory(name, userID, cat);
            else if (incexp == "Income")
                DBMethods.AddIncomeTypetoCategory(name, userID, cat);
            else
                throw new ArgumentException("Invalid Type");
        }
        #endregion

        #region Internal Methods
        internal static void DeleteExpenseType(string etName, int userID)
        {
            DBMethods.DeleteExpenseType(etName, userID);
        }

        internal static void DeleteIncomeType(string itName, int userID)
        {
            DBMethods.DeleteIncomeType(itName, userID);
        }

        internal static void AddCategory(string name, string incexp, int userID)
        {
            if (incexp == "Expense")
                DBMethods.AddExpenseCategory(name, userID);
            else if (incexp == "Income")
                DBMethods.AddIncomeCategory(name, userID);
            else
                throw new ArgumentException("Invalid Type");
        }
        #endregion
    }
}
