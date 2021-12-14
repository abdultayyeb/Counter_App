using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QadamBoosi_App
{
    public partial class StartForm : Form
    {
        int s, m, h;
        public StartForm()
        {
            InitializeComponent();
            //InitializeTimePicker();
        }
        private DateTimePicker timePicker;
        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
            Controls.Add(timePicker);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            var timeValue = dtTime.Value.Date.Add(dtTime.Value.TimeOfDay); ;
            QadamBoosiForm frm = new QadamBoosiForm(timeValue.ToString("hh:mm:ss"), nmTotal.Value.ToString());
            frm.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
            
        }

        DateTime dt = DateTime.Now;
        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
