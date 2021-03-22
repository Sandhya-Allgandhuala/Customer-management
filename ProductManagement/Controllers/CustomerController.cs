using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;

namespace ProductManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerServices;
        public CustomerController(ICustomerService customer)
        {
            customerServices = customer;
        }
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerDTO newCustomer)
        {
            if (customerServices.SaveCustomerData(newCustomer) == true)
            {
                return RedirectToAction("ListCustomer");
            }
            return View();
        }
        [HttpGet]
        public IActionResult ListCustomer()
        {
            return View(customerServices.GetCustomerData());
        }
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            return View(customerServices.GetCustomerbyId(id));
        }

        [HttpPost]
        public IActionResult EditCustomer(CustomerDTO customer)
        {
            if(customerServices.UpdateCustomerData(customer) == true)
            {
                return RedirectToAction("ListCustomer");
            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            return View(customerServices.GetCustomerbyId(id));
        }

        [HttpPost]
        public IActionResult DeleteCustomer(CustomerDTO customer)
        {
            if (customerServices.DeleteCustomerData(customer) == true)
            {
                return RedirectToAction("ListCustomer");
            }
            return View();
        }

        [HttpGet]
        public IActionResult CustomerDetails(int id)
        {
            return View(customerServices.GetCustomerbyId(id));
        }

    }
}
