using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmanuelOrellana.Model;
using EmanuelOrellana.Vista;

namespace EmanuelOrellana
{
    public partial class frmLogueo : Form
    {
        public frmLogueo()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var lista = from estudiantes in db.estudiante
                            where estudiantes.usuario == txtUsuario.Text
                            && estudiantes.contraseña == txtContraseña.Text
                            select estudiantes;

                if (lista.Count() > 0)
                {
                    frmMenu usu = new frmMenu();
                    usu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }



            }
        }
    }
}
