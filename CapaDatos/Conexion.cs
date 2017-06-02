using CapaDatos.DSConexionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {

        UsuarioTableAdapter oUsuario = new UsuarioTableAdapter();

        public int VerificarUsuario(string Usuario, string Contraseña)
        {
            try
            {
                return (int)oUsuario.AutenticarUsuario(Usuario, Contraseña);
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public int InsertarUsuarios(string tipoIdentificacion,int Id,string primerNombre,string segundoNombre,string primerApellido,string segundoApellido,string correo, string direccion,string telefonoMovil,string nickname,string  clave, int idRol)
        {

            try
            {
                return (int)oUsuario.InsertarUsuario(tipoIdentificacion, Id, primerNombre, segundoNombre, primerApellido, segundoApellido, correo, direccion, telefonoMovil, nickname, clave, idRol);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
