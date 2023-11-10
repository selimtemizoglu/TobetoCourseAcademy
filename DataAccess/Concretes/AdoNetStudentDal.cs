﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetStudentDal
    {
        public void Add(Student student)
        {
            Console.WriteLine("Öğrenci Eklendi..");
        }

        public void Delete(Student student)
        {
            Console.WriteLine("Öğrenci Silindi..");
        }

        public void Update(Student student)
        {
            Console.WriteLine("Öğrenci Güncellendi..");
        }

    }
}
