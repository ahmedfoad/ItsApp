using Abp.Authorization;
using ItsApp.Authorization.Roles;
using ItsApp.Authorization.Users;

namespace ItsApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
