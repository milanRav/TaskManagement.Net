using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("ProjectStatus")]
    public class ProjectStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectStatusID { get; set; }

        [Required(ErrorMessage = "StatusName is required")]
        public string ProjectStatusName { get; set; }


        public ICollection<Project> Projects { get; set; }

    }
}
