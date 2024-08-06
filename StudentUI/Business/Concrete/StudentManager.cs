using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public bool Add(Student student)
        {
            _studentDal.Add(student);
            return true;
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student Get(int id)
        {
            return _studentDal.Get(id);
        }

        public List<Student> GetList()
        {
            return _studentDal.GetList();
        }

        public bool Update(Student student)
        {
            _studentDal.Update(student);
            return true;
        }
    }
}
