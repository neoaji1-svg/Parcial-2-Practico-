using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public interface IHashService
    {
        string GenerarHash(string textoPlano);
    }
}
