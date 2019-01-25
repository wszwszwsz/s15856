using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new AcademyContext())
            {
                var academic = new Academic() { AcademicName = "Lukasz" };

                ctx.Academies.Add(academic);
                ctx.SaveChanges();    
            }
        }
    }
}
