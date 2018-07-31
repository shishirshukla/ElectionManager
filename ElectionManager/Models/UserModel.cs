using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionManager.Models
{
    public class User : IdentityUser
    {
        [MaxLength(36)]
        public override string Id { get; set; }
        public String FullName { get; set; }
        public int CapabilityLevel { get; set; }
        public int GroupId { get; set; }
        public String Bio { get; set; }
        public String ProfilePicture { get; set; }
        public String MobileNumber { get; set; }
        public String MappedDevice { get; set; }
        public String NotificationId { get; set; }
        public DateTime? DateofBirth { get; set; }
        public DateTime? Joined { get; set; }

    }
    public class UserLogin
    {
        public String UserName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
    public class UserRegister
    {
        public String FullName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
