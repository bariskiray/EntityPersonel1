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
   public class ViewPersonelBirim_Manager: IViewPersonelBirimService_
    {
        ViewPersonelBirimRepo _repository;
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
