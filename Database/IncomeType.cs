using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class IncomeType
    {
        public int IncomeTypeID { get; set; }
        public string IncomeTypeName { get; set; }

        [ForeignKey("IncomeCategory")]
        public int IncomeCategoryID { get; set; }
        public virtual IncomeCategory IncomeCategory { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }
    }

}
