using FlowerAbstractFactory.FlowerAFactory.ALevel;

namespace FlowerAbstractFactory.FlowerAFactory.Garden
{
    public class GardenFlowerFactory : IFlowerFactory
    {
        public IViolet CreateViolet()
        {
            return new GardenViolet();
        }

        public IRose CreateRose()
        {
            return new GardenRose();
        }

        public IChamomile CreateChamomile()
        {
            return new GardenChamomile();
        }
    }
}
