using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class FormMain : Form
    {
        private bool alarmSetFlag = false;
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmSecond = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelStatus.Text = "";
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
            labelTime.Text = DateTime.Today.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
