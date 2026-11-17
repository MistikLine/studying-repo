using BuilderAndPrototypeDLL;
using BuilderAndPrototypeDLL.ReportBuilders;
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
    public partial class Form1 : Form
    {
        HTMLReport report;
        AReportBuilder reportBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateEmployeeReport_Click(object sender, EventArgs e)
        {
            reportBuilder = new EmployeeHTMLReportBuilder();
            pCreationPanel.Visible = true;
        }

        private void btnCreateTaskReport_Click(object sender, EventArgs e)
        {
            reportBuilder = new TaskHTMLReportBuilder();
            pCreationPanel.Visible = true;
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if(reportBuilder == null)
            {
                MessageBox.Show("Будь ласка, спочатку оберіть тип звіту.");
                return;
            }

            rtxtReport.Clear();
            
            if(chbCoverPage.Checked)
            {
                reportBuilder.BuildCoverPage();
            }
            if (chbIntroduction.Checked)
            {
                reportBuilder.BuildIntroduction();
            }
            if (chbMainBody.Checked)
            {
                reportBuilder.BuildMainBody();
            }

            if (chbConclusions.Checked)
            {
                reportBuilder.BuildConclusions();
            }

            if(chbReferences.Checked)
            {
                reportBuilder.BuildReferences();
            }

            report = reportBuilder.GetHTMLReport();
            rtxtReport.Text = report.GetHTMLContent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveReport save = new SaveReport();
            save.report = report.clone();
            save.ShowDialog();
        }
    }
}
