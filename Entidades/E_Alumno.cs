using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjGestionEscuela.Entidades
{
    public class E_Alumno
    {
        public int ID_Alumno {  get; set; }
        public string Nombre_Alumno { get; set; }
        public string Correo_Alumno { get; set; }
        public DateTime Fecha_Nacimiento_Alumno { get; set; }
        public string Telefono_Alumno { get; set; }
        public int Edad_Alumno { get; set; }
        public int ID_Curso { get; set; }
        public int ID_Horario { get; set; }

    }
}
