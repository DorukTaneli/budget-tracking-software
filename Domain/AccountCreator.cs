using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    static class AccountCreator
    {
        #region InternalMethods
        internal static int CreateAccount(string username, string password, string userType)
        {
            int userID = DBMethods.AddUser(username, password, userType);

            if (userID > 0) //User Added
            {
                AddDefaultCategories(userID);
                AddDefaultExpenseTypes(userID);
                AddDefaultIncomeTypes(userID);
            }

            return userID;
        }
        #endregion

        #region Private Methods
        private static void AddDefaultCategories(int userID)
        {
            if(DBMethods.GetAccountType(userID) == "Corporate")
            {
                DBMethods.AddExpenseCategory("Salaries", userID);
                DBMethods.AddExpenseCategory("Raw Materials", userID);
                DBMethods.AddExpenseCategory("Taxes", userID);
                DBMethods.AddExpenseCategory("Marketing", userID);

                DBMethods.AddIncomeCategory("Domestic Sales", userID);
                DBMethods.AddIncomeCategory("International Sales", userID);
            }
            else
            {
                DBMethods.AddExpenseCategory("General Expense", userID);
                DBMethods.AddIncomeCategory("General Income", userID);
            }
        }

        private static void AddDefaultExpenseTypes(int userID)
        {
            if (DBMethods.GetAccountType(userID) == "Corporate")
            {
                DBMethods.AddExpenseTypetoCategory("User1", userID, "Salaries");
                DBMethods.AddExpenseTypetoCategory("User2", userID, "Salaries");
                DBMethods.AddExpenseTypetoCategory("Flour", userID, "Raw Materials");
                DBMethods.AddExpenseTypetoCategory("Sugar", userID, "Raw Materials");
                DBMethods.AddExpenseTypetoCategory("Cacao", userID, "Raw Materials");
                DBMethods.AddExpenseTypetoCategory("Flour", userID, "Raw Materials");
                DBMethods.AddExpenseTypetoCategory("KDV", userID, "Taxes");
                DBMethods.AddExpenseTypetoCategory("OTV", userID, "Taxes");
                DBMethods.AddExpenseTypetoCategory("TV Ads", userID, "Marketing");
                DBMethods.AddExpenseTypetoCategory("Internet Ads", userID, "Marketing");
                DBMethods.AddExpenseTypetoCategory("Street Posters", userID, "Marketing");
            }
            else
            {
                DBMethods.AddExpenseType("Shopping", userID);
                DBMethods.AddExpenseType("Food", userID);
                DBMethods.AddExpenseType("Transport", userID);
                DBMethods.AddExpenseType("Electric", userID);
                DBMethods.AddExpenseType("Gas", userID);
                DBMethods.AddExpenseType("Home", userID);
                DBMethods.AddExpenseType("Entertainment", userID);
                DBMethods.AddExpenseType("Water", userID);
                DBMethods.AddExpenseType("Health", userID);
                DBMethods.AddExpenseType("Beauty", userID);
                DBMethods.AddExpenseType("Gift", userID);
            }
        }

        private static void AddDefaultIncomeTypes(int userID)
        {
            if (DBMethods.GetAccountType(userID) == "Corporate")
            {
                DBMethods.AddIncomeTypetoCategory("İstanbul", userID, "Domestic Sales");
                DBMethods.AddIncomeTypetoCategory("İzmir", userID, "Domestic Sales");
                DBMethods.AddIncomeTypetoCategory("Ankara", userID, "Domestic Sales");

                DBMethods.AddIncomeTypetoCategory("New York", userID, "International Sales");
                DBMethods.AddIncomeTypetoCategory("Paris", userID, "International Sales");
                DBMethods.AddIncomeTypetoCategory("London", userID, "International Sales");
            }
            else
            {
                DBMethods.AddIncomeType("Salary", userID);
                DBMethods.AddIncomeType("Rent", userID);
                DBMethods.AddIncomeType("Dividents", userID);
            }
        }
        #endregion
    }
}
