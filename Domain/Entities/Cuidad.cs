using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cuidad : BaseEntity
    {
        public string nombreCiu {get; set;}
        public int IdDepartamentoFk {get; set;}
        public Departamento Departamento {get; set;}
        public ICollection<Persona> Personas{get; set;}
    }
}
