using Microsoft.EntityFrameworkCore;

namespace ProgressivePulseGrp.Models
{
    public partial class HatuaGrpDbContext : DbContext
    {
        public HatuaGrpDbContext()
        {
        }

        public HatuaGrpDbContext(DbContextOptions<HatuaGrpDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserPrivilege> UserPrivileges { get; set; }
        public virtual DbSet<UserAssignedGroup> UserAssignedGroups { get; set; }
    }
}
