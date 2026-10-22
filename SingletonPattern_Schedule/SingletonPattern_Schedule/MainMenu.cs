using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonPattern_DLL;

namespace SingletonPattern_Schedule
{
    public partial class MainMenu : Form
    {
        Logger logger;
        DocumentSaver documentSaver;

        string Log
        {
            get => documentSaver.Text;
            set
            {
                logger.AddLog(value);
                rtxtLogs.Text = documentSaver.Text;
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            logger = Logger.GetInstance();
            documentSaver = DocumentSaver.GetInstance();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            Log = "Користувач запускає вікно з розкладом.";
            schedule.ShowDialog();
            Log = "Користувач закриває вікно з розкладом.";
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            documentSaver.SaveDocument();
        }

        private void btnLoadLogs_Click(object sender, EventArgs e)
        {
            documentSaver.LoadDocument();
            Log = "Користувач завантажив збережені логи.";
        }
    }
}
