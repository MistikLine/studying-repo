using FlyweightPatternDLL;
using FlyweightPatternDLL.FlowerParams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyweightPattern
{
    public partial class Form1 : Form
    {
        List<Flower> flowers = new List<Flower>();
        RoseParam roseParam = new RoseParam();
        VioletParam violetParam = new VioletParam();
        SpiderLilyParam spiderLilyParam = new SpiderLilyParam();
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = pbxField.CreateGraphics();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(flowers.Count == 0)
            {
                return;
            }

            g.Clear(Color.MediumSeaGreen);

            foreach (var flower in flowers)
            {
                flower.Live(g);
            }
        }

        private void pbxField_MouseUp(object sender, MouseEventArgs e)
        {
            if(rbtnRose.Checked)
            {
                flowers.Add(new Flower(roseParam, e.Location));
            }
            else if (rbtnViolet.Checked)
            {
                flowers.Add(new Flower(violetParam, e.Location));
            }
            else if (rbtnSpiderLily.Checked)
            {
                flowers.Add(new Flower(spiderLilyParam, e.Location));
            }
        }
    }
}
