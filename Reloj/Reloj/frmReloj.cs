using System;
using System.Collections.Generic;
using System.Media;
using System.Timers;
using System.Windows.Forms;

namespace Reloj
{
    public partial class frmReloj : Form
    {
        private DateTime horaAlarma;
        private List<DayOfWeek> diasAlarma;
        private System.Timers.Timer timerAlarma;
        private SoundPlayer player;

        public frmReloj()
        {
            InitializeComponent();
            player = new SoundPlayer();
            InicializarTimerAlarma();
        }

        private void InicializarTimerAlarma()
        {
            timerAlarma = new System.Timers.Timer();
            timerAlarma.Interval = 1000; // Verificar cada segundo
            timerAlarma.Elapsed += TimerAlarma_Elapsed;
            timerAlarma.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualizar el Label con la hora actual
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void TimerAlarma_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (diasAlarma != null && diasAlarma.Contains(DateTime.Now.DayOfWeek) && DateTime.Now.TimeOfDay >= horaAlarma.TimeOfDay)
            {
                timerAlarma.Stop();
                player.SoundLocation = "O:\\Reloj\\Reloj\\Reloj\\Alarma.wav"; // Especifica la ruta del archivo de sonido
                player.Play();
                this.Invoke(new Action(() => MostrarFormularioAlarma()));
            }
        }

        private void MostrarFormularioAlarma()
        {
            frmAlarmaAlerta alerta = new frmAlarmaAlerta();
            if (alerta.ShowDialog() == DialogResult.OK)
            {
                // Aceptar: Parar la alarma
                player.Stop();
            }
            else
            {
                // Posponer: Agregar 5 minutos a la hora de la alarma
                horaAlarma = horaAlarma.AddMinutes(5);
                player.Stop();
                timerAlarma.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTemporizador form2 = new frmTemporizador();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            frmCronometro form3 = new frmCronometro();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            frmPomodoro form4 = new frmPomodoro();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            frmAlarma form5 = new frmAlarma();
            if (form5.ShowDialog() == DialogResult.OK)
            {
                horaAlarma = form5.HoraAlarma;
                diasAlarma = form5.DiasAlarma;
            }
        }
    }
}
