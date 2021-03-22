using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;

namespace ProductManagement.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreServices storeServices;

        public StoreController(IStoreServices StoreServices)
        {
            storeServices = StoreServices;
        }
        [HttpGet]
        public IActionResult AddStore()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStore(StoreDTO NewStore)
        {
            if (storeServices.SaveStoreData(NewStore) == true)
            {
                return RedirectToAction("ListStore");
            }
            return View();
        }

        [HttpGet]
        public IActionResult ListStore()
        {
            return View(storeServices.GetStoreData());
        }

        [HttpGet]
        public IActionResult EditStore(int id)
        {
            return View(storeServices.GetStorebyId(id));
        }

        [HttpPost]
        public IActionResult EditStore(StoreDTO store)
        {
            if (storeServices.UpdateStoreData(store) == true)
            {
                return RedirectToAction("ListStore");
            }

            return View();
        }

        [HttpGet]
        public IActionResult DeleteStore(int id)
        {
            return View(storeServices.GetStorebyId(id));
        }

        [HttpPost]
        public IActionResult DeleteStore(StoreDTO store)
        {
            if (storeServices.DeleteStoreData(store) == true)
            {
                return RedirectToAction("ListStore");
            }

            return View();
        }

        [HttpGet]
        public IActionResult StoreDetails(int id)
        {
            return View(storeServices.GetStorebyId(id));
        }
    }
}
