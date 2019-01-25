using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   [Table("Academic")]
    public class Academic
    {
        public Academic() { }

        [Key] 
        [Column(Order = 0)]
        public int AcademicId { get; set; }

        [Column("Name", TypeName ="ntext", Order =1 ) ]
        [MaxLength(25)]
        public string AcademicName { get; set; }

        [Column("DoB", TypeName = "DateTime2", Order = 2)]
        [NotMapped]
        public DateTime? DateOfBirth { get; set; }
        [Column(Order = 3)]
        public byte[] Photo { get; set; }
        [Column(Order = 4)]
        public decimal Height { get; set; }
        [Column(Order = 5)]
        public float Weight { get; set; }

      
        public Group Group { get; set; }
    }
}
