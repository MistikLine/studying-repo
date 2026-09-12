using FactoryMethod3DShapes.Factory3DShapes.Creators;
using FactoryMethod3DShapes.Factory3DShapes.Products;
using System;
using System.Windows.Forms;

namespace FactoryMethod3DShapes
{
    public partial class f3DShapes : Form
    {
        private I3DShapeCreator _shapeCreator;
        private I3DShape _shape;

        I3DShape Shape
        {
            get => _shape;
            set
            {
                pbxShapeImage.Image = value?.GetImage();
                _shape = value;
            }
        }

        public f3DShapes()
        {
            InitializeComponent();
        }

        private void rb3DShapeType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Text)
                {
                    case "Cuboid":
                        _shapeCreator = new CuboidCreator();
                        break;
                    case "Sphere":
                        _shapeCreator = new SphereCreator();
                        break;
                    case "Cone":
                        _shapeCreator = new ConeCreator();
                        break;
                    default:
                        _shapeCreator = null;
                        break;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(_shapeCreator == null)
            {
                MessageBox.Show("Please select a 3D shape type.");
                return;
            }

            Shape = _shapeCreator.Create3DShape();
        }
    }
}
