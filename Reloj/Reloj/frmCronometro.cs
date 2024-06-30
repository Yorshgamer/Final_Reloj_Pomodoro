using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class frmCronometro : Form
    {
        private string cronometro;
        private Stopwatch stopwatch;
        public frmCronometro()
        {
            InitializeComponent();
            cronometro = "";
            stopwatch = new Stopwatch();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmReloj form1 = new frmReloj();
            this.Close();
            form1.Show();
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);

            var hour = ts.Hours;
            var minute = ts.Minutes;
            var second = ts.Seconds;
            var microsecond = ts.Milliseconds;

            cronometro = $"{hour}:{minute}:{second}:{microsecond}";

            lblCronometro.Text = cronometro;
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            timer3.Enabled = false;
            cronometro = "00:00:00:00";
            lblCronometro.Text = cronometro;
        }
    }
}
