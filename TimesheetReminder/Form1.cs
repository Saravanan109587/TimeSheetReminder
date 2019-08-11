using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetReminder
{
    public partial class TimeSheetReminder 
    {
        public TimeSheetReminder()
        {
           // InitializeComponent();
            Starter s = new Starter();
            s.ShowDialog();
        }

 

    }
}
