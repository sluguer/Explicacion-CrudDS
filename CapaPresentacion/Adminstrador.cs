using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Adminstrador : Form
    {
        public Adminstrador()
        {
            InitializeComponent();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.IngresarUsuarios(cboTipoIdentificacion.Text, int.Parse(txtIdentificaicon.Text), txtPrimernombre.Text,
                txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, txtDireccion.Text, 
                txtTelefono.Text, txtUsuario.Text, txtClave.Text, int.Parse(cboIdRol.Text));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
