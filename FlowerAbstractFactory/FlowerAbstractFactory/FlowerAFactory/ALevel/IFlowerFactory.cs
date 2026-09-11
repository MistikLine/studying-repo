using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerAbstractFactory.FlowerAFactory.ALevel
{
    public interface IFlowerFactory
    {
        IViolet CreateViolet();
        IRose CreateRose();
        IChamomile CreateChamomile();
    }
}
