using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap <Pais, PaisDto>();
            CreateMap <Persona, PersonaDto>();
            CreateMap <CategoriaPer, CategoriaPerDto>();
            CreateMap <Contrato, ContratoDto>();
            CreateMap <Cuidad, CuidadDto>();
            CreateMap <Departamento, DepartamentoDto>();
            CreateMap <DirPersona, DirPersonaDto>();
            CreateMap <Estado, EstadoDto>();
            CreateMap <Programacion, ProgramacionDto>();
            CreateMap <TipoContacto, TipoContactoDto>();
            CreateMap <TipoDireccion, TipoDireccionDto>();
            CreateMap <TipoPersona, TipoPersonaDto>();
            CreateMap <Turnos, TurnosDto>();
        }
    }
}
