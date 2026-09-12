using System.Drawing;

namespace FactoryMethod3DShapes.Factory3DShapes.Products
{
    public class Cuboid : I3DShape
    {
        public Image GetImage() => Properties.Resources.Cuboid;
    }
}
