using BuilderAndPrototypeDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderAndPrototypePattern
{
    public partial class SaveReport : Form
    {
        public HTMLReport report = new HTMLReport();

        public SaveReport()
        {
            InitializeComponent();
        }

        private void SaveReport_Load(object sender, EventArgs e)
        {
            rtxtReport.Text = report.GetHTMLContent();
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            report.Export();
        }
    }
}
