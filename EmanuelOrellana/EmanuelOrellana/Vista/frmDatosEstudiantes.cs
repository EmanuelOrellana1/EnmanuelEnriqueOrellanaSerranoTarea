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

namespace EmanuelOrellana.Vista
{
    public partial class frmDatosEstudiantes : Form
    {
        public frmDatosEstudiantes()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtNombreEstudiante.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        public void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var es1 = db.estudiante;
                foreach (var iterar in es1)
                {
                    dtvEstudiantes.Rows.Add(iterar.id_estudiante, iterar.nombre_estudiante, iterar.apellido, iterar.usuario, iterar.contraseña);
                }




             }   
        }
        estudiante es = new estudiante();

        private void frmDatosEstudiantes_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                es.nombre_estudiante = txtNombreEstudiante.Text;
                es.apellido = txtApellido.Text;
                es.usuario = txtUsuario.Text;
                es.contraseña = txtContraseña.Text;

                db.estudiante.Add(es);
                db.SaveChanges();

            }
            dtvEstudiantes.Rows.Clear();
            limpiar();
            cargardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                string Id = dtvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                es = db.estudiante.Where(verificarId => verificarId.id_estudiante == Idc).First();
                es.nombre_estudiante = txtNombreEstudiante.Text;
                es.apellido = txtApellido.Text;
                es.usuario = txtUsuario.Text;
                es.contraseña = txtContraseña.Text;

                db.Entry(es).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


            }
            dtvEstudiantes.Rows.Clear();
            limpiar();
            cargardatos();

        }

        private void dtvEstudiantes_Click(object sender, EventArgs e)
        {
            string nombreEst = dtvEstudiantes.CurrentRow.Cells[1].Value.ToString();
            string Apellido = dtvEstudiantes.CurrentRow.Cells[2].Value.ToString();
            string Usuario = dtvEstudiantes.CurrentRow.Cells[3].Value.ToString();
            string Contraseña = dtvEstudiantes.CurrentRow.Cells[4].Value.ToString();

            txtNombreEstudiante.Text = nombreEst;
            txtApellido.Text = Apellido;
            txtUsuario.Text = Usuario;
            txtContraseña.Text = Contraseña;


        }
    }
}
