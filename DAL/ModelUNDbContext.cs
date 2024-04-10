using Microsoft.EntityFrameworkCore;

namespace Model_UN_Crisis.DAL
{
    public class ModelUNDbContext : DbContext
    {
        public ModelUNDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.STG_Users> STG_Users { get; set; }
        public DbSet<Models.PRD_Users> PRD_Users { get; set; }
        public DbSet<Models.STG_Conferences> STG_Conferences { get; set; }
        public DbSet<Models.PRD_Conferences> PRD_Conferences { get; set; }
        public DbSet<Models.STG_Message_Groups> STG_Message_Groups { get; set; }
        public DbSet<Models.PRD_Message_Groups> PRD_Message_Groups { get; set; }
        public DbSet<Models.STG_Directives> STG_Directives { get; set; }
        public DbSet<Models.PRD_Directives> PRD_Directives { get; set; }
        public DbSet<Models.STG_Messages> STG_Messages { get; set; }
        public DbSet<Models.PRD_Messages> PRD_Messages { get; set; }
        public DbSet<Models.STG_News> STG_News { get; set; }
        public DbSet<Models.PRD_News> PRD_News { get; set; }
        public DbSet<Models.STG_Files> STG_Files { get; set; }
        public DbSet<Models.PRD_Files> PRD_Files { get; set; }
    }
}
