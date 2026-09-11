using FlowerAbstractFactory.FlowerAFactory.ALevel;
using FlowerAbstractFactory.FlowerAFactory.Garden;
using FlowerAbstractFactory.FlowerAFactory.Wild;
using FlowerAbstractFactory.FlowerAFactory.Indoor;
using System;
using System.Windows.Forms;

namespace FlowerAbstractFactory
{
    public partial class fFlower : Form
    {
        //fields
        private string flowerType = null;

        private IFlowerFactory flowerFactory;
        private IRose rose;
        private IChamomile chamomile;
        private IViolet violet;

        //properties
        private IRose Rose
        {
            get => rose;
            set
            {
                if (value != null)
                {
                    pbxRose.Image = value.Appearance;
                    lbRose.Text = value.FlowerType;
                }

                rose = value;
            }
        }
        private IChamomile Chamomile
        {
            get => chamomile;
            set
            {
                if (value != null)
                {
                    pbxChamomile.Image = value.Appearance;
                    lbChamomile.Text = value.FlowerType;
                }

                chamomile = value;
            }
        }
        private IViolet Violet
        {
            get => violet;
            set
            {
                if (value != null)
                {
                    pbxViolet.Image = value.Appearance;
                    lbViolet.Text = value.FlowerType;
                }

                violet = value;
            }
        }

        public fFlower()
        {
            InitializeComponent();
        }

        //methods
        private void rbFlowerType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Text)
                {
                        case "Garden":
                            flowerFactory = new GardenFlowerFactory();
                            break;
                        case "Indoor":
                            flowerFactory = new IndoorFlowerFactory();
                            break;
                        case "Wild":
                            flowerFactory = new WildFlowerFactory();
                            break;
                        default:
                            flowerFactory = null;
                            break;
                    
                }
            }
        }

        private void rbFlower_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                flowerType = rb.Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(flowerFactory == null || flowerType == null)
            {
                MessageBox.Show("Please select a flower type and a flower.");
                return;
            }

            switch(flowerType)
            {
                case "Rose":
                    Rose = flowerFactory.CreateRose();
                    break;
                case "Chamomile":
                    Chamomile = flowerFactory.CreateChamomile();
                    break;
                case "Violet":
                    Violet = flowerFactory.CreateViolet();
                    break;

                default:
                    MessageBox.Show("Unknown flower type.");
                    return;
            }
        }
    }
}
