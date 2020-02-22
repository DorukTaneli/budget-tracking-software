using BudgetTrackingSoftware.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    static class DBMethods
    {

        #region Internal Methods

        /// <summary>
        /// Adds Expense to User
        /// </summary>
        /// <param name="amount">decimal amount of expense</param>
        /// <param name="eTypeStr">Expense Type</param>
        /// <param name="userID"></param>
        internal static void AddExpense(decimal amount, string eTypeStr, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseTypeName == eTypeStr);
                User usr = ctx.Users.Find(userID);
                ctx.Expenses.Add(new Expense() { Amount = amount, Date = DateTime.Now, ExpenseType = eType, User = usr });
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Adds Expense to User to given date
        /// </summary>
        /// <param name="amount">decimal amount of expense</param>
        /// <param name="eTypeStr">Expense Type</param>
        /// <param name="userID"></param>
        /// <param name="dt">Date of expense</param>
        internal static void AddExpense(decimal amount, string eTypeStr, int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseTypeName == eTypeStr);
                User usr = ctx.Users.Find(userID);
                ctx.Expenses.Add(new Expense() { Amount = amount, Date = dt, ExpenseType = eType, User = usr });
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// returns Admin and User Accounts that contain the given text in their usernames.
        /// </summary>
        /// <param name="text">Text to search</param>
        /// <returns>String list of usernames</returns>
        internal static List<String> NoncorporateUsernamesThatContain(string text)
        {
            using (var ctx = new BudgetContext())
            {
                var users = from u in ctx.Users
                            where u.UserName.Contains(text) && u.UserType.UserTypeName != "Corporate"
                            select u.UserName;
                return users.ToList<String>();
            }
        }


        /// <summary>
        /// Try to Add Expense Category with given name to user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because ExpenseCategory already exists</returns>
        internal static int AddExpenseCategory(string name, int userID)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            using (var ctx = new BudgetContext())
            {
                ExpenseCategory eCat = ctx.ExpenseCategories.FirstOrDefault(ec => ec.ExpenseCategoryName == name && ec.User_ID == userID);

                if (eCat == null)
                {
                    ctx.ExpenseCategories.Add(new ExpenseCategory() { ExpenseCategoryName = nameCaseCorrected, User_ID = userID });
                    ctx.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Try to add Expense Type to "General Expense" Category with given name to user
        /// </summary>
        /// <param name="newETypeName"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because ExpenseType already exists</returns>
        internal static int AddExpenseType(string newETypeName, int userID)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newETypeName.ToLower());
            using (var ctx = new BudgetContext())
            {
                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseTypeName == nameCaseCorrected && et.ExpenseCategory.User_ID == userID);

                ExpenseCategory eCat = ctx.ExpenseCategories.FirstOrDefault(ec => ec.ExpenseCategoryName == "General Expense" && ec.User_ID == userID);

                if (eType == null)
                {
                    ctx.ExpenseTypes.Add(new ExpenseType() { ExpenseTypeName = nameCaseCorrected, ExpenseCategory = eCat });
                    ctx.SaveChanges();
                    return 1;
                }

                return 0;
            }
        }

        /// <summary>
        /// Try to add Expense Type to given Category with given name to user
        /// </summary>
        /// <param name="newETypeName"></param>
        /// <param name="userID"></param>
        /// <param name="cat"></param>
        ///<returns>returns 1 if success, 0 if fail because ExpenseType already exists</returns>
        internal static int AddExpenseTypetoCategory(string newETypeName, int userID, string cat)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newETypeName.ToLower());
            using (var ctx = new BudgetContext())
            {
                Console.WriteLine("\n\n\n\n\n" + cat + "\n\n\n\n\n");

                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseTypeName == nameCaseCorrected && et.ExpenseCategory.User_ID == userID);

                ExpenseCategory eCat = ctx.ExpenseCategories.FirstOrDefault(ec => ec.ExpenseCategoryName == cat && ec.User_ID == userID);

                if (eType == null)
                {
                    ctx.ExpenseTypes.Add(new ExpenseType() { ExpenseTypeName = nameCaseCorrected, ExpenseCategory = eCat });
                    ctx.SaveChanges();
                    return 1;
                }

                return 0;
            }
        }

        /// <summary>
        /// Add Income to user
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="iTypeStr">Income Type Name</param>
        /// <param name="userID"></param>
        internal static void AddIncome(decimal amount, string iTypeStr, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(it => it.IncomeTypeName == iTypeStr);
                User usr = ctx.Users.Find(userID);
                ctx.Incomes.Add(new Income() { Amount = amount, Date = DateTime.Now, IncomeType = iType, User = usr });
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Add income to given date
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="iTypeStr">Income Type Name</param>
        /// <param name="userID"></param>
        /// <param name="dt">Date</param>
        internal static void AddIncome(decimal amount, string iTypeStr, int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(it => it.IncomeTypeName == iTypeStr);
                User usr = ctx.Users.Find(userID);
                ctx.Incomes.Add(new Income() { Amount = amount, Date = dt, IncomeType = iType, User = usr });
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Add income Category with given name to user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because IncomeCategory already exists</returns>
        internal static int AddIncomeCategory(string name, int userID)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            using (var ctx = new BudgetContext())
            {
                IncomeCategory iCat = ctx.IncomeCategories.FirstOrDefault(ic => ic.IncomeCategoryName == name && ic.User_ID == userID);

                if (iCat == null)
                {
                    ctx.IncomeCategories.Add(new IncomeCategory() { IncomeCategoryName = nameCaseCorrected, User_ID = userID });
                    ctx.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Add Income type to "General Income" Category
        /// </summary>
        /// <param name="newETypeName"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because IncomeType already exists</returns>
        internal static int AddIncomeType(string newETypeName, int userID)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newETypeName.ToLower());
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(it => it.IncomeTypeName == nameCaseCorrected && it.IncomeCategory.User_ID == userID);

                IncomeCategory iCat = ctx.IncomeCategories.FirstOrDefault(ic => ic.IncomeCategoryName == "General Income" && ic.User_ID == userID);

                if (iType == null)
                {
                    ctx.IncomeTypes.Add(new IncomeType() { IncomeTypeName = nameCaseCorrected, IncomeCategory = iCat });
                    ctx.SaveChanges();
                    return 1;
                }

                return 0;
            }
        }

        /// <summary>
        /// Adds income type to given category
        /// </summary>
        /// <param name="newETypeName"></param>
        /// <param name="userID"></param>
        /// <param name="cat">Category</param>
        ///<returns>returns 1 if success, 0 if fail because IncomeType already exists</returns>
        internal static int AddIncomeTypetoCategory(string newETypeName, int userID, string cat)
        {
            string nameCaseCorrected = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newETypeName.ToLower());
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(it => it.IncomeTypeName == nameCaseCorrected && it.IncomeCategory.User_ID == userID);

                IncomeCategory iCat = ctx.IncomeCategories.FirstOrDefault(ic => ic.IncomeCategoryName == cat && ic.User_ID == userID);

                if (iType == null)
                {
                    ctx.IncomeTypes.Add(new IncomeType() { IncomeTypeName = nameCaseCorrected, IncomeCategory = iCat });
                    ctx.SaveChanges();
                    return 1;
                }

                return 0;
            }
        }

        /// <summary>
        /// Add recurring Expense
        /// </summary>
        /// <param name="recur"></param>
        /// <param name="interval"></param>
        /// <param name="amount"></param>
        /// <param name="eType"></param>
        /// <param name="userID"></param>
        /// <param name="dt"></param>
        internal static void AddRecurringExpense(int recur, string interval, decimal amount, string eType, int userID, DateTime dt)
        {
            if (interval == "Months")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    DBMethods.AddExpense(amount, eType, userID, dt.AddMonths(toAdd));
                    toAdd++;
                }
            }
            else if (interval == "Weeks")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    DBMethods.AddExpense(amount, eType, userID, dt.AddDays(toAdd * 7));
                    toAdd++;
                }
            }
        }

        /// <summary>
        /// Add recurring Income
        /// </summary>
        /// <param name="recur"></param>
        /// <param name="interval"></param>
        /// <param name="amount"></param>
        /// <param name="iType"></param>
        /// <param name="userID"></param>
        /// <param name="dt"></param>
        internal static void AddRecurringIncome(int recur, string interval, decimal amount, string iType, int userID, DateTime dt)
        {
            if (interval == "Months")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    DBMethods.AddIncome(amount, iType, userID, dt.AddMonths(toAdd));
                    toAdd++;
                }
            }
            else if (interval == "Weeks")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    DBMethods.AddIncome(amount, iType, userID, dt.AddDays(toAdd * 7));
                    toAdd++;
                }
            }
        }

        /// <summary>
        /// Add user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userType"></param>
        ///<returns>returns userID if success, 0 if fail because User already exists</returns>
        internal static int AddUser(string username, string password, string userType)
        {
            using (var ctx = new BudgetContext())
            {
                User user = ctx.Users.FirstOrDefault(u => u.UserName == username);
                UserType type = ctx.UserTypes.FirstOrDefault(u => u.UserTypeName == userType);

                if (user == null)
                {
                    ctx.Users.Add(new User() { UserName = username, Password = password, UserType = type });
                    ctx.SaveChanges();
                    int userID = ctx.Users.FirstOrDefault(u => u.UserName == username).UserID;
                    return userID;
                }
                return 0;
            }
        }

        /// <summary>
        /// Add user Type
        /// </summary>
        /// <param name="str"></param>
        ///<returns>returns 1 if success, 0 if fail because UserType already exists</returns>
        internal static int AddUserType(string str)
        {
            using (var ctx = new BudgetContext())
            {
                UserType type = ctx.UserTypes.FirstOrDefault(u => u.UserTypeName == str);

                if (type == null)
                {
                    ctx.UserTypes.Add(new UserType() { UserTypeName = str });
                    ctx.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }

        /// <summary>
        /// Calculates total balance
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>decimal balance</returns>
        internal static decimal CalculateBalance(int userID)
        {
            return CalculateTotalIncome(userID) - CalculateTotalExpense(userID);
        }

        /// <summary>
        /// Calculates balance till this month
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        internal static decimal CalculateBalanceToDate(int userID)
        {
            return CalculateToDateIncome(userID) - CalculateToDateExpense(userID);
        }

        /// <summary>
        /// Calculates balance of given date's month
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        internal static decimal CalculateBalanceTotal(int userID, DateTime dt)
        {
            return CalculateTotalIncome(userID, dt) - CalculateTotalExpense(userID, dt);
        }

        internal static decimal CalculateToDateExpense(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Expenses.Where(i => i.User.UserID == userID &&
                                            i.Date.CompareTo(DateTime.Now) < 0).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static decimal CalculateToDateIncome(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Incomes.Where(i => i.User.UserID == userID &&
                                            i.Date.CompareTo(DateTime.Now) < 0).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static decimal CalculateTotalExpense(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Expenses.Where(i => i.User.UserID == userID).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static decimal CalculateTotalExpense(int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Expenses.Where(i => i.User.UserID == userID &&
                                            i.Date.Year == dt.Year &&
                                            i.Date.Month == dt.Month).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static decimal CalculateTotalIncome(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Incomes.Where(i => i.User.UserID == userID).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static decimal CalculateTotalIncome(int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Incomes.Where(i => i.User.UserID == userID &&
                                            i.Date.Year == dt.Year &&
                                            i.Date.Month == dt.Month).AsEnumerable().Sum(i => i.Amount);
            }
        }

        internal static void DeleteExpense(int expID)
        {
            using (var ctx = new BudgetContext())
            {
                ctx.Expenses.Remove(ctx.Expenses.Find(expID));
                ctx.SaveChanges();
            }
        }

        internal static void DeleteExpensesOfType(string eType, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                foreach (Expense e in ctx.Expenses)
                {
                    if (e.ExpenseType.ExpenseTypeName == eType && e.User.UserID == userID)
                    {
                        ctx.Expenses.Remove(e);
                    }
                }
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="etName"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because ExpenseType does not exists</returns>
        internal static int DeleteExpenseType(string etName, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseTypeName == etName && et.ExpenseCategory.User_ID == userID);

                if (eType == null)
                    return 0;

                ctx.ExpenseTypes.Remove(eType);
                ctx.SaveChanges();
                return 1;
            }
        }

        internal static void DeleteIncome(int incID)
        {
            using (var ctx = new BudgetContext())
            {
                ctx.Incomes.Remove(ctx.Incomes.Find(incID));
                ctx.SaveChanges();
            }
        }

        internal static void DeleteIncomesOfType(string iType, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                foreach (Income i in ctx.Incomes)
                {
                    if (i.IncomeType.IncomeTypeName == iType && i.User.UserID == userID)
                    {
                        ctx.Incomes.Remove(i);
                    }
                }
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itName"></param>
        /// <param name="userID"></param>
        ///<returns>returns 1 if success, 0 if fail because IncomeType does not exists</returns>
        internal static int DeleteIncomeType(string itName, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(et => et.IncomeTypeName == itName && et.IncomeCategory.User_ID == userID);

                if (iType == null)
                    return 0;

                ctx.IncomeTypes.Remove(iType);
                ctx.SaveChanges();
                return 1;
            }
        }

        internal static void DeleteTypesAndExpensesofExpenseCategory(string catName, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                foreach (ExpenseType et in ctx.ExpenseTypes)
                {
                    if (et.ExpenseCategory.ExpenseCategoryName == catName && et.ExpenseCategory.User_ID == userID)
                    {
                        DeleteExpensesOfType(et.ExpenseTypeName, userID);
                        ctx.ExpenseTypes.Remove(et);
                    }
                }
                ctx.SaveChanges();
            }
        }

        internal static int DeleteIncomeCategory(string name, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeCategory iCat = ctx.IncomeCategories.FirstOrDefault(it => it.IncomeCategoryName == name && it.User_ID == userID);

                if (iCat == null)
                    return 0;

                ctx.IncomeCategories.Remove(iCat);
                ctx.SaveChanges();
                return 1;
            }
        }

        internal static int DeleteExpenseCategory(string name, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                ExpenseCategory eCat = ctx.ExpenseCategories.FirstOrDefault(et => et.ExpenseCategoryName == name && et.User_ID == userID);

                if (eCat == null)
                    return 0;

                ctx.ExpenseCategories.Remove(eCat);
                ctx.SaveChanges();
                return 1;
            }
        }


        internal static void DeleteTypesAndIncomesofIncomeCategory(string catName, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                foreach (IncomeType it in ctx.IncomeTypes)
                {
                    if (it.IncomeCategory.IncomeCategoryName == catName && it.IncomeCategory.User_ID == userID)
                    {
                        DeleteIncomesOfType(it.IncomeTypeName, userID);
                        ctx.IncomeTypes.Remove(it);
                    }
                }
                ctx.SaveChanges();
            }
        }

        internal static bool ExpenseOfTypeExists(string eType, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                Expense exp = ctx.Expenses.FirstOrDefault(e => e.ExpenseType.ExpenseTypeName == eType && e.User.UserID == userID);

                if (exp == null)
                    return false;
                else
                    return true;
            }
        }

        internal static String GetAccountType(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                User u = ctx.Users.Find(userID);
                return u.UserType.UserTypeName;
            }
        }

        internal static List<String> GetEmployeeNames(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from u in ctx.Users
                        where u.Employer.UserID == userID
                        select u.UserName).ToList<String>();
            }
        }

        internal static List<string> GetExpenseCats(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                var exp = from cat in ctx.ExpenseCategories
                          where cat.User_ID == userID
                          select cat.ExpenseCategoryName;

                return exp.ToList<string>();
            }
        }

        internal static Dictionary<string, decimal> GetExpenseData(int userID)
        {
            Dictionary<String, decimal> ExpenseDict = new Dictionary<string, decimal>();

            using (var ctx = new BudgetContext())
            {
                foreach (var expense in ctx.Expenses)
                {
                    if (expense.User.UserID == userID)
                    {
                        if (ExpenseDict.ContainsKey(expense.ExpenseType.ExpenseTypeName))
                        {
                            ExpenseDict[expense.ExpenseType.ExpenseTypeName] += expense.Amount;
                        }
                        else
                        {
                            ExpenseDict[expense.ExpenseType.ExpenseTypeName] = expense.Amount;
                        }
                    }
                }
            }

            return ExpenseDict;
        }

        internal static Dictionary<string, decimal> GetExpenseDictionary(int userID, DateTime dt)
        {
            Dictionary<String, decimal> ExpenseDict = new Dictionary<string, decimal>();

            using (var ctx = new BudgetContext())
            {
                foreach (var expense in ctx.Expenses)
                {
                    if (expense.User.UserID == userID && expense.Date.Year == dt.Year && expense.Date.Month == dt.Month)
                    {
                        if (ExpenseDict.ContainsKey(expense.ExpenseType.ExpenseTypeName))
                        {
                            ExpenseDict[expense.ExpenseType.ExpenseTypeName] += expense.Amount;
                        }
                        else
                        {
                            ExpenseDict[expense.ExpenseType.ExpenseTypeName] = expense.Amount;
                        }
                    }
                }
            }

            return ExpenseDict;
        }

        internal static Dictionary<string, decimal> GetCategoryExpenseDictionary(int userID)
        {
            Dictionary<String, decimal> Dict = new Dictionary<string, decimal>();

            using (var ctx = new BudgetContext())
            {
                foreach (var expense in ctx.Expenses)
                {
                    if (expense.User.UserID == userID)
                    {
                        if (Dict.ContainsKey(expense.ExpenseType.ExpenseCategory.ExpenseCategoryName))
                        {
                            Dict[expense.ExpenseType.ExpenseCategory.ExpenseCategoryName] += expense.Amount;
                        }
                        else
                        {
                            Dict[expense.ExpenseType.ExpenseCategory.ExpenseCategoryName] = expense.Amount;
                        }
                    }
                }
            }

            return Dict;
        }



        internal static List<object> GetExpenseHistory(int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                var exp = from expenses in ctx.Expenses
                          where expenses.User.UserID == userID && expenses.Date.Year == dt.Year &&
                                                                    expenses.Date.Month == dt.Month
                          orderby expenses.Date
                          select new { Date = expenses.Date.ToString(), expenses.Amount, Type = expenses.ExpenseType.ExpenseTypeName, expenses.ExpenseID };

                return exp.ToList<object>();
            }
        }

        internal static List<object> GetExpenseHistory(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                var exp = from expenses in ctx.Expenses
                          where expenses.User.UserID == userID
                          orderby expenses.Date
                          select new { Date = expenses.Date.ToString(), expenses.Amount, Type = expenses.ExpenseType.ExpenseTypeName, expenses.ExpenseID };

                return exp.ToList<object>();
            }
        }

        internal static List<Expense> GetExpensesOfType(string et, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from e in ctx.Expenses
                        where e.ExpenseType.ExpenseTypeName == et && e.User.UserID == userID
                        select e).ToList<Expense>();
            }
        }

        internal static List<string> GetExpenseTypeNames(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from et in ctx.ExpenseTypes
                        where et.ExpenseCategory.User_ID == userID
                        select et.ExpenseTypeName).ToList<string>();
            }
        }

        internal static List<string> GetExpenseTypesOfCat(string eCat, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from et in ctx.ExpenseTypes
                        where et.ExpenseCategory.User_ID == userID && et.ExpenseCategory.ExpenseCategoryName == eCat
                        select et.ExpenseTypeName).ToList<string>();
            }
        }

        internal static List<string> GetIncomeCats(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                var exp = from cat in ctx.IncomeCategories
                          where cat.User_ID == userID
                          select cat.IncomeCategoryName;

                return exp.ToList<string>();
            }
        }

        internal static List<object> GetIncomeHistory(int userID, DateTime dt)
        {
            using (var ctx = new BudgetContext())
            {
                var inc = from incomes in ctx.Incomes
                          where incomes.User.UserID == userID && incomes.Date.Year == dt.Year &&
                                                                    incomes.Date.Month == dt.Month
                          orderby incomes.Date
                          select new { Date = incomes.Date.ToString(), incomes.Amount, Type = incomes.IncomeType.IncomeTypeName, incomes.IncomeID };

                return inc.ToList<object>();
            }
        }

        internal static List<object> GetIncomeHistory(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                var inc = from incomes in ctx.Incomes
                          where incomes.User.UserID == userID
                          orderby incomes.Date
                          select new { Date = incomes.Date.ToString(), incomes.Amount, Type = incomes.IncomeType.IncomeTypeName, incomes.IncomeID };

                return inc.ToList<object>();
            }
        }

        internal static List<Income> GetIncomesOfType(string it, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from i in ctx.Incomes
                        where i.IncomeType.IncomeTypeName == it && i.User.UserID == userID
                        select i).ToList<Income>();
            }
        }

        internal static List<string> GetIncomeTypeNames(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from it in ctx.IncomeTypes
                        where it.IncomeCategory.User_ID == userID
                        select it.IncomeTypeName).ToList<string>();
            }
        }

        internal static List<string> GetIncomeTypesOfCat(string iCat, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return (from it in ctx.IncomeTypes
                        where it.IncomeCategory.User_ID == userID && it.IncomeCategory.IncomeCategoryName == iCat
                        select it.IncomeTypeName).ToList<string>();
            }
        }

        internal static User GetUser(int userID)
        {
            using (var ctx = new BudgetContext())
            {
                return ctx.Users.Find(userID);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        ///<returns>returns 0 if user does not exist</returns>
        internal static int GetUserID(string username)
        {
            using (var ctx = new BudgetContext())
            {
                User usr = ctx.Users.FirstOrDefault(u => u.UserName == username);
                if (usr == null)
                    return 0;
                else
                    return usr.UserID;
            }
        }

        internal static List<String> GetUserNames()
        {
            using (var ctx = new BudgetContext())
            {
                return (from u in ctx.Users
                        select u.UserName)
                       .ToList<String>();
            }
        }

        internal static bool IncomeOfTypeExists(string iType, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                Income inc = ctx.Incomes.FirstOrDefault(i => i.IncomeType.IncomeTypeName == iType && i.User.UserID == userID);

                if (inc == null)
                    return false;
                else
                    return true;
            }
        }
        internal static int TryLogin(string name, string pass)
        {
            using (var ctx = new BudgetContext())
            {
                var usr = ctx.Users.FirstOrDefault(u => u.UserName == name
                                                    && u.Password == pass);
                if (usr == null)
                    return 0;
                else
                    return usr.UserType.UserTypeID;
            }
        }
        internal static bool TypeOfExpenseCategoryExists(string eCat, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                ExpenseType eType = ctx.ExpenseTypes.FirstOrDefault(et => et.ExpenseCategory.ExpenseCategoryName == eCat && et.ExpenseCategory.User_ID == userID);

                if (eType == null)
                    return false;
                else
                    return true;
            }
        }

        internal static bool TypeOfIncomeCategoryExists(string iCat, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeType iType = ctx.IncomeTypes.FirstOrDefault(it => it.IncomeCategory.IncomeCategoryName == iCat && it.IncomeCategory.User_ID == userID);

                if (iType == null)
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employerID"></param>
        /// <param name="employeeID"></param>
        /// <returns>returns 1 if success, 0 if fail because usertypes are not correct</returns>
        internal static int AddEmployee(int employerID, int employeeID)
        {
            using (var ctx = new BudgetContext())
            {
                User Employer = ctx.Users.Find(employerID);
                User Employee = ctx.Users.Find(employeeID);

                if (Employer.UserType.UserTypeName == "Corporate" && Employee.UserType.UserTypeName != "Corporate")
                {
                    Employee.Employer = Employer;
                    ctx.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        internal static void RemoveEmployee(int employerID, int employeeID)
        {
            using (var ctx = new BudgetContext())
            {
                User Employer = ctx.Users.Find(employerID);
                User Employee = ctx.Users.Find(employeeID);

                Employee.Employer = null;
                ctx.SaveChanges();
            }
        }

        internal static Boolean IncomeTypeExists(string typeName, int userID)
        {
            using (var ctx = new BudgetContext())
            {
                IncomeType it = ctx.IncomeTypes.FirstOrDefault(t => t.IncomeTypeName == typeName && t.IncomeCategory.User_ID == userID);

                if (it == null)
                    return false;
                else
                    return true;
            }
        }

        internal static void AddAsIncomeToEmployee(decimal amount, int employerID, int employeeID, DateTime dt)
        {
            string employerName = GetUser(employerID).UserName;

            if (!IncomeTypeExists(employerName, employeeID))
                AddIncomeType(employerName, employeeID);

            AddIncome(amount, employerName, employeeID, dt);
        }

        internal static void AddAsRecurringIncomeToEmployee(int recur, string interval, decimal amount, int employerID, int employeeID, DateTime dt)
        {
            if (interval == "Months")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    AddAsIncomeToEmployee(amount, employerID, employeeID, dt.AddMonths(toAdd));
                    toAdd++;
                }
            }
            else if (interval == "Weeks")
            {
                int toAdd = 1;
                for (int r = recur; r > 1; r--)
                {
                    AddAsIncomeToEmployee(amount, employerID, employeeID, dt.AddDays(toAdd * 7));
                    toAdd++;
                }
            }
        }
#endregion

    }
}
