using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;
using DataAccessLayer_.DA_Abstract;
using Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_
{
    public class Personeller_Manager : IPersonellerService_
    {
        public readonly IPersoneller _personeller;
        public Personeller_Manager(IPersoneller personeller)
        {
            _personeller = personeller;
        }
        public int BLAdd(Personeller p)
        {
            return _personeller.Insert(p);

        }

        public int BLDelete(Personeller p)
        {
            return _personeller.Delete(p);

        }

        public int BLUpdate(Personeller p)
        {
            return (_personeller.Update(p));
        }


        public List<Personeller> GetAll()
        {
            return _personeller.List();
        }

        public List<Personeller> GetByName(string name)
        {
            return _personeller.List(x => x.AdiSoyadi == name);
        }
    }
}
