using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware.Database
{
    public class UserType
    {
        public int UserTypeID { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string UserTypeName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
