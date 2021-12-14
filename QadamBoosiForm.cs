using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace QadamBoosi_App
{
    public partial class QadamBoosiForm : Form
    {
        int s, m, h;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wrRX2XgL1VKSAfCYl4o0h9teAj0KwZ2VzankPoxG",
            BasePath = "https://counterproject-a65db-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public QadamBoosiForm(string startTime, string totalQadaboosi)
        {
            InitializeComponent();
            lblTime.Text = startTime;
            lblTotalQadaboosi.Text = totalQadaboosi;
            lblTotalQadaboosi.Font = new Font("Arial", 100, FontStyle.Bold);
            lblPending.Font = new Font("Arial", 100, FontStyle.Bold);
            lblCompleted.Font = new Font("Arial", 100, FontStyle.Bold);
        }

        private void QadamBoosiForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            
        }

        private async Task GetFireBase(bool resultValue)
        {
            try
            {
                while (resultValue)
                {
                    await Task.Delay(500);
                    FirebaseResponse res = client.Get($@"counterValue/1");
                    Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                    lblCompleted.Text = data.ElementAt(0).Value;
                    var done = Convert.ToInt32(lblCompleted.Text);
                    var total = Convert.ToInt32(lblTotalQadaboosi.Text);
                    if (done > 0 && done <= total)
                    {
                        
                        var pending = total - done;
                        lblPending.Text = Convert.ToString(pending);
                    }
                    if (done == 0)
                    {
                        lblPending.Text = total.ToString();
                    }
                }
                    
               

            }
            catch (Exception ex)
            {
                //lblCount.Text = ex.Message;
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QadamBoosiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmDuration.Stop();
            GetFireBase(false).GetAwaiter();
            this.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmDuration.Start();
            btnStart.Hide();
            GetFireBase(true).GetAwaiter();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tmDuration_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }

            lblDuration.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
    }
}
