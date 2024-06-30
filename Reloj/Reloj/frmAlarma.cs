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
    public partial class frmAlarma : Form
    {
        public DateTime HoraAlarma { get; private set; }
        public List<DayOfWeek> DiasAlarma { get; private set; }

        public frmAlarma()
        {
            InitializeComponent();
            InicializarControles();
            DiasAlarma = new List<DayOfWeek>();
        }
        private void InicializarControles()
        {
            // Inicializar ComboBox de Horas
            for (int i = 0; i < 24; i++)
            {
                cbHoras.Items.Add(i.ToString("00"));
            }

            // Inicializar ComboBox de Minutos
            for (int i = 0; i < 60; i++)
            {
                cbMinutos.Items.Add(i.ToString("00"));
            }

            cbHoras.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;

            // Inicializar CheckedListBox con días de la semana
            clbDias.Items.Add("Lunes");
            clbDias.Items.Add("Martes");
            clbDias.Items.Add("Miércoles");
            clbDias.Items.Add("Jueves");
            clbDias.Items.Add("Viernes");
            clbDias.Items.Add("Sábado");
            clbDias.Items.Add("Domingo");
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int hora = int.Parse(cbHoras.SelectedItem.ToString());
            int minuto = int.Parse(cbMinutos.SelectedItem.ToString());
            HoraAlarma = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);

            foreach (var item in clbDias.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Lunes":
                        DiasAlarma.Add(DayOfWeek.Monday);
                        break;
                    case "Martes":
                        DiasAlarma.Add(DayOfWeek.Tuesday);
                        break;
                    case "Miércoles":
                        DiasAlarma.Add(DayOfWeek.Wednesday);
                        break;
                    case "Jueves":
                        DiasAlarma.Add(DayOfWeek.Thursday);
                        break;
                    case "Viernes":
                        DiasAlarma.Add(DayOfWeek.Friday);
                        break;
                    case "Sábado":
                        DiasAlarma.Add(DayOfWeek.Saturday);
                        break;
                    case "Domingo":
                        DiasAlarma.Add(DayOfWeek.Sunday);
                        break;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
