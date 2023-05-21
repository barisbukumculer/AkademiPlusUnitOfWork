using AkademiPlus.DataAccessLayerLayer.Abstract;
using AkademiPlus.DataAccessLayerLayer.Concrete;
using AkademiPlus.DataAccessLayerLayer.Repositories;
using AkademiPlus.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlus.DataAccessLayerLayer.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>,IProcessDal
    {
        public EfProcessDal(Context context):base(context)
        {
        }
    }
}
