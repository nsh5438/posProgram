using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMBAM_Project
{
    public partial class LoadingDisplay : Form
    {
        const int MAXNUM = 30;
        public LoadingDisplay()
        {
            InitializeComponent();
            Timer_Load();
            Pgb_Load();
            Timer_Start();
        }

        private void Pgb_Load()
        {
            LoadingPgb.Maximum = MAXNUM;
            LoadingPgb.Value = 0;
            LoadingPgb.Step = 10;
        }

        private void Timer_Load()
        {
            TimerLoad.Interval = 600;
        }

        private void Timer_Start()
        {
            TimerLoad.Start();
        }

        private void Timer_Stop()
        {
            TimerLoad.Stop();
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            if (LoadingPgb.Value >= MAXNUM)
            {
                Timer_Stop();
                this.Close();
            }
            LoadingPgb.PerformStep();
        }

    }
}
