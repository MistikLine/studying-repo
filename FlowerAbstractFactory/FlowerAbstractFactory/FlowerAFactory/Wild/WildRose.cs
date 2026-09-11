using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Wild
{
    public class WildRose : IRose
    {
        public Image Appearance => Resources.wild_rose;

        public string FlowerType => "Wild Rose";
    }
}
