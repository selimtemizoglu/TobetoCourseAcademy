using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class StudentManager
    {
        public void Add(Student student)
        {
            AdoNetStudentDal adoNetStudentDal = new AdoNetStudentDal();
            adoNetStudentDal.Add(student);
            
        }

        public void Update(Student student)
        {
            AdoNetStudentDal adoNetStudentDal = new AdoNetStudentDal();
            adoNetStudentDal.Update(student);
        }

        public void Delete(Student student)
        {
            AdoNetStudentDal adoNetStudentDal = new AdoNetStudentDal();
            adoNetStudentDal.Delete(student);
        }

    }
}
