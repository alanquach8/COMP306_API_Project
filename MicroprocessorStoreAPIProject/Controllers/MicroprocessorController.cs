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
    [Route("api/[controller]")]
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
    }
}
