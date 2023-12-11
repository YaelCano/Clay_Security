using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoDireccion : BaseEntity
    {
        public string descripcion {get; set;}
        public ICollection<DirPersona> dirPersonas {get; set;}
    }
}
