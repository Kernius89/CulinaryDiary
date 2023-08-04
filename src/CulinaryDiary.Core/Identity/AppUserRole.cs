using Microsoft.AspNetCore.Identity;

namespace CulinaryDiary.Core.Identity
{
    public class AppUserRole : IdentityUserRole<Guid>
    {
        public AppUser? AppUser { get; set; }
        public AppRole? AppRole { get; set; }
    }
}