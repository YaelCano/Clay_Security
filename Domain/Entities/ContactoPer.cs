using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContactoPer : BaseEntity
    {
        public int IdTPersona {get; set;}
        public int IdTContactoFK {get; set;}
    }
}
