using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    public class DomainController
    {
        #region Internal Methods

        /// <summary>
        /// Delegate Account Creation to AccountCreator
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        internal int CreateAccount(string username, string password, string userType)
        {
            int toReturn = AccountCreator.CreateAccount(username, password, userType);

            return toReturn;
        }

        internal void InitializeDatabase()
        {
            InitializeUserTypes();
            InitializeUsers();
        }

        internal void InitializeUserTypes()
        {
            DBMethods.AddUserType("Admin");
            DBMethods.AddUserType("User");
            DBMethods.AddUserType("Corporate");
        }

        internal void AddType(string name, string type, int userID)
        {
            TypeManager.AddType(name, type, userID);
        }

        internal void AddTypetoCategory(string name, string incexp, string cat, int userID)
        {
            TypeManager.AddTypetoCategory(name, incexp, cat, userID);
        }

        internal void DeleteExpenseType(string etName, int userID)
        {
            TypeManager.DeleteExpenseType(etName, userID);
        }

        internal void DeleteIncomeType(string itName, int userID)
        {
            TypeManager.DeleteIncomeType(itName, userID);
        }

        internal void InitializeUsers()
        {
            CreateAccount("admin", "123", "Admin");
            CreateAccount("user1", "asd", "User");
            CreateAccount("user2", "asd", "User");
            CreateAccount("corp1", "asd", "Corporate");
            CreateAccount("corp2", "asd", "Corporate");
        }

        internal void AddCategory(string name, string incexp, int userID)
        {
            TypeManager.AddCategory(name, incexp, userID);
        }
#endregion
    }
}
