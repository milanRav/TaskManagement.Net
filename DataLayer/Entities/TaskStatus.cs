using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("TaskStatus")]
    public class TaskStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskStatusID { get; set; }

        [Required(ErrorMessage ="StatusName is required")]
        public string TaskStatusName { get; set; }


        public ICollection<Task> Tasks { get; set; }
    }
}
