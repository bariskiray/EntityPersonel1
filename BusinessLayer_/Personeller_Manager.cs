using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;
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
        PersonellerrRepo _repository;
        public Personeller_Manager()
        {
            _repository = new PersonellerrRepo();
        }
        public int BLAdd(Personeller p)
        {
            return _repository.Insert(p);

        }

        public int BLDelete(Personeller p)
        {
            return _repository.Delete(p);

        }

        public int BLUpdate(Personeller p)
        {
            return (_repository.Update(p));
        }


        public List<Personeller> GetAll()
        {
            return _repository.List();
        }

        public List<Personeller> GetByName(string name)
        {
            return _repository.List(x => x.AdiSoyadi == name);
        }
    }
}
