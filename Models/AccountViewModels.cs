using System;
using System.Collections.Generic;

namespace Graduation_project3.Models
{
    // Models returned by AccountController actions.

    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    public class UserProfileViewModel
    {
        public string Email { get; set; }

        public bool HasRegistered { get; set; }

        public string LoginProvider { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }

        public string Address { get; set; }
        public BloodType Blood_Type { get; set; }
        public bool Diseases { get; set; }
        public string Medicines { get; set; }
        public string Last_Donation { get; set; }
        public string PhoneNumber { get; set; }
        public string Image_Path { get; set; }
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}
