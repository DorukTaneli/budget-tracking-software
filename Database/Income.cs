﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class Income
    {
        public int IncomeID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public virtual User User { get; set; }
        public virtual IncomeType IncomeType { get; set; }
    }
}