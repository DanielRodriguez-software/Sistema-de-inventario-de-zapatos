using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmRegistrarUsuario : UserControl
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nombre = txtNombre.Text;
            user.Email = txtCorreo.Text;
            user.Clave = BCrypt.Net.BCrypt.HashPassword(txtContra.Text);
            user.RolId = Convert.ToInt32(cmbAsignarRoles.SelectedValue);

            if (user.RegistrarUsuario() == true)
            {
                MessageBox.Show("Usuario registrado, bienvenido " + user.Nombre);
            }

        }


        private void cargarRoles()
        {
            cmbAsignarRoles.DataSource = null;
            cmbAsignarRoles.DataSource = Usuario.cargarRoles();
            cmbAsignarRoles.DisplayMember = "Nombre";
            cmbAsignarRoles.ValueMember = "id";



        }


        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
