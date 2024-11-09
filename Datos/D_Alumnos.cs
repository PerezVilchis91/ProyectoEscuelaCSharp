using pjGestionEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjGestionEscuela.Datos
{
    public class D_Alumnos
    {
        public DataTable ListarAlumnos(string cBusqueda)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_ALUMNOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cBusqueda", SqlDbType.VarChar).Value = cBusqueda;
                SqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();   
            }

        }
    
        public string GuardarAlumno(E_Alumno Alumno)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_GUARDAR_ALUMNOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cNOMBRE", SqlDbType.VarChar).Value = Alumno.Nombre_Alumno;
                comando.Parameters.Add("@cCORREO", SqlDbType.VarChar).Value = Alumno.Correo_Alumno;
                comando.Parameters.Add("@cFECHA_NACIMIENTO", SqlDbType.Date).Value = Alumno.Fecha_Nacimiento_Alumno;
                comando.Parameters.Add("@cTELEFONO", SqlDbType.VarChar).Value = Alumno.Telefono_Alumno;
                comando.Parameters.Add("@nEDAD", SqlDbType.Int).Value = Alumno.Edad_Alumno;
                comando.Parameters.Add("@nID_CURSO", SqlDbType.Int).Value = Alumno.ID_Curso;
                comando.Parameters.Add("@nID_HORARIO", SqlDbType.Int).Value = Alumno.ID_Horario;

                SqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if(SqlCon.State==ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
        public string Actualizar_Alumno(E_Alumno Alumno)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_ALUMNOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nIDALUMNO", SqlDbType.Int).Value = Alumno.ID_Alumno;
                comando.Parameters.Add("@cNOMBRE", SqlDbType.VarChar).Value = Alumno.Nombre_Alumno;
                comando.Parameters.Add("@cCORREO", SqlDbType.VarChar).Value = Alumno.Correo_Alumno;
                comando.Parameters.Add("@cFECHA_NACIMIENTO", SqlDbType.Date).Value = Alumno.Fecha_Nacimiento_Alumno;
                comando.Parameters.Add("@cTELEFONO", SqlDbType.VarChar).Value = Alumno.Telefono_Alumno;
                comando.Parameters.Add("@nEDAD", SqlDbType.Int).Value = Alumno.Edad_Alumno;
                comando.Parameters.Add("@nID_CURSO", SqlDbType.Int).Value = Alumno.ID_Curso;
                comando.Parameters.Add("@nID_HORARIO", SqlDbType.Int).Value = Alumno.ID_Horario;

                SqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron actualizar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
        public string Desactivar_Alumno(int iCodigoAlumno)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_DESACTIVAR_ALUMNOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nIDALUMNO", SqlDbType.Int).Value = iCodigoAlumno;
               
                SqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron actualizar";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

    }
}
