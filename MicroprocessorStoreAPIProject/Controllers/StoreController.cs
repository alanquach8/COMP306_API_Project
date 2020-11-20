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

        // GET /GetStoreAvailabilities/{id}
        [HttpGet]
        [Route("GetStoreAvailabilities/{id}")]
        public async Task<ActionResult<Store>> GetStoreAvailabilities(int id)
        {
            var store = await _microprocessorStoreRepository.GetStoreAvailabilities(id);

            if (store == null)
            {
                return NotFound();
            }

            var storeResult = _mapper.Map<StoreWithAvailabilityDto>(store);
            return Ok(storeResult);
        }

        // POST /AddStore
        // JSON: { "name": "Name of new store", "address": "Address of new store" }
        [HttpPost]
        [Route("AddStore")]
        public async Task<ActionResult<Store>> AddCity([FromBody] Store newStore)
        {
            await _microprocessorStoreRepository.AddStore(newStore);

            var storeResult = _mapper.Map<StoreDto>(newStore);
            return Ok(storeResult);
        }

        // PUT /UpdateStore/{id}
        // JSON: { "name": "New name", "address": "New address" }
        [HttpPut]
        [Route("UpdateStore/{id}")]
        public async Task<ActionResult<Store>> UpdateCity(int id, [FromBody] Store store)
        {
            store.Id = id;
            await _microprocessorStoreRepository.UpdateStore(store);

            var storeResult = _mapper.Map<StoreDto>(store);
            return Ok(storeResult);
        }

        // DELETE /DeleteStore/{id}
        [HttpDelete]
        [Route("DeleteStore/{id}")]
        public async Task<string> DeleteStore(int id)
        {
            return await _microprocessorStoreRepository.DeleteStore(id);
        }
    }
}
