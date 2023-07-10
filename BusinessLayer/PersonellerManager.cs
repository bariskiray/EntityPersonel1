using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer
{
    public class PersonellerManager
    {
        Repository<Personeller> personellerrepo = new Repository<Personeller>();
        public List<Personeller> GetAll()
        {
            return personellerrepo.List();
        }
        public List<Personeller> GetByName(string p)
        {
            return personellerrepo.List(x => x.AdiSoyadi == p);
        }

    }
}
