using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Numerics;

namespace Reloj
{
    public partial class Form1 : Form
    {
        private SoundPlayer player; // Declara una instancia de SoundPlayer

        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayer(); // Inicializa el SoundPlayer

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
            foreach (var alarma in Form5.alarmas)
            {
                if (alarma.EsHoraDeSonar())
                {
                    SonarAlarma();
                    break;
                }
            }
        }

        private void SonarAlarma()
        {
            player.SoundLocation = @"O:\Reloj\Reloj\Reloj\Alarma.wav";
            player.PlayLooping(); // Reproduce el sonido en bucle

            FormAlarma formAlarma = new FormAlarma(); // Crea una instancia del nuevo formulario
            formAlarma.ShowDialog(); // Muestra el formulario modalmente

            // Cuando se cierra el formulario de alarma, detiene la reproducción del sonido
            player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Show();
        }
    }
}