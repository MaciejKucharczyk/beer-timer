using Microsoft.EntityFrameworkCore;

namespace beer_timer.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

    }
}
