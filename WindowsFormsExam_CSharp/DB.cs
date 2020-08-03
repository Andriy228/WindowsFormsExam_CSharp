using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExam_CSharp
{
    public class DB : DbContext
    {
        public DB() : base("DBConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
