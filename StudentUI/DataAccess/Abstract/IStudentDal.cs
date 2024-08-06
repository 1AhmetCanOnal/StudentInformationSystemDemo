using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentDal
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);

        Student Get(int id);


        List<Student> GetList();
    }
}
