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
    public partial class frmPrincipalRegistro : Form
    {



        //creamos los objetos afuera para que se peuda utilizar en cada metodo
        frmRegistrarUsuario frmRegistrarUsuario = new frmRegistrarUsuario();
        frnLogin frnLogin = new frnLogin();
        public frmPrincipalRegistro()
        {
            InitializeComponent();
        }

      

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            pnlPrincipal.Controls.Clear();
            //Aqui el formulario en mi proyecto lo tengo com,o frn
            //verifica el nombre que le pusiste para evitar errores
            pnlPrincipal.Controls.Add(frnLogin);


        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {


            //porque borramos antes de agregar el formulario de panel
            //Se hace para que no quede montado un formulario encima de otro
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmRegistrarUsuario);
        }

        private void frmPrincipalRegistro_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frnLogin);


        }
    }
}
