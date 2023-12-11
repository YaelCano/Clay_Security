using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRol
    {
        public int UsarioId {get; set;}
        public User Usario {get; set;}
        public int RolId {get; set;}
        public Rol Rol {get; set;}
    }
}