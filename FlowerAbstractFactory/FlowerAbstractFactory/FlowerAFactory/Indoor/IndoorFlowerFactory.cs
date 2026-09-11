using FlowerAbstractFactory.FlowerAFactory.ALevel;

namespace FlowerAbstractFactory.FlowerAFactory.Indoor
{
    public class IndoorFlowerFactory : IFlowerFactory
    {
        public IViolet CreateViolet()
        {
            return new IndoorViolet();
        }

        public IRose CreateRose()
        {
            return new IndoorRose();
        }

        public IChamomile CreateChamomile()
        {
            return new IndoorChamomile();
        }
    }
}
