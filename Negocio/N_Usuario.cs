using Datos;
using Entidades;
using System;

namespace Negocio
{
    public class N_Usuario
    {
        public static E_Usuario? Login(string strUsuario, string strPassword)
        {
            return D_Usuario.Login(strUsuario, strPassword);
        }
    }
}
