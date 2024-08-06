using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        bool Add(Student student);
        bool Update(Student student);
        void Delete(Student student);
        Student Get(int id);
        List<Student> GetList();
    }
}
