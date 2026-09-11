using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Indoor
{
    public class IndoorViolet : IViolet
    {
        public Image Appearance => Resources.indoor_violet;

        public string FlowerType => "Indoor Violet";
    }
}
