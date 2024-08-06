using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfStudentDal : IStudentDal
    {
        public void Add(Student student)
        {
            using (var context = new StudentDbContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void Delete(Student student)
        {
            using (var context = new StudentDbContext())
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public Student Get(int id)
        {
            using (var context = new StudentDbContext())
            {
                var result = context.Students.Where(c => c.Id == id).FirstOrDefault();
                return result;
            }
        }

        public List<Student> GetList()
        {
            using (var context = new StudentDbContext())
            {
                //Listeleme için kullanacağız
                var result =context.Students.ToList();
                return result;
            }
        }

        public void Update(Student student)
        {
            using (var context = new StudentDbContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
        }
    }
}
