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
    public partial class frmMantenimientodeMaterias : Form
    {
        public frmMantenimientodeMaterias()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtNombreMateria.Text = "";
        }

        public void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var mat1 = db.materia;
                foreach (var iterar in mat1)
                {
                   dtvMaterias.Rows.Add(iterar.id_maeria, iterar.nombre_materia);
                }




            }
        }
        materia mat = new materia();
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
               
                mat.nombre_materia = txtNombreMateria.Text;
                
                db.materia.Add(mat);
                db.SaveChanges();

            }
            dtvMaterias.Rows.Clear();
            limpiar();
            cargardatos();
        }

        private void dtvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = dtvMaterias.CurrentRow.Cells[0].Value.ToString();
            string nombreMateria = dtvMaterias.CurrentRow.Cells[1].Value.ToString();

            txtId.Text = Id;
            txtNombreMateria.Text = nombreMateria;
        }

        private void frmMantenimientodeMaterias_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                string Id = dtvMaterias.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                mat = db.materia.Where(verificarId => verificarId.id_maeria == Idc).First();
                mat.nombre_materia = txtNombreMateria.Text;


                db.Entry(mat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            dtvMaterias.Rows.Clear();
            limpiar();
            cargardatos();

        }
    }
}
