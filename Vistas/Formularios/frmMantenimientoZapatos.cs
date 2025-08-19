using Modelos.Conexion;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vistas.Formularios
{
    public partial class frmMantenimientoZapatos : Form
    {
        public frmMantenimientoZapatos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoZapatos_Load(object sender, EventArgs e)
        {

            cargarEspecialidad();
            cargarZapatos();

        }

        private void cargarZapatos()
        {
            dgvAlmacen.DataSource = null;
            dgvAlmacen.DataSource = Zapato.cargarZapatos();
            //cargar dats en el datagriew
            dgvAlmacenActualizar.DataSource = null;
            dgvAlmacenActualizar.DataSource = Zapato.cargarZapatos();

        }



        private void cargarEspecialidad()
        {

            //Esto es para los combobox
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = Categoria.CargarCategoria();
            //Ahora voy a usar el displayMember
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            //El -1 sirve para que no aparezca nada al momento de cargar la lista
            cbCategoria.SelectedIndex = -1;

            //Tambien para el mismo pero con el form de actualizar
            cbCategoriaActualizar.DataSource = null;
            cbCategoriaActualizar.DataSource = Categoria.CargarCategoria();
            cbCategoriaActualizar.DisplayMember = "Nombre";
            cbCategoriaActualizar.ValueMember = "Id";
            cbCategoriaActualizar.SelectedIndex = -1;



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                Zapato zap = new Zapato();
                zap.Nombre = txtNombre.Text;
                zap.Precio = double.Parse(txtPrecio.Text);
                zap.FechaCreacion = dtpFechaRegistro.Value;
                zap.CategoriaId = Convert.ToInt32(cbCategoria.SelectedValue);
                zap.ImagenURL = "";
                zap.InsertarZapato();
                cargarZapatos();
                MessageBox.Show("Excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Zapato zapatoEliminar = new Zapato();
            int id = int.Parse(dgvAlmacen.CurrentRow.Cells[0].Value.ToString());
            string registroAEliminar = dgvAlmacen.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar un registro?\n" + registroAEliminar, "Advertencia elimininaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (zapatoEliminar.eliminarZapatos(id) == true)
                {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarZapatos();


                }

            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarZapatos()
        {
            dgvAlmacenActualizar.DataSource = null;


            dgvAlmacenActualizar.DataSource = Zapato.cargarZapatos();
        }



        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            Zapato z = new Zapato();
            z.Nombre = txtNombreActualizar.Text;
            z.Precio = double.Parse(txtPrecioActualizar.Text, CultureInfo.CurrentCulture);
            z.FechaCreacion = dtpFechaActualizar.Value;
            z.CategoriaId = Convert.ToInt32(cbCategoriaActualizar.SelectedValue);
            z.ImagenURL = "";
            z.IdZapato = int.Parse(dgvAlmacenActualizar.CurrentRow.Cells[0].Value.ToString());


            if (z.ActualizarZapatos() == true)
            {
                MostrarZapatos();



            }
            else
            {

                MessageBox.Show("Hubo un error", "Error");

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                dgvAlmacenActualizar.DataSource = null;
                dgvAlmacenActualizar.DataSource = Zapato.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }



        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dgvAlmacenActualizar.DataSource = null;
                dgvAlmacenActualizar.DataSource = Zapato.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }

        }

        private void dgvAlmacenActualizar_DoubleClick(object sender, EventArgs e)
        {
           txtNombreActualizar.Text = dgvAlmacenActualizar.CurrentRow.Cells[1].Value.ToString();    
          txtPrecioActualizar.Text = dgvAlmacenActualizar.CurrentRow.Cells[2].Value.ToString();
            


        }
    }
}
