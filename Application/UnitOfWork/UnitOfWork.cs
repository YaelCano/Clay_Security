using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;
namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly Clay_SecurityContext _context;
    public UnitOfWork(Clay_SecurityContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    private ICategoriaPer _categoriapers;
    private IContactoPer _contactopers;
    private IContrato _contratos;
    private ICuidad _cuidads;
    private IDepartamento _departamentos;
    private IDirPersona _dirpersonas;
    private IEstado _estados;
    private IPais _paiss;
    private IPersona _personas;
    private IProgramacion _programacions;
    private ITipoContacto _tipocontactos;
    private ITipoDireccion _tipodireccions;
    private ITipoPersona _tipopersonas;
    private ITurnos _turnoss;
    public ICategoriaPer CategoriaPers {
        get
        {
            if(_categoriapers == null) 
            {
                _categoriapers = new CategoriaPerRepository(_context);
            }
            return _categoriapers;
        }
    }
    public IContactoPer ContactoPers {
        get
        {
            if(_contactopers == null) 
            {
                _contactopers = new ContactoPerRepository(_context);
            }
            return _contactopers;
        }
    }
    public IContrato Contratos {
        get
        {
            if(_contratos == null) 
            {
                _contratos = new ContratoRepository(_context);
            }
            return _contratos;
        }
    }
    public ICuidad Cuidads {
        get
        {
            if(_cuidads == null) 
            {
                _cuidads = new CuidadRepository(_context);
            }
            return _cuidads;
        }
    }
    public IDepartamento Departamentos {
        get
        {
            if(_departamentos == null) 
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public IDirPersona DirPersonas {
        get
        {
            if(_dirpersonas == null) 
            {
                _dirpersonas = new DirPersonaRepository(_context);
            }
            return _dirpersonas;
        }
    }
    public IEstado Estados {
        get
        {
            if(_estados == null) 
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IPais Paiss {
        get
        {
            if(_paiss == null) 
            {
                _paiss = new PaisRepository(_context);
            }
            return _paiss;
        }
    }
    public IPersona Personas {
        get
        {
            if(_personas == null) 
            {
                _personas = new PersonaRepository(_context);
            }
            return _personas;
        }
    }
    public IProgramacion Programacions {
        get
        {
            if(_programacions == null) 
            {
                _programacions = new ProgramacionRepository(_context);
            }
            return _programacions;
        }
    }
    public ITipoContacto TipoContactos {
        get
        {
            if(_tipocontactos == null) 
            {
                _tipocontactos = new TipoContactoRepository(_context);
            }
            return _tipocontactos;
        }
    }
    public ITipoDireccion TipoDireccions {
        get
        {
            if(_tipodireccions == null) 
            {
                _tipodireccions = new TipoDireccionRepository(_context);
            }
            return _tipodireccions;
        }
    }
    public ITipoPersona TipoPersonas {
        get
        {
            if(_tipopersonas == null) 
            {
                _tipopersonas = new TipoPersonaRepository(_context);
            }
            return _tipopersonas;
        }
    }
    public ITurnos Turnoss {
        get
        {
            if(_turnoss == null) 
            {
                _turnoss = new TurnosRepository(_context);
            }
            return _turnoss;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
