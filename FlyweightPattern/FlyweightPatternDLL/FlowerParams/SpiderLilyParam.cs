using System.Drawing;

namespace FlyweightPatternDLL.FlowerParams
{
    public class SpiderLilyParam : FlowerParam
    {
        public SpiderLilyParam()
        {
            matured = new Bitmap("SpiderLily.jpg");
        }
    }
}
