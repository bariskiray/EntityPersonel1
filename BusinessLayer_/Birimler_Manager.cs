using Entities_;
using System.Collections.Generic;
using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;
using DataAccessLayer_.DA_Abstract;

namespace BusinessLayer_
{
    public class Birimler_Manager: IBirimlerService_
    {
        public readonly IBirimler _birimler;
        public Birimler_Manager(IBirimler birimler)
        {
            _birimler = birimler;
        }
        public int BLAdd(Birimler p)
        {
            return _birimler.Insert(p);

        }
        public int BLDelete(Birimler p)
        {
            return _birimler.Delete(p);

        }

        public int BLUpdate(Birimler p)
        {
            return _birimler.Update(p);
        }


        public List<Birimler> GetAll()
        {
            return _birimler.List();
        }

    }
}
