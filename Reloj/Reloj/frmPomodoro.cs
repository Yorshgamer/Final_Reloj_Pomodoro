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
    public partial class frmPomodoro : Form
    {
        public frmPomodoro()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmReloj form1 = new frmReloj();
            this.Close();
            form1.Show();
        }
    }
}
