using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TeacherManager
    {
        public void Add(Teacher teacher)
        {
            AdoNetTeacherDal adoNetTeacherDal = new AdoNetTeacherDal();
            adoNetTeacherDal.Add(teacher);

        }

        public void Update(Teacher teacher)
        {
            AdoNetTeacherDal adoNetTeacherDal = new AdoNetTeacherDal();
            adoNetTeacherDal.Update(teacher);
        }

        public void Delete(Teacher teacher)
        {
            AdoNetTeacherDal adoNetTeacherDal = new AdoNetTeacherDal();
            adoNetTeacherDal.Delete(teacher);
        }
    }
}
