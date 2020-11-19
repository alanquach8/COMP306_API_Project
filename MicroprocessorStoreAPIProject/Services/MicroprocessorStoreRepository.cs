using MicroprocessorStoreLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Services
{
    public class MicroprocessorStoreRepository : IMicroprocessorStoreRepository
    {
        private MicroprocessorStoreDBContext _context;
        public MicroprocessorStoreRepository(MicroprocessorStoreDBContext context)
        {
            _context = context;
        }

        public async Task<Microprocessor> GetMicroprocessorById(int microprocessorId)
        {
            IQueryable<Microprocessor> result;

            result = _context.Microprocessor.Where(m => m.Id == microprocessorId);

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Microprocessor>> GetMicroprocessors()
        {
            var result = _context.Microprocessor.OrderBy(m => m.Id);
            return await result.ToListAsync();
        }

        public async Task<Store> GetStoreById(int storeId)
        {
            IQueryable<Store> result;

            result = _context.Store.Where(s => s.Id == storeId);

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            var result = _context.Store.OrderBy(s => s.Id);
            return await result.ToListAsync();
        }

        public async Task<bool> MicroprocessorExists(int microprocessorId)
        {
            return await _context.Microprocessor.AnyAsync<Microprocessor>(m => m.Id == microprocessorId);
        }

        public async Task<bool> StoreExists(int storeId)
        {
            return await _context.Store.AnyAsync<Store>(s => s.Id == storeId);
        }
    }
}
