using Microsoft.AspNetCore.Identity;

namespace CulinaryDiary.Core.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public ICollection<AppUserRole>? UserRoles { get; set; }
    }
}