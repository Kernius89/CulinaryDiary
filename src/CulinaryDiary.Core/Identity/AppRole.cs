using Microsoft.AspNetCore.Identity;

namespace CulinaryDiary.Core.Identity
{
    public class AppRole : IdentityRole<Guid>
    {
        public ICollection<AppUserRole>? UserRoles { get; set; }
    }
}