using Microsoft.EntityFrameworkCore;
using SchoolManegementApp.Models;

namespace SchoolManegementApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<student> StudentsInformation { get; set; }        
    }

}
