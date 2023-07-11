using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.DataAccessLayer.Abstract;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer.BL_Abstract
{
    public interface IBirimlerService {
        List<Birimler> GetAll();
        int BLAdd(Birimler p);

        int BLDelete(Birimler p);

        int BLUpdate(Birimler p);
    }
        
}
