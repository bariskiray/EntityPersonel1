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
    public class Birimler_Manager<T> : IBirimlerManager<T> where T : class
    {
        Repository<T> _repository;
        public Birimler_Manager()
        {
            _repository = new Repository<T>();
        }
        public int BLAdd(T p)
        {
            return _repository.Insert(p);

        }

        public int BLDelete(T p)
        {
            return _repository.Delete(p);

        }

        public int BLUpdate(T p)
        {
            return (_repository.Update(p)); 
        }


        public List<T> GetAll()
        {
            return _repository.List();
        }
    }
}
    