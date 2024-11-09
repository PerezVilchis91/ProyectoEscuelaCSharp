using pjGestionEscuela.Datos;
using pjGestionEscuela.Entidades;
using pjGestionEscuela.presentacion.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjGestionEscuela
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        #region "variables"
        int icodigoAlumno = 0;
        bool bEstadoGuardar=true;
        #endregion
        #region "Metodos"
        private void CargarAlumnos(string cBusqueda)
        {
            D_Alumnos Datos= new D_Alumnos();
            dgvLista.DataSource = Datos.ListarAlumnos(cBusqueda);
            FormaListaAlumnos();
        }
        private void FormaListaAlumnos()
        {
            dgvLista.Columns[0].Width=45;
            dgvLista.Columns[1].Width = 180;
            dgvLista.Columns[2].Width = 130;
            dgvLista.Columns[3].Width = 130;
            dgvLista.Columns[4].Width = 70;
        }
        
        private void CargarCursos()
        {
            D_Cursos Datos= new D_Cursos();
            cmbCursos.DataSource = Datos.ListarCursos();
            cmbCursos.ValueMember = "id_curso";
            cmbCursos.DisplayMember = "nombre_curso";
            cmbCursos.SelectedIndex = -1;

        }
        private void CargarHorarios()
        {
            D_Horarios Datos= new D_Horarios();
            cmbHorario.DataSource=Datos.ListarHorarios();
            cmbHorario.ValueMember = "id_horarios";
            cmbHorario.DisplayMember = "nombre_horario";
            cmbHorario.SelectedIndex = -1;

        }
        private void ActivarTextos(bool bEstado)
        {
            txtNombre.Enabled=bEstado;
            txtEdad.Enabled=bEstado;
            txtTelefono.Enabled=bEstado;
            txtCorreo.Enabled=bEstado;
            dtpFechaNacimiento.Enabled=bEstado;
            cmbHorario.Enabled=bEstado;
            cmbCursos.Enabled=bEstado;

            txtBuscar.Enabled=!bEstado;
        }
        private void ActivarBoton(bool bEstado)
        {
            btnNuevo.Enabled=bEstado;
            btnActualizar.Enabled=bEstado;
            btnEliminar.Enabled=bEstado;
            btnReporte.Enabled=bEstado;

            btnGuardar.Visible=!bEstado;
            btnCancelar.Visible=!bEstado;
        }

        private void SeleccionarAlumno()
        {
            
            icodigoAlumno = Convert.ToInt32(dgvLista.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(dgvLista.CurrentRow.Cells["NOMBRE"].Value);
            txtEdad.Text= Convert.ToString(dgvLista.CurrentRow.Cells["EDAD"].Value);
            txtTelefono.Text= Convert.ToString(dgvLista.CurrentRow.Cells["TELEFONO"].Value);
            dtpFechaNacimiento.Value= Convert.ToDateTime(dgvLista.CurrentRow.Cells["Fecha Nac"].Value);
            cmbHorario.Text = Convert.ToString(dgvLista.CurrentRow.Cells["HORARIO"].Value);
            cmbCursos.Text= Convert.ToString(dgvLista.CurrentRow.Cells["Curso"].Value);
            txtCorreo.Text = Convert.ToString(dgvLista.CurrentRow.Cells["CORREO"].Value);

        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCursos.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
            icodigoAlumno = 0;
        
        }
        private void GuardarAlumno()
        {
            E_Alumno Alumno= new E_Alumno();
            Alumno.Nombre_Alumno=txtNombre.Text;
            Alumno.Edad_Alumno=int.Parse(txtEdad.Text);
            Alumno.Telefono_Alumno=txtTelefono.Text;
            Alumno.Fecha_Nacimiento_Alumno = dtpFechaNacimiento.Value;
            Alumno.Correo_Alumno=txtCorreo.Text;
            Alumno.ID_Curso = Convert.ToInt32(cmbCursos.SelectedValue);
            Alumno.ID_Horario=Convert.ToInt32(cmbHorario.SelectedValue);

            D_Alumnos Datos= new D_Alumnos();
            string respuesta = Datos.GuardarAlumno(Alumno);

            if (respuesta == "OK")
            {
                CargarAlumnos("%");
                LimpiarFormulario();
                ActivarTextos(false);
                ActivarBoton(false);
                MessageBox.Show("Datos guardados","Gestion De Alumnos",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Gestion De Alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void ActualizarAlumno()
        {
            E_Alumno Alumno = new E_Alumno();
            Alumno.ID_Alumno = icodigoAlumno;
            Alumno.Nombre_Alumno = txtNombre.Text;
            Alumno.Edad_Alumno = int.Parse(txtEdad.Text);
            Alumno.Telefono_Alumno = txtTelefono.Text;
            Alumno.Fecha_Nacimiento_Alumno = dtpFechaNacimiento.Value;
            Alumno.Correo_Alumno = txtCorreo.Text;
            Alumno.ID_Curso = Convert.ToInt32(cmbCursos.SelectedValue);
            Alumno.ID_Horario = Convert.ToInt32(cmbHorario.SelectedValue);

            D_Alumnos Datos = new D_Alumnos();
            string respuesta = Datos.Actualizar_Alumno(Alumno);

            if (respuesta == "OK")
            {
                CargarAlumnos("%");
                LimpiarFormulario();
                ActivarTextos(false);
                ActivarBoton(false);
                MessageBox.Show("Datos actualizados", "Gestion De Alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Gestion De Alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void DesactivarAlumno(int iCodigoAlumno)
        {
            D_Alumnos Datos = new D_Alumnos();
            string respuesta = Datos.Desactivar_Alumno(icodigoAlumno);

            if (respuesta == "OK")
            {
                CargarAlumnos("%");
                LimpiarFormulario();
                ActivarTextos(false);
                ActivarBoton(false);
                MessageBox.Show("Registro Eliminado", "Gestion De Alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Gestion De Alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private bool ValidarTextos()
        {
            bool hayTextoVacio = false;
            if (string.IsNullOrEmpty(txtNombre.Text)) hayTextoVacio=true;
            if (string.IsNullOrEmpty(txtTelefono.Text)) hayTextoVacio = true;
            if (string.IsNullOrEmpty(txtEdad.Text)) hayTextoVacio = true;

            return hayTextoVacio;
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos("%");
            CargarCursos();
            CargarHorarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarAlumnos(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            bEstadoGuardar =true;
            icodigoAlumno = 0;
            ActivarTextos(true);
            ActivarBoton(false);
            txtNombre.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bEstadoGuardar =true;
            icodigoAlumno = 0;
            ActivarTextos(false);
            ActivarBoton(true);
            LimpiarFormulario();
            
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarAlumno();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (icodigoAlumno == 0)
            {
                MessageBox.Show("Selecciona un registro", "sistema de gestion de alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else 
            {
                bEstadoGuardar = false;
                ActivarTextos(true);
                ActivarBoton(false);
                txtNombre.Focus();
            }
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (ValidarTextos())
            {
                MessageBox.Show("Hay campos vacios, debes llenar los campos (*) obligatorios",
                    "Gestion de Alumnos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (bEstadoGuardar == true)
                {
                    GuardarAlumno();
                }
                else 
                {
                    ActualizarAlumno();
                }
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (icodigoAlumno == 0)
            {
                MessageBox.Show("Selecciona un registro", "sistema de gestion de alumnos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro de eliminar este registro?",
                    "Gestion de Alumnos",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes) 
                {
                    DesactivarAlumno(icodigoAlumno);
                }
            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteAlumnos formReporteAlumnos=new frmReporteAlumnos();
            formReporteAlumnos.txtFiltrar.Text=txtBuscar.Text;
            formReporteAlumnos.ShowDialog();
        }
    }
}
