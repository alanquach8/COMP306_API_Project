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

        public async Task<Store> AddStore(Store store)
        {
            _context.Store.Add(store);
            await _context.SaveChangesAsync();

            return await GetStoreById(store.Id);
        }

        public async Task<Store> UpdateStore(Store store)
        {
            _context.Store.Update(store);
            await _context.SaveChangesAsync();

            return await GetStoreById(store.Id);
        }

        public async Task<string> DeleteStore(int storeId)
        {
            try
            {
                Store storeToDelete = _context.Store.Where(s => s.Id == storeId).FirstOrDefault();
                _context.Store.Remove(storeToDelete);
                await _context.SaveChangesAsync();
                return "Successfully deleted store with id " + storeToDelete.Id.ToString();
            }
            catch (Exception)
            {
                return "Fail. Unable to delete store with id " + storeId.ToString();
            }
        }

        public async Task<Microprocessor> AddMicroprocessor(Microprocessor microprocessor)
        {
            _context.Microprocessor.Add(microprocessor);
            await _context.SaveChangesAsync();

            return await GetMicroprocessorById(microprocessor.Id);
        }

        public async Task<Microprocessor> UpdateMicroprocessor(Microprocessor microprocessor)
        {
            _context.Microprocessor.Update(microprocessor);
            await _context.SaveChangesAsync();

            return await GetMicroprocessorById(microprocessor.Id);
        }

        public async Task<string> DeleteMicroprocessor(int microprocessorId)
        {
            try
            {
                Microprocessor microprocessorToDelete = _context.Microprocessor.Where(m => m.Id == microprocessorId).FirstOrDefault();
                _context.Microprocessor.Remove(microprocessorToDelete);
                await _context.SaveChangesAsync();
                return "Successfully deleted microprocessor with id " + microprocessorToDelete.Id.ToString();
            }
            catch (Exception)
            {
                return "Fail. Unable to delete microprocessor with id " + microprocessorId.ToString();
            }
        }
        public async Task<bool> Save()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
