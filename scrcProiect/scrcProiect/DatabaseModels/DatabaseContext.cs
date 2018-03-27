using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace scrcProiect.DatabaseModels
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder()
                {
                    DataSource = @"E:\OneDrive\OneDrive - Universitatea Politehnica Timisoara\SEM2\SCRC\scrc\scrcProiect\scrcProiect\Database\sqlite1.db",
                    ForeignKeys = true,
                    BinaryGUID = false
                }.ConnectionString
            }, true)
        {

            Database.SetInitializer<DatabaseContext>(null);

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNOtExists....and some more stuff
            base.OnModelCreating(modelBuilder);
        }
    }
}