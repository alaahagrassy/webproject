using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace Graduation_project3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; internal set; }
        public string Birthday { get; set; }
        public string Address { get; internal set; }
        public BloodType Blood_Type { get; internal set; }
        public bool Diseases { get; internal set; }
        public string Medicines { get; internal set; }
        public string Last_Donation { get; internal set; }
        public bool Donator_Thto_Us { get; internal set; }
        public string Image_Path { get; internal set; }
        public bool requests { get; internal set; }
        public string Response { get; internal set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Graduation_project3.Models.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<Graduation_project3.Models.Submit> Submits { get; set; }
    }
}