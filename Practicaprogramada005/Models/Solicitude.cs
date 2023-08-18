using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Practicaprogramada005.Models
{
    public partial class Solicitude
    {
        [Key]
        [DisplayName("ID Solicitud")]
        public int SolicitudesId { get; set; }

        [DisplayName("ID Servicio")]
        public int ServiciosId { get; set; }

        [DisplayName("ID Usuario")]
        public string Idusuario { get; set; } = null!;

        [DisplayName("Dato 1")]
        public string Datsauto1 { get; set; } = null!;

        [DisplayName("Dato 2")]
        public string Datsauto2 { get; set; } = null!;

        [DisplayName("Dato 3")]
        public string Datsauto3 { get; set; } = null!;

        [DisplayName("Dato 4")]
        public string Datsauto4 { get; set; } = null!;

        [DisplayName("Estado")]
        public string Estadode { get; set; } = null!;
        [DisplayName("Mecanico")]
        public string Mecanico { get; set; } = null!;

        public virtual Servicio Servicios { get; set; } = null!;
    }
}
