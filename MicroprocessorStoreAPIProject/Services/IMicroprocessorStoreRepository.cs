using MicroprocessorStoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Services
{
    public interface IMicroprocessorStoreRepository
    {
        Task<bool> StoreExists(int storeId);
        Task<IEnumerable<Store>> GetStores();
        Task<Store> GetStoreById(int storeId);

        Task<bool> MicroprocessorExists(int microprocessorId);
        Task<IEnumerable<Microprocessor>> GetMicroprocessors();
        Task<Microprocessor> GetMicroprocessorById(int microprocessorId);
    }
}
