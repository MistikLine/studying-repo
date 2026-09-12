using FactoryMethod3DShapes.Factory3DShapes.Products;

namespace FactoryMethod3DShapes.Factory3DShapes.Creators
{
    public class SphereCreator : I3DShapeCreator
    {
        public I3DShape Create3DShape()
        {
            return new Sphere();
        }
    }
}
