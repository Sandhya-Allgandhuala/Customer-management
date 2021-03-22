using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services.Services.serviceinterfaces
{
    public interface ISalesServices
    {
        List<SalesDTO> GetSalesData();
        SalesDTO GetSalesbyId(int id);
        bool SaveSalesData(SalesDTO sales);
        bool UpdateSalesData(SalesDTO sales);
        bool DeleteSalesData(SalesDTO deletesales);
    }
}
