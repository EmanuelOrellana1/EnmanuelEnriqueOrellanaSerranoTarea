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
    public partial class frmIngresarNotasEstudiantes : Form
    {
        public frmIngresarNotasEstudiantes()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtIdMateria.Text = "";
            txtIdEstudiantes.Text = "";
            txtIdNotas.Text = "";
            txtNota.Text = "";
        }

        public void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var inerjoin = from not5 in db.notas
                               from est in db.estudiante
                               from mat4 in db.materia
                               where not5.id_estudiante == est.id_estudiante
                               where not5.id_materia == mat4.id_maeria
                               select new
                               {
                                   Id = not5.id_notas,
                                   nombreestudiante = est.nombre_estudiante,
                                   materia= mat4.nombre_materia,
                                   nota = not5.notas1
                             
                               };
                foreach(var iterar in inerjoin)
                {
                    dtvNotas.Rows.Add(iterar.Id, iterar.nombreestudiante, iterar.materia, iterar.nota);
                }
                              
            }
        }

        notas nt = new notas();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                nt.id_estudiante = int.Parse(txtIdEstudiantes.Text);
                nt.id_materia = int.Parse(txtIdMateria.Text);
                nt.notas1 = int.Parse(txtNota.Text);
               

                db.notas.Add(nt);
                db.SaveChanges();

            }
            dtvNotas.Rows.Clear();
            limpiar();
            cargardatos();

        }

        private void frmIngresarNotasEstudiantes_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdEstudiantes = dtvNotas.CurrentRow.Cells[1].Value.ToString();
            string IdMateria = dtvNotas.CurrentRow.Cells[2].Value.ToString();
            string Notas = dtvNotas.CurrentRow.Cells[3].Value.ToString();

            txtIdEstudiantes.Text = IdEstudiantes;
            txtIdMateria.Text = IdMateria;
            txtNota.Text = Notas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                string Notas = dtvNotas.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Notas);
                nt = db.notas.Where(verificarId => verificarId.id_notas == Idc).First();
                nt.notas1 = double.Parse(txtNota.Text);


                db.Entry(nt).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvNotas.Rows.Clear();
            limpiar();
            cargardatos();
        }
    }
}
