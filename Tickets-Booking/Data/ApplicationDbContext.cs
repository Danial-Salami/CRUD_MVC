using Microsoft.EntityFrameworkCore;
using Tickets_Booking.Models;

namespace Tickets_Booking.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
