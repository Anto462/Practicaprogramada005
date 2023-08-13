using System;
using System.Collections.Generic;

namespace Practicaprogramada005.Models
{
    public partial class Solicitude
    {
        public int SolicitudesId { get; set; }
        public int ServiciosId { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Datsauto1 { get; set; } = null!;
        public string Datsauto2 { get; set; } = null!;
        public string Datsauto3 { get; set; } = null!;
        public string Datsauto4 { get; set; } = null!;
        public string Estadode { get; set; } = null!;

        public virtual Servicio Servicios { get; set; } = null!;
    }
}
