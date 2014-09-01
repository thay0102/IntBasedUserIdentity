using IntBasedIdentityUser.Models.Roles;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IntBasedIdentityUser.Models.Users
{
    public class User : IdentityUser<int, UserLogin, UserRole, UserClaim>
    {

    }
}