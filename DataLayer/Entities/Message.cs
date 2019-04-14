using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set;}

        [Required(ErrorMessage ="Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage ="DateTime is required")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "IsDm is required")]
        public bool IsDm { get; set; }

        [Required(ErrorMessage = "Seen is required")]
        public bool Seen { get; set; }

        [ForeignKey("UserTo")]
        public string UserToID { get; set; }
        public virtual  AppUser UserTo { get; set; }

        [ForeignKey("UserFrom")]
        public string UserFromID { get; set; }
        public virtual AppUser UserFrom { get; set; }
    }
}
