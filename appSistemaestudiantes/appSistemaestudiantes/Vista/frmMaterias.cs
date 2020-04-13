using appSistemaestudiantes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaestudiantes.Vista
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            cargardatos();
        }

        void cargardatos()
        {
            dvgMaterias.Rows.Clear();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var materias = db.materias;
                foreach (var iterardatosEstudiantes in materias)
                {

                    dvgMaterias.Rows.Add(iterardatosEstudiantes.id_materia, iterardatosEstudiantes.nombre_materia);
                }
                //dvgUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }
        void limpiardatos()
        {
            txtMateria.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            materia M = new materia();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                M.nombre_materia = txtMateria.Text;
                db.materias.Add(M);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            materia M = new materia();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgMaterias.CurrentRow.Cells[0].Value.ToString();

                M = db.materias.Find(int.Parse(Id));
                db.materias.Remove(M);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            materia M = new materia();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgMaterias.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                M = db.materias.Where(VerificarId => VerificarId.id_materia == IdC).First();
                M.nombre_materia = txtMateria.Text;
                db.Entry(M).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void dvgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dvgMaterias.CurrentRow.Cells[1].Value.ToString();
            txtMateria.Text = nombre;
        }
    }
}
