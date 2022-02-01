using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options) { }

        public DbSet<Inspection> Inspections {  get; set; }
        public DbSet<InspectionType> InspectionsTypes {  get; set; }
        public DbSet<Status> Statuses {  get; set; }

    }
}
