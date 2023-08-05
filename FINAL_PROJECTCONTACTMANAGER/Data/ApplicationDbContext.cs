using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FINAL_PROJECTCONTACTMANAGER.Models;

namespace FINAL_PROJECTCONTACTMANAGER.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FINAL_PROJECTCONTACTMANAGER.Models.Contact>? Contact { get; set; }
    }
}