using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Programacion : BaseEntity
    {
        public int IdContratoFk {get; set;}
        public int IdTurno {get; set;}
        public int IdEmpleado {get; set;}
        public ICollection<Contrato> contratos{get; set;}
        public ICollection<Turnos> Turnos{get; set;}
        public ICollection<Persona> Empleados{get; set;}
    }
}
