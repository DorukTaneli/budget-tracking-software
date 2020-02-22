using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class ExpenseType
    {
        public int ExpenseTypeID { get; set; }
        public string ExpenseTypeName { get; set; }

        [ForeignKey("ExpenseCategory")]
        public int ExpenseCategoryID { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
