using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.Properties;
using System.Drawing;

namespace FlowerAbstractFactory.FlowerAFactory.Indoor
{
    public class IndoorChamomile : IChamomile
    {
        public Image Appearance => Resources.indoor_chamomile;

        public string FlowerType => "Indoor Chamomile";
    }
}
