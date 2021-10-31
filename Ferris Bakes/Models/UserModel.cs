using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Ferris_Bakes.Models
{
    public class UserModel : IdentityUser
    {
        public UserModel() : base()
        {

        }

        public UserModel(string username) : base(username)
        {

        }

        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<BackendUserRole> UserRoles { get; set; }
    }

    public class BackendRole : IdentityRole
    {
        public virtual ICollection<BackendUserRole> UserRoles { get; set; }

        public BackendRole() : base()
        { 
        }

        public BackendRole(string roleName) : base(roleName)
        {
        }
    }

    public class BackendUserRole : IdentityUserRole<string>
    {
        public virtual UserModel User { get; set; }
        public virtual BackendRole Role { get; set; }
    }

}
