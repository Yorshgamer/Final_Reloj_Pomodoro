using System;
using System.Windows.Forms;

namespace Reloj
{
    public partial class frmTemporizador : Form
    {
        private int horas, minutos, segundos;

        public frmTemporizador()
        {
            InitializeComponent();
            timer2.Interval = 1000; // Establecer el intervalo del timer a 1 segundo (1000 milisegundos)
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cboxMinutos.Items.Add(i);
                cboxSegundos.Items.Add(i);
                if (i < 24) cboxHoras.Items.Add(i);
            }

            cboxHoras.SelectedIndex = 0;
            cboxMinutos.SelectedIndex = 0;
            cboxSegundos.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Iniciar")
            {
                timer2.Start();
                btnStart.ForeColor = Color.Firebrick;
                btnStop.Enabled = true;
                btnStop.ForeColor = Color.RoyalBlue;

                horas = cboxHoras.SelectedIndex;
                minutos = cboxMinutos.SelectedIndex;
                segundos = cboxSegundos.SelectedIndex;

                btnStart.Text = "Restablecer";
            }
            else
            {
                ResetTimer();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "Detener")
            {
                timer2.Stop();
                btnStop.ForeColor = Color.DarkOrange;
                btnStop.Text = "Reanudar";
            }
            else
            {
                timer2.Start();
                btnStop.ForeColor = Color.RoyalBlue;
                btnStop.Text = "Detener";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                segundos--;
            }
            else
            {
                if (minutos > 0)
                {
                    minutos--;
                    segundos = 59;
                }
                else if (horas > 0)
                {
                    horas--;
                    minutos = 59;
                    segundos = 59;
                }
                else
                {
                    timer2.Stop();
                    MessageBox.Show("Se ha acabado el tiempo.", "TEMPORIZADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnStop.Enabled = false;
                    btnStop.ForeColor = Color.RoyalBlue;
                    btnStop.Text = "Detener";
                }
            }
            UpdateTimerLabel();
        }

        private void UpdateTimerLabel()
        {
            lblTimer.Text = $"{horas:D2}:{minutos:D2}:{segundos:D2}";
        }

        private void ResetTimer()
        {
            timer2.Stop();
            horas = minutos = segundos = 0;
            UpdateTimerLabel();

            btnStart.ForeColor = Color.ForestGreen;
            btnStart.Text = "Iniciar";

            btnStop.Enabled = false;
            btnStop.ForeColor = Color.RoyalBlue;
            btnStop.Text = "Detener";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmReloj form1 = new frmReloj();
            this.Close();
            form1.Show();
        }
    }
}
