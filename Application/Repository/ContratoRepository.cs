using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using Api.Repository; 
using Domain.Entities; 
using Domain.Interfaces; 
using Microsoft.EntityFrameworkCore; 
using Persistence.Data; 

namespace Application.Repository 
{ 
    public class ContratoRepository : GenericRepository<Contrato> , IContrato 
    { 
        public Clay_SecurityContext _context { get; set; } 
        public ContratoRepository(Clay_SecurityContext context) : base(context) 
        { 
            _context = context; 
        } 
    } 
} 
