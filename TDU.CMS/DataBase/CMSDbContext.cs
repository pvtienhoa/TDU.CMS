using System.Data.Entity;
using TDU.CMS.Models;

namespace TDU.CMS.DataBase
{
    public class CMSDbContext : System.Data.Entity.DbContext
    {
        static CMSDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CMSDbContext>(null);
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardRequest> CardRequests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}