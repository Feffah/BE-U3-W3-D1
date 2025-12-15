using BE_U3_W3_D1.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace BE_U3_W3_D1.Models.Entities
{
    public class ApplicationDbContext : DbContext

    {
        //tabella Students
        public DbSet<Student> Students { get; set; }
        //costruttore
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}