using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class CuidadController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CuidadController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Cuidad>>> Get()
        {
            var entidades = await _unitOfWork.Cuidads.GetAllAsync();
            return _mapper.Map<List<Cuidad>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CuidadDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Cuidads.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<CuidadDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Cuidad>> Post(CuidadDto CuidadDto)
        {
            var entidad = _mapper.Map<Cuidad>(CuidadDto);
            this._unitOfWork.Cuidads.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            CuidadDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = CuidadDto.Id}, CuidadDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CuidadDto>> Put(int id, [FromBody] CuidadDto CuidadDto)
        {
            if(CuidadDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Cuidad>(CuidadDto);
            _unitOfWork.Cuidads.Update(entidades);
            await _unitOfWork.SaveAsync();
            return CuidadDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Cuidads.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Cuidads.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
