using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CURDWithAngularJSandWebAPI.Models
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext() : base("testconnection")
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}