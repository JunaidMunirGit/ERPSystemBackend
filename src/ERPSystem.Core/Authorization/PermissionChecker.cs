using Abp.Authorization;
using ERPSystem.Authorization.Roles;
using ERPSystem.Authorization.Users;

namespace ERPSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
