using System.Drawing;  

namespace FactoryMethod3DShapes.Factory3DShapes.Products
{
    public class Sphere : I3DShape
    {
        public Image GetImage() => Properties.Resources.Sphere;
    }
}
