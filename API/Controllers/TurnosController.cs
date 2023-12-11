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
public class TurnosController: BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TurnosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Turnos>>> Get()
        {
            var entidades = await _unitOfWork.Turnoss.GetAllAsync();
            return _mapper.Map<List<Turnos>>(entidades);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TurnosDto>> Get(int id)
        {
            var entidad = await _unitOfWork.Turnoss.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            return _mapper.Map<TurnosDto>(entidad);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Turnos>> Post(TurnosDto TurnosDto)
        {
            var entidad = _mapper.Map<Turnos>(TurnosDto);
            this._unitOfWork.Turnoss.Add(entidad);
            await _unitOfWork.SaveAsync();
            if(entidad == null)
            {
                return BadRequest();
            }
            TurnosDto.Id = entidad.Id;
            return CreatedAtAction(nameof(Post), new {id = TurnosDto.Id}, TurnosDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TurnosDto>> Put(int id, [FromBody] TurnosDto TurnosDto)
        {
            if(TurnosDto == null)
            {
                return NotFound();
            }
            var entidades = _mapper.Map<Turnos>(TurnosDto);
            _unitOfWork.Turnoss.Update(entidades);
            await _unitOfWork.SaveAsync();
            return TurnosDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _unitOfWork.Turnoss.GetByIdAsync(id);
            if(entidad == null)
            {
                return NotFound();
            }
            _unitOfWork.Turnoss.Delete(entidad);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
