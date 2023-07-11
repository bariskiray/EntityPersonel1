using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer
{
    public class viewPersonelBirim_Manager
    {
        Repository<viewPersonelBirim> _repository;
        public viewPersonelBirim_Manager()
        {
            _repository = new Repository<viewPersonelBirim>();
        }
        public int BLAdd(viewPersonelBirim p)
        {
            return _repository.Insert(p);

        }

        public int BLDelete(viewPersonelBirim p)
        {
            return _repository.Delete(p);

        }

        public int BLUpdate(viewPersonelBirim p)
        {
            return (_repository.Update(p));
        }


        public List<viewPersonelBirim> GetAll()
        {
            return _repository.List();
        }
    }
}
