using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }

        [Required(ErrorMessage ="Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "DateTime is required")]
        public DateTime DateTime { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public virtual AppUser User { get; set; }
    }
}
