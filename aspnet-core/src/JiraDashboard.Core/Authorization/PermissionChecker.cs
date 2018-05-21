using Abp.Authorization;
using JiraDashboard.Authorization.Roles;
using JiraDashboard.Authorization.Users;

namespace JiraDashboard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
