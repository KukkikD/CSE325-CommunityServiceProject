using CSE325_CommunityServiceProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CSE325_CommunityServiceProject.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<ServiceOpportunity> ServiceOpportunities { get; set; }
    public DbSet<ServiceTask> ServiceTasks { get; set; }

    public DbSet<VolunteerSignup> VolunteerSignups { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<VolunteerSignup>()
            .HasIndex(v => new { v.VolunteerUserId, v.ServiceTaskId })
            .IsUnique();
    }
}
