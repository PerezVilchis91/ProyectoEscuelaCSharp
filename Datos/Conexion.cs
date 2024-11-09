using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjGestionEscuela.Datos
{
    public class Conexion
    {
        private string Servidor;
        private string Base;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        //constructor
        private Conexion()
        {
            this.Servidor = "DESKTOP-G0D75RD";
            this.Base = "bd_gestion_alumnos";
            this.Usuario = "vilchis";
            this.Clave = "1234";
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena=new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server="+this.Servidor+
                                          ";Database="+this.Base+
                                          ";User Id="+this.Usuario+
                                          ";Password="+this.Clave;
            }
            catch (Exception ex)
            {
                Cadena=null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion CrearInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
        
    }
}
