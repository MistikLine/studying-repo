using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Garden
{
    public class GardenViolet : IViolet
    {
        public Image Appearance => Resources.garden_violet;

        public string FlowerType => "Garden Violet";
    }
}
