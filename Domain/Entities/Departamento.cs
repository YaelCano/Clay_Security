using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento : BaseEntity
    {
        public string nombreDep {get; set;}
        public int IdpaisFk {get; set;}
        ICollection<Cuidad> ciudads  {get; set;}
    }
}
