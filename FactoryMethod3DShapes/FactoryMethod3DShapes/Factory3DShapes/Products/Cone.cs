using System.Drawing;

namespace FactoryMethod3DShapes.Factory3DShapes.Products
{
    public class Cone : I3DShape
    {
        public Image GetImage() => Properties.Resources.Cone;
    }
}
