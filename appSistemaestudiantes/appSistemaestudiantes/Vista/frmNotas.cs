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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
            cargardatos();
        }
        void cargardatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var jointables = from tbalumn in db.estudiantes
                                 from tbmateria in db.materias
                                 from tbnota in db.notas
                                 where tbalumn.id_estudiante == tbnota.id_estudiante && tbmateria.id_materia == tbnota.id_materia

                                 select new
                                 {
                                     Id = tbnota.id_notas,
                                     Id_Alumno = tbalumn.id_estudiante,
                                     Nombre_Alumno = tbalumn.nombre_estudiante + " " + tbalumn.apellido,
                                     Id_Materia = tbmateria.id_materia,
                                     Materia = tbmateria.nombre_materia,
                                     Nota = tbnota.nota1

                                 };
                dvgNotas.DataSource = jointables.ToList();
                dvgNotas.Columns[1].Visible = false;
                dvgNotas.Columns[3].Visible = false;
            }
        }
        void limpiardatos()
        {
            txtIdA.Text = "";
            txtIdM.Text = "";
            txtNota.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nota note = new nota();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgNotas.CurrentRow.Cells[0].Value.ToString();

                note = db.notas.Find(int.Parse(Id));
                db.notas.Remove(note);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nota note = new nota();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                note.id_estudiante = Convert.ToInt32(txtIdA.Text);
                note.id_materia = Convert.ToInt32(txtIdM.Text);
                note.nota1 = Convert.ToInt32(txtNota.Text);
                db.notas.Add(note);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nota note = new nota();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgNotas.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                note = db.notas.Where(VerificarId => VerificarId.id_notas == IdC).First();
                note.id_estudiante = Convert.ToInt32(txtIdA.Text);
                note.id_materia = Convert.ToInt32(txtIdM.Text);
                note.nota1 = Convert.ToInt32(txtNota.Text);
                db.Entry(note).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void dvgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String IdA = dvgNotas.CurrentRow.Cells[1].Value.ToString();
            String IdM = dvgNotas.CurrentRow.Cells[3].Value.ToString();
            String Nota = dvgNotas.CurrentRow.Cells[5].Value.ToString();
            txtIdA.Text = IdA;
            txtIdM.Text = IdM;
            txtNota.Text = Nota;
        }
    }
}
