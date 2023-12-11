using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento : BaseEntity
    {
        public string NombreDep {get; set;}
        public int IdpaisFk {get; set;}
        public Pais Pais {get; set;}
        public ICollection<Cuidad> Cuidads  {get; set;}
    }
}
