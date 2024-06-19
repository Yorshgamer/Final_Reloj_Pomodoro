using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reloj
{
    public partial class Form5 : Form
    {
        public static List<Alarma> alarmas = new List<Alarma>();

        public Form5()
        {
            InitializeComponent();
            btnGuardarAlarma.Click += new EventHandler(btnGuardarAlarma_Click);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CargarAlarmas();
        }

        private void btnGuardarAlarma_Click(object sender, EventArgs e)
        {
            TimeSpan hora = new TimeSpan((int)numHoras.Value, (int)numMinutos.Value, 0);
            List<DayOfWeek> dias = new List<DayOfWeek>();

            if (chkLunes.Checked) dias.Add(DayOfWeek.Monday);
            if (chkMartes.Checked) dias.Add(DayOfWeek.Tuesday);
            if (chkMiercoles.Checked) dias.Add(DayOfWeek.Wednesday);
            if (chkJueves.Checked) dias.Add(DayOfWeek.Thursday);
            if (chkViernes.Checked) dias.Add(DayOfWeek.Friday);
            if (chkSabado.Checked) dias.Add(DayOfWeek.Saturday);
            if (chkDomingo.Checked) dias.Add(DayOfWeek.Sunday);

            Alarma nuevaAlarma = new Alarma(hora, dias);
            alarmas.Add(nuevaAlarma);

            CargarAlarmas();

            MessageBox.Show("Alarma guardada.");
            this.Close();
        }

        private void CargarAlarmas()
        {
            lstAlarmas.Items.Clear();
            foreach (var alarma in alarmas)
            {
                string dias = string.Join(", ", alarma.Dias);
                lstAlarmas.Items.Add($"{alarma.Hora:hh\\:mm} - {dias}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}