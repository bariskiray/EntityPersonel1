using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonel1.BusinessLayer
{
    public class BirimlerManager
    {
        Repository<Birimler> birimlerrepo = new Repository<Birimler>();
        public List<Birimler> GetAll()
        {
            return birimlerrepo.List();
        }
        public int BLAdd(Birimler birimler)
        {
            return birimlerrepo.Insert(birimler);
        }
        public int BLDelete(int p)
        {
            if (p!=0)
            {
                Birimler b = birimlerrepo.Find(x => x.BirimID == p);
                return birimlerrepo.Delete(b);
            }
            else
            {
                return -1;
            }
        }
        public int BLUpdate(Birimler b)
        {
            if (b.BirimAdi == "")
            {
                return -1;
            }
            else
            {
                Birimler birimler = birimlerrepo.Find(x => x.BirimID == b.BirimID);
                birimler.BirimAdi = b.BirimAdi;
                return birimlerrepo.Update(birimler);
            }
        }
    }
}
