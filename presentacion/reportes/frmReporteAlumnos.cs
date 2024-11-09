using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjGestionEscuela.presentacion.reportes
{
    public partial class frmReporteAlumnos : Form
    {
        public frmReporteAlumnos()
        {
            InitializeComponent();
        }

        private void frmReporteAlumnos_Load(object sender, EventArgs e)
        {
            this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSet.SP_LISTAR_ALUMNOS,cBUSQUEDA: txtFiltrar.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
