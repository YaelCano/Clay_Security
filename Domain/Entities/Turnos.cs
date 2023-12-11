using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Turnos : BaseEntity
    {
        public string nombreTurno { get; set; }
        public TimeOnly horaTurnoI {get; set;}
        public TimeOnly horaTurnoF {get; set;}
        
        public ICollection<Programacion> programacions {get; set;}
    }
}
