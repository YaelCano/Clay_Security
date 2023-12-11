using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public ICollection<Rol> roles {get; set;}
        public ICollection<RefreshToken> RefreshTokens {get; set;}
        public ICollection<UserRol> Users { get; set;}




    }
}
