using BCrypt.Net;
using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string email;
        private string clave;
        private int rolId;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Clave { get => clave; set => clave = value; }
        public int RolId { get => rolId; set => rolId = value; }

        public bool RegistrarUsuario()
        {
            try
            {
                SqlConnection conn = ConexionDB.Conectar();
                string queryhas = "INSERT INTO Usuarios(Nombre, Email,clave,RolId) VALUES(@Nombre, @Email, @clave,@RolId)";
                SqlCommand insertar = new SqlCommand(queryhas, conn);
                insertar.Parameters.AddWithValue("@Nombre", Nombre);
                insertar.Parameters.AddWithValue("@Email", Email);
                insertar.Parameters.AddWithValue("@clave", Clave);
                insertar.Parameters.AddWithValue("@RolId", RolId);
                insertar.ExecuteNonQuery();
                return true;


            }
            catch (Exception)
            {
                MessageBox.Show("Este usuario ya existe, ultilza otro correo electronico");
                return false;


            }
        }



        public bool VerificarLogin(string correo, string clave)
        {

            //La varibale hash sirve para guardar y recuperar la contraseña
            //y poder comparar con lo que estoy escribiendo en mi textbox

            string hashEnBaseDeDatos = "";
            SqlConnection conn = ConexionDB.Conectar();
            string query = "SELECT clave From Usuarios WHERE Email= @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", correo);
            //ExecuteScalar es el metodo que ejecuta al servidor la peticion query y devuelve un valor
            //en este caso delvolvera el valor de la contraseña segun el correo que mande
            //prueba agregrando lo siguiente
            //MessageBox.Show("executeescalar" + cmd.ExecuteScalar());


            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {

                //Aqui lo que se hace es lo siguiente
                //la variable guarda el valor que trae la peticion que hice a la base de datos
                //Tostring() me ayuda a convertir el tipo de dato
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();

                //Aqui puedo hacer 2 cosas guardar el valor de la funcion
                //Bcrypt.Net.Bcrypt.verify() -> Esta funcion es de la libreria que descargamos;
                //en una variable o mandarla directamente
                //clave es el parametro o el dato que se pide en el form
                //por eso este metodo pide 2 argumentos correo y clave
                // asi validar ,hashEnBaseDeDatos compara el valor del hash que esta almacenado en la base
                //de datos con el valor que ingrese
                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);

            }





        }


        public static DataTable cargarRoles()
        {
            SqlConnection conn = ConexionDB.Conectar();
            string querycargar = "select Id,Nombre from Roles;";
            SqlDataAdapter dt = new SqlDataAdapter(querycargar, conn);
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;




        }







    }
}
