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
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<CustomerUserRole> UserRoles { get; set; }
    }

    public class CustomerRole : IdentityRole
    {
        public virtual ICollection<CustomerUserRole> UserRoles { get; set; }

        public CustomerRole() : base()
        { 
        }

        public CustomerRole(string roleName) : base(roleName)
        {
        }
    }

    public class CustomerUserRole : IdentityUserRole<string>
    {
        public virtual UserModel User { get; set; }
        public virtual CustomerRole Role { get; set; }
    }

}
