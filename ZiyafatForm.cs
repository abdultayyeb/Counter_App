using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
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
    public partial class ZiyafatForm : Form
    {
        int s, m, h;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wrRX2XgL1VKSAfCYl4o0h9teAj0KwZ2VzankPoxG",
            BasePath = "https://counterproject-a65db-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        IFirebaseClient client2;
        public ZiyafatForm(string startTime, string totalQadaboosi,string totalZiyafat)
        {
            InitializeComponent();
            lblTime.Text = startTime;
            lblTotalQadamboosi.Text = totalQadaboosi;
            lblTotalZiyafat.Text = totalZiyafat;
        }

        private async Task GetFireBaseQadambosi(bool resultValue)
        {
            try
            {
                while (resultValue)
                {
                    await Task.Delay(500);
                    FirebaseResponse res = client.Get($@"counterValue/1");
                    Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                    lblCompletedQadam.Text = data.ElementAt(0).Value;
                    var done = Convert.ToInt32(lblCompletedQadam.Text);
                    var total = Convert.ToInt32(lblTotalQadamboosi.Text);
                    if (done > 0 && done <= total)
                    {

                        var pending = total - done;
                        lblPendingQadamboosi.Text = Convert.ToString(pending);
                    }
                    if (done == 0)
                    {
                        lblPendingQadamboosi.Text = total.ToString();
                    }
                }



            }
            catch (Exception ex)
            {
                //lblCount.Text = ex.Message;
            }

        }


        private async Task GetFireBaseZiyafat(bool resultValue)
        {
            try
            {
                while (resultValue)
                {
                    await Task.Delay(500);
                    FirebaseResponse res = client2.Get($@"counterZiyafatValue/1");
                    Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                    lblCompletedZiyafat.Text = data.ElementAt(0).Value;
                    var done = Convert.ToInt32(lblCompletedZiyafat.Text);
                    var total = Convert.ToInt32(lblTotalZiyafat.Text);
                    if (done > 0 && done <= total)
                    {

                        var pending = total - done;
                        lblPendingZiyafat.Text = Convert.ToString(pending);
                    }
                    if (done == 0)
                    {
                        lblPendingZiyafat.Text = total.ToString();
                    }
                }



            }
            catch (Exception ex)
            {
                //lblCount.Text = ex.Message;
            }

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

        private void ZiyafatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmDuration.Stop();
            GetFireBaseQadambosi(false).GetAwaiter();
            GetFireBaseZiyafat(false).GetAwaiter();
            this.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmDuration.Start();
            btnStart.Hide();
            GetFireBaseQadambosi(true).GetAwaiter();
            GetFireBaseZiyafat(true).GetAwaiter();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZiyafatForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            client2 = new FireSharp.FirebaseClient(config);
        }
    }
}
