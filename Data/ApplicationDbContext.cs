using Housing_Reservation_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Housing_Reservation_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
