using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services.Services.serviceinterfaces
{
    public interface ICustomerService
    {
        List<CustomerDTO> GetCustomerData();
        CustomerDTO GetCustomerbyId(int id);
        bool SaveCustomerData(CustomerDTO customer);
        bool UpdateCustomerData(CustomerDTO customer);
        bool DeleteCustomerData(CustomerDTO deleteCustomer);
    }
}
