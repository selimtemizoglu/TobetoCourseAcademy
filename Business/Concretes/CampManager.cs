using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CampManager
    {


        public void Add(Camp camp)
        {
            AdoNetCampDal adoNetCampDal = new AdoNetCampDal();
            adoNetCampDal.Add(camp);

        }
        public void Update(Camp camp)
        {
            AdoNetCampDal adoNetCampDal = new AdoNetCampDal();
            adoNetCampDal.Update(camp);

        }
        public void Delete(Camp camp)
        {
            AdoNetCampDal adoNetCampDal = new AdoNetCampDal();
            adoNetCampDal.Delete(camp);
        }
    }
}
