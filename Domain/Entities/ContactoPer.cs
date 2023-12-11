using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContactoPer : BaseEntity
    {
        public string descripcion {get; set;}
        public int IdTPersonaFk {get; set;}
        public int IdTContactoFK {get; set;}
        public Persona Persona {get; set;}
        public TipoContacto TipoContacto {get; set;}
    }
}
