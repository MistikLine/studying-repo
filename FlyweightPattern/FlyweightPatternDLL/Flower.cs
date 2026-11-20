using System.Drawing;

namespace FlyweightPatternDLL
{
    public class Flower
    {
        private int isLiving = -1;
        private readonly int height = 100;
        private readonly int width = 50;

        private readonly FlowerParam p;
        private readonly Point point;

        public bool IsAlive { get; private set; } = true;

        public Flower(FlowerParam par, Point startPoint)
        {
            p = par;
            point = startPoint;
        }

        public void Live(Graphics g)
        {
            if (!IsAlive) return;

            isLiving++;

            if (isLiving < p.LivingTime[0])
                g.DrawImage(p.Sprout, point.X, point.Y, width, height);
            else if (isLiving < p.LivingTime[1])
                g.DrawImage(p.Matured, point.X, point.Y, width, height);
            else if (isLiving < p.LivingTime[2])
                g.DrawImage(p.Withered, point.X, point.Y, width, height);
            else
                IsAlive = false;
        }
    }
}