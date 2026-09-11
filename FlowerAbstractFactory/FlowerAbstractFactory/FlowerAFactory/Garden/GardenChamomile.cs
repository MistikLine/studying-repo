using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Garden
{
    public class GardenChamomile : IChamomile
    {
        public Image Appearance => Resources.garden_chamomile;

        public string FlowerType => "Garden Chamomile";
    }
}
