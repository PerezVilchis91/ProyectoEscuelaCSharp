using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjGestionEscuela.Datos
{
    public class D_Horarios
    {
        public DataTable ListarHorarios()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.CrearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_HORARIOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

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
    }
}
