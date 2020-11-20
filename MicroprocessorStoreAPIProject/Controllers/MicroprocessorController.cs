using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MicroprocessorStoreAPIProject.Models;
using MicroprocessorStoreAPIProject.Services;
using MicroprocessorStoreLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroprocessorStoreAPIProject.Controllers
{
    [Route("api")]
    [ApiController]
    public class MicroprocessorController : ControllerBase
    {
        private IMicroprocessorStoreRepository _microprocessorStoreRepository;
        private readonly IMapper _mapper;

        public MicroprocessorController(IMicroprocessorStoreRepository microprocessorStoreRepository, IMapper mapper)
        {
            _microprocessorStoreRepository = microprocessorStoreRepository;
            _mapper = mapper;
        }

        // GET: /GetMicroprocessors
        [HttpGet]
        [Route("GetMicroprocessors")]
        public async Task<ActionResult<Microprocessor>> GetMicroprocessors()
        {
            var microprocessorEntities = await _microprocessorStoreRepository.GetMicroprocessors();

            var results = _mapper.Map<IEnumerable<MicroprocessorDto>>(microprocessorEntities);

            return Ok(results);
        }

        // GET /GetMicroprocessor/{id}
        [HttpGet]
        [Route("GetMicroprocessor/{id}")]
        public async Task<ActionResult<Store>> GetMicroprocessorById(int id)
        {
            var microprocessor = await _microprocessorStoreRepository.GetMicroprocessorById(id);

            if (microprocessor == null)
            {
                return NotFound();
            }

            var microprocessorResult = _mapper.Map<MicroprocessorDto>(microprocessor);
            return Ok(microprocessorResult);
        }

        // GET /GetMicroprocessorAvailabilities/{id}
        [HttpGet]
        [Route("GetMicroprocessorAvailabilities/{id}")]
        public async Task<ActionResult<Store>> GetMicroprocessorAvailabilities(int id)
        {
            var microprocessor = await _microprocessorStoreRepository.GetMicroprocessorAvailabilities(id);

            if (microprocessor == null)
            {
                return NotFound();
            }

            var microprocessorResult = _mapper.Map<MicroprocessorWithAvailabilityDto>(microprocessor);
            return Ok(microprocessorResult);
        }

        // POST /AddMicroprocessor
        // JSON: { "name": "Name of new microprocessor", "description": "Description of new microprocessor" }
        [HttpPost]
        [Route("AddMicroprocessor")]
        public async Task<ActionResult<Microprocessor>> AddMicroprocessor([FromBody] Microprocessor newMicroprocessor)
        {
            await _microprocessorStoreRepository.AddMicroprocessor(newMicroprocessor);

            var microprocessorResult = _mapper.Map<MicroprocessorDto>(newMicroprocessor);
            return Ok(microprocessorResult);
        }

        // PUT /UpdateMicroprocessor/{id}
        // JSON: { "name": "New name", "description": "New description" }
        [HttpPut]
        [Route("UpdateMicroprocessor/{id}")]
        public async Task<ActionResult<Microprocessor>> UpdateMicroprocessor(int id, [FromBody] Microprocessor microprocessor)
        {
            microprocessor.Id = id;
            await _microprocessorStoreRepository.UpdateMicroprocessor(microprocessor);

            var microprocessorResult = _mapper.Map<MicroprocessorDto>(microprocessor);
            return Ok(microprocessorResult);
        }

        // DELETE /DeleteMicroprocessor/{id}
        [HttpDelete]
        [Route("DeleteMicroprocessor/{id}")]
        public async Task<string> DeleteMicroprocessor(int id)
        {
            return await _microprocessorStoreRepository.DeleteMicroprocessor(id);
        }
    }
}
