using FlowerAbstractFactory.FlowerAFactory.ALevel;

namespace FlowerAbstractFactory.FlowerAFactory.Wild
{
    public class WildViolet : IViolet
    {
        public System.Drawing.Image Appearance => Properties.Resources.wild_violet;
        public string FlowerType => "Wild Violet";
    }
}
