using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Zapato
    {
        private int idZapato;
        private int categoriaId;
        private string nombre;
        private double precio;
        private string imagenURL;
        private DateTime fechaCreacion;

        public int IdZapato { get => idZapato; set => idZapato = value; }
        public int CategoriaId { get => categoriaId; set => categoriaId = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string ImagenURL { get => imagenURL; set => imagenURL = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public static DataTable cargarZapatos() 
        {
            try
            {
                SqlConnection sqlConnection = Conexion.ConexionDB.Conectar();
                string cadena = "select * from vistaCategoria;";
                SqlDataAdapter data= new SqlDataAdapter(cadena, sqlConnection);
                DataTable tablavirtual = new DataTable();
                data.Fill(tablavirtual);
                return tablavirtual;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos" + ex);
                return null;

            }


        
        
        }

        //Metodo de InsertarDatos
        public bool InsertarZapato()
        {
            try
            {
                //siempre traer la conexion
                SqlConnection sqlConnection = ConexionDB.Conectar();
                string consultaQuery = "INSERT INTO Zapatos (CategoriaId,Nombre,Precio,ImagenURL,FechaCreacion) values (@CategoriaId,@Nombre,@Precio,@ImagenURL,@FechaCreacion);";
                SqlCommand insertar = new SqlCommand(consultaQuery, sqlConnection);
                //Vamos a insertar o sustituir los Qnombre con los datos que se obtienen en los txt
                
                //'1' or == 1'

                insertar.Parameters.AddWithValue("@CategoriaId", categoriaId);
                insertar.Parameters.AddWithValue("@Nombre",Nombre);
                insertar.Parameters.AddWithValue("@Precio",Precio);
                insertar.Parameters.AddWithValue("@ImagenURL",ImagenURL);
                insertar.Parameters.AddWithValue("@FechaCreacion",FechaCreacion);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Zapato insertado correctamente");
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta"+ex,"Error al insertar datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarZapatos( int id) 
        {

            try
            {

                SqlConnection conectar = ConexionDB.Conectar();
                string consultaDelete = "Delete from Zapatos where id=@id";
                SqlCommand delete= new SqlCommand(consultaDelete, conectar);
                delete.Parameters.AddWithValue("id",id);
                delete.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;


            }


        }

        public static DataTable Buscar(string termino)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando =
                "SELECT zapatos.id AS [N° de Registro], zapatos.nombre, categorias.nombre AS categoria " +
                "FROM zapatos " +
                "INNER JOIN categorias ON categorias.id = zapatos.CategoriaId " +
                $"WHERE zapatos.nombre LIKE '%{termino}%'";

            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }


        public bool ActualizarZapatos()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "UPDATE Zapatos SET Nombre=@nombre, Precio=@precio, ImagenURL=@imagen,  CategoriaId=@categoria, FechaCreacion=@fecha   WHERE id=@id";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@fecha", fechaCreacion);
            cmd.Parameters.AddWithValue("@categoria",categoriaId);
            cmd.Parameters.AddWithValue("@imagen", imagenURL);
            cmd.Parameters.AddWithValue("@id", idZapato);


            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;

            }





    }


    

}



}

