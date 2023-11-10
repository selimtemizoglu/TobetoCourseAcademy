using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public  class AdoNetTeacherDal
    {
        public void Add(Teacher teacher)
        {
            Console.WriteLine("Öğretmen Eklendi..");
        }

        public void Delete(Teacher teacher)
        {
            Console.WriteLine("Öğretmen Silindi..");
        }

        public void Update(Teacher teacher)
        {
            Console.WriteLine("Öğretmen Güncellendi..");
        }
    }
}
