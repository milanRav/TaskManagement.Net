using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("Task")]
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }

        [Required(ErrorMessage ="TaskName is required")]
        public string TaskName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }


        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual AppUser User { get; set; }

        [ForeignKey("TaskStatus")]
        public int TaskStatusID { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
