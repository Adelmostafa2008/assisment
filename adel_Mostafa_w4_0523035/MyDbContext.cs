using adel_Mostafa_w4_0523035.Models;
using Microsoft.EntityFrameworkCore;

namespace adel_Mostafa_w4_0523035
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder mo)
        {
            base.OnModelCreating(mo);
            mo.Entity<Project>().
                HasMany(x => x.tasks).
                WithOne(x => x.project).
                HasForeignKey(x => x.p_id).
                OnDelete(DeleteBehavior.Cascade);
            mo.Entity<TeamMember>().
                HasMany(x => x.tasks).
                WithOne(x => x.teammember).
                HasForeignKey(x => x.tm_id).
                OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Tasks> tasks { get; set; }
        public DbSet<TeamMember> teamMembers { get; set; }
        public DbSet<Project> projects { get; set; }

    }
}
