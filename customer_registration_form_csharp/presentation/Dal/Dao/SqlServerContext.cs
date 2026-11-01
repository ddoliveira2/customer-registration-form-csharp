using presentation.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace presentation.Dal.Dao
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() : base("Server=localhost;Database=CustomerDb;User Id=sa;Password=123456;TrustServerCertificate=True;")
        {
        }

        public DbSet<CustomerDto> Customer { get; set; }
    }
}
