using Entities_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_.BL_Abstract
{
    public interface IBirimlerService_
    {
        List<Birimler> GetAll();
        int BLAdd(Birimler p);

        int BLDelete(Birimler p);

        int BLUpdate(Birimler p);

    }
}
