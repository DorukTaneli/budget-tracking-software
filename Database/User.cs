using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class User
    {
        public int UserID { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual User Employer { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
    }
}
