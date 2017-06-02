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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();

            switch (oUser.AutenticarUsuario(txtUsuario.Text, txtClave.Text))
            {
                case 1:
                    Adminstrador oAdmin = new Adminstrador();
                    this.Hide();
                    oAdmin.Show();
                    break;
                case 2:
                    Empleado oEmple = new Empleado();
                    this.Hide();
                    oEmple.Show();
                    break;
                case 3:
                    Operario Opera = new Operario();
                    this.Hide();
                    Opera.Show();
                    break;
                case 4:
                    Aprendíz oApren = new Aprendíz();
                    this.Hide();
                    oApren.Show();
                    break;
                default:

                    MessageBox.Show("Usuario o Contraserña no Validos");
                    break;
            }
            

        }
    }
}
