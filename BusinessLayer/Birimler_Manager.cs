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
    public class Birimler_Manager: IBirimlerService
    {
        Repository<Birimler> _repository;
        public Birimler_Manager()
        {
            _repository = new Repository<Birimler>();
        }
        public int BLAdd(Birimler p)
        {
            return _repository.Insert(p);

        }
        public int BLDelete(Birimler p)
        {
            return _repository.Delete(p);

        }

        public int BLUpdate(Birimler p)
        {
            return (_repository.Update(p)); 
        }


        public List<Birimler> GetAll()
        {
            return _repository.List();
        }
    }
}
    