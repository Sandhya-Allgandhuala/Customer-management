using PM_Data;
using PM_Model;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace PM_Services.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly PMContext context;
        private readonly IMapper mapperProfile;

        public CustomerService(PMContext Context, IMapper profile)
        {
            context = Context;
            mapperProfile = profile;
        }

        // Delete customer record based on incoming id.
        public bool DeleteCustomerData(CustomerDTO deleteCustomer)
        {
            Customer DeleteCustomer = context.Customers.FirstOrDefault(x => x.Id == deleteCustomer.Id);
            context.Customers.Remove(DeleteCustomer);
            if(context.SaveChanges()==1)
            {
                return true;
            }
            return false;

        }

        // Searching for customer record based on customer id.
        public CustomerDTO GetCustomerbyId(int id)
        {
            Customer UpdateCustomer = context.Customers.FirstOrDefault(x => x.Id == id);
            CustomerDTO Customer = mapperProfile.Map<CustomerDTO>(UpdateCustomer);
            return Customer;
        }

        public List<CustomerDTO> GetCustomerData()
        {
            var Customers = new List<CustomerDTO>();
            List<Customer> AllCustomers = context.Customers.ToList();
            foreach(var customer in AllCustomers)
            {
                CustomerDTO Customer = mapperProfile.Map<CustomerDTO>(customer);
                Customers.Add(Customer);
            }
            return Customers;
        }

        public bool SaveCustomerData(CustomerDTO customer)
        {
            context.Customers.Add(mapperProfile.Map<Customer>(customer));
            if (context.SaveChanges()==1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCustomerData(CustomerDTO customer)
        {
            context.Customers.Update(mapperProfile.Map<Customer>(customer));
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }
    }
}
