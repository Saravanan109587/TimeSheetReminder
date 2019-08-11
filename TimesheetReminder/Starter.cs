using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetReminder
{
    public partial class Starter : MetroFramework.Forms.MetroForm
    {
        public Starter()
        {
            InitializeComponent();

        }

        private void btn_starterOk_Click(object sender, EventArgs e)
        {
            int interval = Convert.ToInt32(ConfigurationManager.AppSettings["TimIntervalMIN"]);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            Remindercontrol.LastUpdateTime = DateTime.Now;
            Task timerTask = RunPeriodically(() => {
                Remindercontrol control = new Remindercontrol();
                control.ShowDialog();
            }, TimeSpan.FromMinutes(interval), tokenSource.Token);
            this.Close();
           
        }

        async Task RunPeriodically(Action action, TimeSpan interval, CancellationToken token)
        {
            while (true)
            {
               
                await Task.Delay(interval, token);
                action();
            }
        }

        private void btn_starterCancel_Click(object sender, EventArgs e)
        {

            DialogResult rslt= MessageBox.Show("CLosing will never Remind you to For Time Sheet untill Next Start.Are you sure want to cancel ?","Warning",MessageBoxButtons.YesNo);
            if(rslt == DialogResult.Yes)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                else   
                    // Console app
                    System.Environment.Exit(1);
              
            }
                
        }
    }
}
