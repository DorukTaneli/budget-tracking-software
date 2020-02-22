﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class IncomeCategory
    {
        public int IncomeCategoryID { get; set; }
        public string IncomeCategoryName { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<IncomeType> IncomeTypes { get; set; }
    }
}