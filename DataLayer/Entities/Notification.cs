using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("Notification")]
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationID { get; set; }
        public int TaskCount { get; set; }
        public int MessageGroupCount { get; set; }
        public int DirectMessageCount { get; set; }
        public int ProjectCount { get; set; }
        public int CommentCount {get;set;}

        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual AppUser User { get; set; }
    }
}
