using System;

namespace Entidades
{
    public class E_Usuario
    {
        public int id { get; set; }
        public string? dsId { get; set; }
        public string? dsUsuario { get; set; }
        public string? dsPassword { get; set; }
        public char dsEstado { get; set; }
        public string? dsUsuarioCreacion { get; set; }
        public DateTime dtFechaCreacion { get; set; }
        public string? idUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
