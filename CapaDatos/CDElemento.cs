using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using CapaEntidades;

namespace CapaDatos
{
    public class CDElemento
    {
        // Conectamos a la base de datos
        public CDConexion Conexion = new CDConexion();

        // Las funciones de la base de datos
        // Mostrar
        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "Mostrar";
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                Conexion.CerrarConexion();
            }
            catch (Exception)
            {
                tabla = null; 
            }
            return tabla;
        }
        // Agregar
        public void agregar(CEElemento elemento)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "Agregar";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@codigoalumno", SqlDbType.VarChar).Value = elemento.CodigoAlumno;
                comando.Parameters.Add("@codigouniversidad", SqlDbType.Int).Value = elemento.CodigoUniversidad;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = elemento.Nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = elemento.Apellido;
                comando.Parameters.Add("@carrera", SqlDbType.VarChar).Value = elemento.Carrera;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = elemento.Numero;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("No puedes agregar datos con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Modificar
        public void modificar(CEElemento elemento)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "Modificar";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@codigoalumno", SqlDbType.VarChar).Value = elemento.CodigoAlumno;
                comando.Parameters.Add("@codigouniversidad", SqlDbType.Int).Value = elemento.CodigoUniversidad;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = elemento.Nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = elemento.Apellido;
                comando.Parameters.Add("@carrera", SqlDbType.VarChar).Value = elemento.Carrera;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = elemento.Numero;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            finally
            {
                //MessageBox.Show("No se pudo modificar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conexion.CerrarConexion();
            }
        }
        // Eliminar
        public DataTable eliminar(CEElemento elemento)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "Eliminar";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@codigoalumno", SqlDbType.VarChar).Value = elemento.CodigoAlumno;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        // Leer datos
        public CEElemento leerDatos(string codigoalumno)
        {
            CEElemento elemento = new CEElemento();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.AbrirConexion();
                comando.CommandText = "LeerDatos";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@codigoalumno", SqlDbType.VarChar).Value = codigoalumno;
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    elemento.CodigoAlumno = lector["CodigoAlumno"].ToString();
                    elemento.CodigoUniversidad = Convert.ToInt32(lector["CodigoUniversidad"].ToString());
                    elemento.Nombre = lector["Nombre"].ToString();
                    elemento.Apellido = lector["Apellido"].ToString();
                    elemento.Carrera = lector["Carrera"].ToString();
                    elemento.Numero = Convert.ToInt32(lector["Numero"].ToString());
                }
                return elemento;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
