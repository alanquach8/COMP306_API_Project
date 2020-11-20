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

        Task<Store> AddStore(Store store);
        Task<Store> UpdateStore(Store store);
        Task<string> DeleteStore(int storeId);

        Task<Microprocessor> AddMicroprocessor(Microprocessor microprocessor);
        Task<Microprocessor> UpdateMicroprocessor(Microprocessor microprocessor);
        Task<string> DeleteMicroprocessor(int microprocessorId);

        Task<Store> GetStoreAvailabilities(int storeId);
        Task<Microprocessor> GetMicroprocessorAvailabilities(int microprocessorId);

        Task<bool> Save();
    }
}
