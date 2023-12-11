using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre {get; set;}
        public DateOnly FechaRegistro {get; set;}
        public int IdCategoriaFk {get; set;}
        public int IdCuidadFk {get; set;}
        public int IdTPersonaFk {get; set;}
        public DirPersona DirPersona {get; set;}
        public ICollection<Contrato> Contratos {get; set;}

        public ICollection<ContactoPer> contacto {get; set;}
        public ICollection<DirPersona> DirPersonas {get; set;}
        public ICollection<Programacion> Programacions {get; set;}
        public Cuidad Cuidad {get; set;}
        public CategoriaPer Categoria {get; set;}
        public TipoPersona TipoPersona {get; set;}

    
    }
}
