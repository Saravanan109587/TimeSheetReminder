using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace TimesheetReminder
{
    public partial class Remindercontrol : MetroFramework.Forms.MetroForm
    {

        public static DateTime LastUpdateTime;
        public Remindercontrol()
        {
            InitializeComponent();
            txt_duration.Text = LastUpdateTime.ToString() + " -- " + DateTime.Now.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_taskdesc.Text))
            {

                StringBuilder data = new StringBuilder();
                string path = ConfigurationManager.AppSettings["filepath"];
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                data.AppendLine();
                data.AppendLine("Task For the Time " + DateTime.Now  +" From " + LastUpdateTime);
                LastUpdateTime = DateTime.Now;
                data.AppendLine(txt_taskdesc.Text);
                
                System.IO.File.AppendAllText(path + DateTime.Now.ToString("dd'.'MM'.'yyyy"), data.ToString());
               
            }

            this.Close();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_taskdesc.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
