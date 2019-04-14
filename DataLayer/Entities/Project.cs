using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [Required(ErrorMessage ="ProjectName is required")]
        public string ProjectName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        [ForeignKey("ProjectStatus")]
        public int ProjectStatusID { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }

        public ICollection<UserProject> UserProjects { get; set; }
    }
}
