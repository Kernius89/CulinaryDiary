using CulinaryDiary.Core.Identity;
using CulinaryDiary.Infrastructure.DatabaseConfiguration;
using Microsoft.AspNetCore.Identity;

namespace CulinaryDiary.Api.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentityCore<AppUser>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 8;
            })
                .AddRoles<AppRole>()
                .AddRoleManager<RoleManager<AppRole>>()
                .AddEntityFrameworkStores<DataContext>();

            return services;
        }
    }
}