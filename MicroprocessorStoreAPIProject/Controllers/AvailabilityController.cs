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
    public class AvailabilityController : ControllerBase
    {
        private IMicroprocessorStoreRepository _microprocessorStoreRepository;
        private readonly IMapper _mapper;

        public AvailabilityController(IMicroprocessorStoreRepository microprocessorStoreRepository, IMapper mapper)
        {
            _microprocessorStoreRepository = microprocessorStoreRepository;
            _mapper = mapper;
        }

        // POST /AddAvailability
        // JSON: { "storeId": id, "microprocessorId": id, "quantity": quantity, "price": price }
        [HttpPost]
        [Route("AddAvailability")]
        public async Task<ActionResult<Availability>> AddAvailability([FromBody] Availability newAvailability)
        {
            await _microprocessorStoreRepository.AddAvailability(newAvailability);

            var availabilityResult = _mapper.Map<AvailabilityDto>(newAvailability);
            return Ok(availabilityResult);
        }

        // PUT /UpdateAvailability/{id}
        // JSON: { "name": "New name", "address": "New address" }
        [HttpPut]
        [Route("UpdateAvailability/{id}")]
        public async Task<ActionResult<Availability>> UpdateAvailability(int id, [FromBody] Availability availability)
        {
            availability.Id = id;
            await _microprocessorStoreRepository.UpdateAvailability(availability);

            var availabilityResult = _mapper.Map<AvailabilityDto>(availability);
            return Ok(availabilityResult);
        }

        // DELETE /DeleteAvailability/{id}
        [HttpDelete]
        [Route("DeleteAvailability/{id}")]
        public async Task<string> DeleteAvailability(int id)
        {
            return await _microprocessorStoreRepository.DeleteAvailability(id);
        }
    }
}
