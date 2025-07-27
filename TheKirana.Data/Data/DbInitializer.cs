using TheKirana.Model.Models;

namespace TheKirana.Data.Data
{
    public class DbInitializer : IAppDbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // Ensure database created
            _context.Database.EnsureCreated();

            // Add default data if needed

            // Add more seed data here...
        }
    }
}
