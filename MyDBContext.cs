using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.SQLite.Teste.Model
{

    public class MyDBContext : DbContext
    {
        public MyDBContext()
            : base(new SQLiteConnection()
            {
                ConnectionString =
                    new SQLiteConnectionStringBuilder() { DataSource = "C:\\WpfSQLiteSQLite\\dbteste.db" }
                    .ConnectionString
            }, true)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
