using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmanuelOrellana.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEstudiantes DE = new frmDatosEstudiantes();
            DE.Show();
        }

        private void mantenimientoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientodeMaterias MM = new frmMantenimientodeMaterias();
            MM.Show();
        }

        private void ingresarNotasEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresarNotasEstudiantes NE = new frmIngresarNotasEstudiantes();
            NE.Show();
        }
    }
}
