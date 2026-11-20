using System.Drawing;

namespace FlyweightPatternDLL.FlowerParams
{
    public class RoseParam : FlowerParam
    {
        public RoseParam()
        {
            matured = new Bitmap("Rose.jpg");
        }
    }
}
