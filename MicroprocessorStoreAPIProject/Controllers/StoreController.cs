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
    public class StoreController : ControllerBase
    {
        private IMicroprocessorStoreRepository _microprocessorStoreRepository;
        private readonly IMapper _mapper;

        public StoreController(IMicroprocessorStoreRepository microprocessorStoreRepository, IMapper mapper)
        {
            _microprocessorStoreRepository = microprocessorStoreRepository;
            _mapper = mapper;
        }

        // GET: /GetStores
        [HttpGet]
        [Route("GetStores")]
        public async Task<ActionResult<Store>> GetStores()
        {
            var storeEntities = await _microprocessorStoreRepository.GetStores();

            var results = _mapper.Map<IEnumerable<StoreDto>>(storeEntities);

            return Ok(results);
        }

        // GET /GetStore/{id}
        [HttpGet]
        [Route("GetStore/{id}")]
        public async Task<ActionResult<Store>> GetStoreById(int id)
        {
            var store = await _microprocessorStoreRepository.GetStoreById(id);

            if (store == null)
            {
                return NotFound();
            }

            var storeResult = _mapper.Map<StoreDto>(store);
            return Ok(storeResult);
        }
    }
}
