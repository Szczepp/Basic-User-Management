using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Task_3_v5.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string Status { get; set; }
    }
}
