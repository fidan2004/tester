using Microsoft.EntityFrameworkCore;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts
{
    public partial class KallesDbContext {
        
        public DbSet<KallesRole> Roles { get; set; }
        public DbSet<KallesRoleClaim> RoleClaims { get; set; }
        public DbSet<KallesUser> Users{ get; set; }
        public DbSet<KallesUserClaim> UserClaims{ get; set; }
        public DbSet<KallesUserLogin> UserLogins{ get; set; }
        public DbSet<KallesUserRole> UserRoles{ get; set; }
        public DbSet<KallesUserToken> UserTokens{ get; set; }

    }
}
