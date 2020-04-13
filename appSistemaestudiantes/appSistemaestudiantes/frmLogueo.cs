using appSistemaestudiantes.Model;
using appSistemaestudiantes.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaestudiantes
{
    public partial class frmLogueo : Form
    {
        public frmLogueo()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var lista = from usuario in db.estudiantes
                            where usuario.usuario == txtUsuario.Text
                            && usuario.contrasena == txtPass.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El Usuario no existe");
                }
            }
        }
    }
}
