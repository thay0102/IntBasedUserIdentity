using IntBasedIdentityUser.Models.Roles;
using IntBasedIdentityUser.Models.Users;

using Microsoft.AspNet.Identity.EntityFramework;

namespace IntBasedIdentityUser.Context
{
    public class ApplicationContext : 
        IdentityDbContext<User, Role, int, UserLogin, UserRole, UserClaim>
    {

    }
}