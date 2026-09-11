using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Wild
{
    public class WildChamomile : IChamomile
    {
        public Image Appearance => Resources.wild_chamomile;

        public string FlowerType => "Wild Chamomile";
    }
}
