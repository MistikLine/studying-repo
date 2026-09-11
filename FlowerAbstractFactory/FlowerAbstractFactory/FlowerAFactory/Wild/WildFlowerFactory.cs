using FlowerAbstractFactory.FlowerAFactory.ALevel;

namespace FlowerAbstractFactory.FlowerAFactory.Wild
{
    public class WildFlowerFactory : IFlowerFactory
    {
        public IChamomile CreateChamomile()
        {
            return new WildChamomile();
        }

        public IRose CreateRose()
        {
            return new WildRose();
        }

        public IViolet CreateViolet()
        {
            return new WildViolet();
        }
    }
}
