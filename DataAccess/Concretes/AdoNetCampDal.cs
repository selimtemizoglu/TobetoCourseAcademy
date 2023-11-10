using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCampDal
    {
        public void Add(Camp camp)
        {
            Console.WriteLine("Kamp eklendi");
        }

        public void Delete(Camp camp)
        {
            Console.WriteLine("Kamp Silindi");
        }

        public void Update(Camp camp)
        {
            Console.WriteLine("Kamp Güncellendi");
        }
    }
}
