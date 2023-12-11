using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : BaseEntity
    {
        public int IdCategoriaFk {get; set;}
        public int IdCuidadFk {get; set;}
        public int IdTPersonaFk {get; set;}
        public ICollection<Empleado> Empleados {get; set;}
        public ICollection<Cliente> Clientes {get; set;}
        public string Nombre {get; set;}
        public DateOnly FechaRegistro {get; set;}
        public DirPersona DirPersona {get; set;}
        public Cuidad Cuidad {get; set;}
        public CategoriaPer Categoria {get; set;}
        public TipoPersona TipoPersona {get; set;}
        public ICollection<Contrato> Contratos {get; set;}
        public ICollection<ContactoPer> ContactoPers {get; set;}
        public ICollection<DirPersona> DirPersonas {get; set;}
        public ICollection<Cliente> Cliente {get; set;}

    
    }
}
