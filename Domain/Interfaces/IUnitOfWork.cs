using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

    public interface IUnitOfWork
{
        ICategoriaPer CategoriaPers { get; }
        IContactoPer ContactoPers { get; }
        IContrato Contratos { get; }
        ICuidad Cuidads { get; }
        IDepartamento Departamentos { get; }
        IDirPersona DirPersonas { get; }
        IEstado Estados { get; }
        IPais Paiss { get; }
        IPersona Personas { get; }
        IProgramacion Programacions { get; }
        ITipoContacto TipoContactos { get; }
        ITipoDireccion TipoDireccions { get; }
        ITipoPersona TipoPersonas { get; }
        ITurnos Turnoss { get; }
        Task<int> SaveAsync();
}
