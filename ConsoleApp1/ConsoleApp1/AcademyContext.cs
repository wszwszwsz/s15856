using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(): base("Academys15856")
        {
            Database.SetInitializer<AcademyContext>(new DropCreateDatabaseAlways<AcademyContext>());
        }
        

        public DbSet<Academic> Academies { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
