using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Section { get; set; }

        public ICollection<Academic> Academics { get; set; }
    }
}
