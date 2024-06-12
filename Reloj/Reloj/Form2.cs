using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class Form2 : Form
    {
        private DateTime startTime;
        private int countdownTime;
        public Form2()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer2.Interval = 1000; // Intervalo de 1 segundo
            timer2.Tick += Timer2_Tick;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Reducir el tiempo
            countdownTime--;

            if (countdownTime <= 0)
            {
                timer2.Stop();
                lblTimer.Text = "Tiempo terminado";
                MessageBox.Show("¡El tiempo se ha acabado!");
            }
            else
            {
                // Calcular horas, minutos y segundos restantes
                int hours = countdownTime / 3600;
                int minutes = (countdownTime % 3600) / 60;
                int seconds = countdownTime % 60;

                // Actualizar el label con el tiempo restante
                lblTimer.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            string[] timeParts = txtTime.Text.Split(':');

            if (timeParts.Length == 3 &&
                int.TryParse(timeParts[0], out int hours) &&
                int.TryParse(timeParts[1], out int minutes) &&
                int.TryParse(timeParts[2], out int seconds) &&
                hours >= 0 && hours < 24 &&
                minutes >= 0 && minutes < 60 &&
                seconds >= 0 && seconds < 60)
            {
                countdownTime = hours * 3600 + minutes * 60 + seconds;
                lblTimer.Text = txtTime.Text;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tiempo válido en el formato HH:mm:ss.");
            }
        }
    }
}
