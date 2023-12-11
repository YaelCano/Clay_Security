using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contrato : BaseEntity
    {
        public int IdClienteFk {get; set;}
        public int IdEmpleadoFk {get; set;}
        public int IdEstadoFk {get; set;}
        public DateOnly fechaContrato {get; set;}
        public DateOnly fechaFin {get; set;}

        public ICollection<Programacion>programacions {get; set;}
    }
}
