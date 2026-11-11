using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public interface IVerificarHashService
    {
        bool Verificar(string textoPlano, string hashAlmacenado);
    }
}
