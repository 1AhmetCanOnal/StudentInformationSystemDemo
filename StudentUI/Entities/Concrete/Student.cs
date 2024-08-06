using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //stundents diye tablo ismi oluşturulacak
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Department { get; set; }
        public DateTime Dateofbirth { get; set; }
    }

}
