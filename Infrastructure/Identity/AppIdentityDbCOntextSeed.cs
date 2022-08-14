using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbCOntextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {

            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bob",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                    Address = new Address
                    {
                        FirstName = "Bob",
                        LastName = "Bobotty",
                        Street = "New York",
                        City="NY",
                        State = "NY",
                        Zipcode = "411017"
                    }

                };
                await userManager.CreateAsync(user, "Pass@word3939");
            }

            
        }
    }
}