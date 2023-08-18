using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practicaprogramada005.Models
{
    public class Cliente
    {
        [Key]
        [DisplayName("Id")]
        public int IdCliente { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }

        [DisplayName("Edad")]
        public int Edad { get; set; }

        [DisplayName("Resindencia")]
        public string Resindencia { get; set; }
        [DisplayName("Cedula")]
        public string Cedula { get; set; }

        [DisplayName("Usuario")]
        public string Usuario { get; set; }


    }
}
