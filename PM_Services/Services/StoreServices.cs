using AutoMapper;
using PM_Data;
using PM_Model;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace PM_Services.Services
{
    public class StoreServices : IStoreServices
    {
        private readonly IMapper mapper;
        private readonly PMContext context;

        public StoreServices(IMapper Mapper, PMContext Context)
        {
            mapper = Mapper;
            context = Context;
        }
        public bool DeleteStoreData(StoreDTO deletestore)
        {
            context.Stores.Remove(mapper.Map<Store>(deletestore));
            if(context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public StoreDTO GetStorebyId(int id)
        {
            Store store = context.Stores.Find(id);
            StoreDTO storeDTO = mapper.Map<StoreDTO>(store);
            return storeDTO;
        }

        public List<StoreDTO> GetStoreData()
        {
            List<StoreDTO> stores = new List<StoreDTO>();
            var allStores = context.Stores.ToList();
            foreach(var item in allStores)
            {
                StoreDTO store = new StoreDTO();
                store = mapper.Map<StoreDTO>(item);
                stores.Add(store);
            }
            return stores;
        }

        public bool SaveStoreData(StoreDTO store)
        {
            context.Stores.Add(mapper.Map<Store>(store));
            if(context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateStoreData(StoreDTO store)
        {
            context.Stores.Update(mapper.Map<Store>(store));
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }
    }
}
