using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using TDU.CMS.Models;

namespace TDU.CMS.DataBase
{
    public class CMSDbContext : System.Data.Entity.DbContext
    {
        //public CMSDbContext() : base(CreateConnection(), true) { } 
        public CMSDbContext() : base("TDUCMSConnectionString") { }
        public CMSDbContext(string connectionString) : base(connectionString) { }
        public CMSDbContext(DbConnection dbConnection):base(dbConnection,true) { }

        static CMSDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CMSDbContext>(null);
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardRequest> CardRequests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RequestHistory> RequestHistories { get; set; }

        static DbConnection CreateConnection()
        {
            //var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            var connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "NSERVER2K8",
                InitialCatalog = "TDUCMS",
                UserID = "sa",
                Password = "sasasa@123456"
            };
            connection.ConnectionString = connectionStringBuilder.ConnectionString;
            //MessageBox.Show(connection.ConnectionString);
            return connection;
        }
    }
}