using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Garden
{
    public class GardenRose : IRose
    {
        public Image Appearance => Resources.garden_rose;

        public string FlowerType => "Garden Rose";
    }
}
