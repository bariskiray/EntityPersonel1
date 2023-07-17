using Entities_;
using System.Collections.Generic;
using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;


namespace BusinessLayer_
{
    public class Birimler_Manager: IBirimlerService_
    {
        readonly IBirimlerService_ _birimlerService;
        public Birimler_Manager(IBirimlerService_ birimlerservice)
        {
            _birimlerService = birimlerservice;
        }
        public int BLAdd(Birimler p)
        {
            return _birimlerService.Insert(p);

        }
        public int BLDelete(Birimler p)
        {
            return _birimlerService.Delete(p);

        }

        public int BLUpdate(Birimler p)
        {
            return _repository.Update(p);
        }


        public List<Birimler> GetAll()
        {
            return _repository.List();
        }

    }
}
