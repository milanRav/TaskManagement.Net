using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("UserProject")]
    public class UserProject
    {
        [Key]
        [ForeignKey("User")]
        public string UserID { get; set; }

        [Key]
        [ForeignKey("Project")]
        public int ProjectID { get; set; }

        public bool IsTeamLead { get; set; }

        
        public virtual AppUser User { get; set; }
        public virtual Project Project { get; set; }
    }
}
