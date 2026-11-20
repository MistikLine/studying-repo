using System.Drawing;

namespace FlyweightPatternDLL.FlowerParams
{
    public class VioletParam : FlowerParam
    {
        public VioletParam()
        {
            matured = new Bitmap("Violet.jpg");
        }
    }
}
