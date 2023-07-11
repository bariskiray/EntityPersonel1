using EntityPersonel1.BusinessLayer.BL_Abstract;
using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer
{
    public class Personel_Manager: IPersonellerService
    {
        Repository<Personeller> _repository;
        public Personel_Manager()
        {
            _repository = new Repository<Personeller>();
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
            return _repository.List(x=>x.AdiSoyadi == name);
        }
    }
}
