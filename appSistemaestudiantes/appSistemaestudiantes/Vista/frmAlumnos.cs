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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            cargardatos();
        }
        
        void cargardatos()
        {
            dvgEstudiantes.Rows.Clear();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var estudiantes = db.estudiantes;
                foreach (var iterardatosEstudiantes in estudiantes)
                {
                    
                    dvgEstudiantes.Rows.Add(iterardatosEstudiantes.id_estudiante, iterardatosEstudiantes.nombre_estudiante, 
                        iterardatosEstudiantes.apellido, iterardatosEstudiantes.usuario, iterardatosEstudiantes.contrasena);
                }
                //dvgUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }
        void limpiardatos()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estudiante Student = new estudiante();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                Student.nombre_estudiante = txtNombre.Text;
                Student.apellido = txtApellido.Text;
                Student.usuario = txtUsuario.Text;
                Student.contrasena = txtPass.Text;
                db.estudiantes.Add(Student);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }
    

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estudiante Student = new estudiante();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgEstudiantes.CurrentRow.Cells[0].Value.ToString();

                Student = db.estudiantes.Find(int.Parse(Id));
                db.estudiantes.Remove(Student);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estudiante Student = new estudiante();
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                string Id = dvgEstudiantes.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                Student = db.estudiantes.Where(VerificarId => VerificarId.id_estudiante == IdC).First();
                Student.nombre_estudiante = txtNombre.Text;
                Student.apellido = txtApellido.Text;
                Student.usuario = txtUsuario.Text;
                Student.contrasena = txtPass.Text;
                db.Entry(Student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void dvgEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dvgEstudiantes.CurrentRow.Cells[1].Value.ToString();
            String apellido = dvgEstudiantes.CurrentRow.Cells[2].Value.ToString();
            String usuario = dvgEstudiantes.CurrentRow.Cells[3].Value.ToString();
            String pass = dvgEstudiantes.CurrentRow.Cells[4].Value.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtUsuario.Text = usuario;
            txtPass.Text = pass;
        }
    }
}
