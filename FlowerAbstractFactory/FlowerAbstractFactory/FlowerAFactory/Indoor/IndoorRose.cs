using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Indoor
{
    public class IndoorRose : IRose
    {
        public Image Appearance => Resources.indoor_rose;

        public string FlowerType => "Indoor Rose";
    }
}
