using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BudgetTrackingSoftware.Database;

namespace BudgetTrackingSoftware
{
    public class BudgetContext : DbContext
    {

        #region Members
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        #endregion

        #region Initialization
        public BudgetContext() : base("BudgetDB8")
        {
            System.Data.Entity.Database.SetInitializer<BudgetContext>(new DropCreateDatabaseIfModelChanges<BudgetContext>());
        }
        #endregion

    }

}
