using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : BaseEntity
    {
        public string nombre {get; set;}
        public DateOnly dateReg {get; set;}
        public int IdCategoria {get; set;}
        public int IdCuidad {get; set;}
        public int IdTPersona {get; set;}
        public ICollection<CategoriaPer> categorias {get; set;}
        public ICollection<ContactoPer> contacto {get; set;}
        public ICollection<TipoPersona> tipoPersonas {get; set;}
    }
}
