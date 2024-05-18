using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDify_Simplifying_data_management_with_ASP.NET.Models;

namespace CRUDify_Simplifying_data_management_with_ASP.NET.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDify_Simplifying_data_management_with_ASP.NET.Models.Info> Info { get; set; } = default!;
    }
}
