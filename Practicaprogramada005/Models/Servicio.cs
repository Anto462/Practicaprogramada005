using System;
using System.Collections.Generic;

namespace Practicaprogramada005.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Solicitudes = new HashSet<Solicitude>();
        }

        public int ServiciosId { get; set; }
        public string Nombre { get; set; } = null!;
        public int Costo { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
