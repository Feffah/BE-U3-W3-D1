using BE_U3_W3_D1.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BE_U3_W3_D1.Models.Entities
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

    {
        //tabella Students
        public DbSet<Student> Students { get; set; }

        public DbSet<ApplicationUser> AspNetUsers { get; set; }
        //costruttore
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}