using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Practicaprogramada005.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Solicitudes = new HashSet<Solicitude>();
        }

        [Key]
        [DisplayName("ID Servicio")]
        public int ServiciosId { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; } = null!;

        [DisplayName("Costo")]
        public int Costo { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
