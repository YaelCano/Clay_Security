using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DirPersona : BaseEntity
    {
        public string direccion {get; set;}
        public int IdPersonaFk {get; set;}
        public int IdTipoDireccionFk {get; set;}
        public Persona Persona {get; set;}
    }
}
