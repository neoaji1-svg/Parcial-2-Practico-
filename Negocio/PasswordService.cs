using System.Security.Cryptography;
using System.Text;

namespace Negocio
{
    public class PasswordService : IHashService, IVerificarHashService
    {
        public string GenerarHash(string textoPlano)
        {
            // Lógica para generar SHA-512 si se requiere en negocio
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public bool Verificar(string textoPlano, string hashAlmacenado)
        {
            string hashGenerado = GenerarHash(textoPlano);
            return hashGenerado.Equals(hashAlmacenado, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
