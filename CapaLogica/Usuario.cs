using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Usuario
    {
        Conexion oConexion = new Conexion();
        public int AutenticarUsuario(string usuario, string contraseña)
        {
            return oConexion.VerificarUsuario(usuario, contraseña);

        }
        public int IngresarUsuarios(string tipoIdentificacion, int Id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correo, string direccion, string telefonoMovil, string nickname, string clave, int idRol)
        {

            return oConexion.InsertarUsuarios(tipoIdentificacion, Id, primerNombre, segundoNombre, primerApellido, segundoApellido, correo, direccion, telefonoMovil, nickname, clave, idRol);
        }

    }
}
