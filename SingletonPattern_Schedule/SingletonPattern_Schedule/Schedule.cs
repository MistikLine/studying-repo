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
    public partial class Schedule : Form
    {
        dbManager manager;
        Logger logger;

        public Schedule()
        {
            InitializeComponent();
            manager = dbManager.getInstance();
            logger = Logger.GetInstance();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            manager.Connect();
            cbWeekDay.Text = "Понеділок";
            cbWeek.SelectedIndex = 0;
        }

        private void ChooseSchedule(string weekDay, int week)
        {
            dgvSchedule.DataSource = manager.ExecuteSelect($"select \r\n\tlt.Number as 'Пара',\r\n    lt.StartTime as 'Початок',\r\n    lt.EndTime as 'Кінець',\r\n    s.Name as 'Предмет',\r\n    t.Name as 'Викладач'\r\nfrom lessons l\r\njoin lessontimeperday lt on l.LessonTime = lt.Number\r\njoin subject s on l.Subject = s.ID\r\njoin teacher t on l.Teacher = t.ID\r\njoin weekday w on l.WeekDay = w.ID\r\nwhere w.Name = '{weekDay}' and w.Week = {week};");
            logger.AddLog($"Користувач вибрав розклад занять такого дня: {weekDay} та такого тижня: {week}");
        }

        private void cbWeekDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseSchedule(cbWeekDay.Text, (cbWeek.SelectedIndex + 1));
        }
    }
}
