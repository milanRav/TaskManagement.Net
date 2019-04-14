using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }


        public Notification Notification { get; set; }
        [InverseProperty("UserTo")]
        public ICollection<Message> MessagesTo { get; set; }
        [InverseProperty("UserFrom")]
        public ICollection<Message> MessagesFrom { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
