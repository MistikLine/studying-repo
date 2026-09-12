using FactoryMethod3DShapes.Factory3DShapes.Products;

namespace FactoryMethod3DShapes.Factory3DShapes.Creators
{
    public interface I3DShapeCreator
    {
        I3DShape Create3DShape();
    }
}
