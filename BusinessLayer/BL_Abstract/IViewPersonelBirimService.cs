using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer.BL_Abstract
{
    public interface IViewPersonelBirimService
    {
        List<viewPersonelBirim> GetAll();
        int BLAdd(viewPersonelBirim p);

        int BLDelete(viewPersonelBirim p);

        int BLUpdate(viewPersonelBirim p);

    }
}
