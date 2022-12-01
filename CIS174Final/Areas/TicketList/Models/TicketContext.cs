using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CIS174Final.Areas.TicketList.Models
{
    public class TicketContext : IdentityDbContext<User>
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { SprintId = "1", Number = "1" },
                new Sprint { SprintId = "2", Number = "2" },
                new Sprint { SprintId = "3", Number = "3" },
                new Sprint { SprintId = "4", Number = "4" },
                new Sprint { SprintId = "5", Number = "5" }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo", Name = "To-Do" },
                new Status { StatusId = "progress", Name = "In Progress" },
                new Status { StatusId = "qa", Name = "Quality Assurance" },
                new Status { StatusId = "closed", Name = "Completed" }
            );
        }
    }
}
