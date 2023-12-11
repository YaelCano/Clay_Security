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
public class ProgramacionController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProgramacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Programacion>>> Get()
        {
            var entidades = await _unitOfWork.Programacions.GetAllAsync();
            return _mapper.Map<List<Programacion>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProgramacionDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Programacions.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<ProgramacionDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Programacion>> Post(ProgramacionDto ProgramacionDto)
        {
            var entidad = _mapper.Map<Programacion>(ProgramacionDto);
            this._unitOfWork.Programacions.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            ProgramacionDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = ProgramacionDto.Id}, ProgramacionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProgramacionDto>> Put(int id, [FromBody] ProgramacionDto ProgramacionDto)
        {
            if(ProgramacionDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Programacion>(ProgramacionDto);
            _unitOfWork.Programacions.Update(entidades);
            await _unitOfWork.SaveAsync();
            return ProgramacionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Programacions.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Programacions.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
