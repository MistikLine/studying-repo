using System.Drawing;

namespace FlyweightPatternDLL
{
    public class FlowerParam
    {
        Bitmap sprout = null;
        protected Bitmap matured = null;
        Bitmap withered = null;

        int[] livingTime = new int[3] { 5, 10, 15 };
        
        public int[] LivingTime { get { return livingTime; } }

        public Bitmap Sprout { get { return sprout; } }
        public Bitmap Matured { get { return matured; } }
        public Bitmap Withered { get { return withered; } }

        public FlowerParam()
        {
            sprout = new Bitmap("Sprout.jpg");
            withered = new Bitmap("Withered.jpg");
        }

    }
}