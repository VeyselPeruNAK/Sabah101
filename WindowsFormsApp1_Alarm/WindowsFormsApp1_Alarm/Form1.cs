using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Alarm Kuruldu.";
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dateTimePicker1.Value;

            if (dateTime.Hour == alarmTime.Hour && dateTime.Minute == alarmTime.Minute && dateTime.Second == alarmTime.Second)
            {
                timer1.Stop();
                label2.Text = "Alarm Çalıyor...";


                player.SoundLocation = @"C:\alarm.wav";
                player.PlayLooping();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            label2.Text = "Alarm Durduruldu.";
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "...";
        }
    }
}