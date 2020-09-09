using System;

namespace QuintaApp.Models
{
    public class Usuario
    {
        public ushort idUsu { get; set; }
        public string nomeUsu { get; set; }
        public string obsUsu { get; set; }
        public DateTime nascUsu { get; set; }
        public string emailUsu { get; set; }
        public string loginUsu { get; set; }
        public string senhaUsu { get; set; }
        public string confirmarUsu { get; set; }
    }
}