using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services.Services.serviceinterfaces
{
    public interface IStoreServices
    {
        List<StoreDTO> GetStoreData();
        StoreDTO GetStorebyId(int id);
        bool SaveStoreData(StoreDTO store);
        bool UpdateStoreData(StoreDTO store);
        bool DeleteStoreData(StoreDTO deletestore);
    }
}
