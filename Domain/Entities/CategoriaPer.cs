using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoriaPer : BaseEntity
    {
        public string NombreCat {get; set;}
        public ICollection<Persona> personas {get; set;}
    }
}
