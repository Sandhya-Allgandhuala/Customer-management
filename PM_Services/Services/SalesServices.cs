using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_Data;
using PM_Model;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PM_Services.Services
{
    public class SalesServices : ISalesServices
    {
        private readonly PMContext context;
        private readonly IMapper mapper;

        public SalesServices(PMContext Context, IMapper Mapper)
        {
            context = Context;
            mapper = Mapper;
        }


        public bool DeleteSalesData(SalesDTO deletesales)
        {
            context.Sales.Remove(mapper.Map<Sales>(deletesales));
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public SalesDTO GetSalesbyId(int id)
        {
            Sales sale = context.Sales.Find(id);
            SalesDTO Sale = mapper.Map<SalesDTO>(sale);
            return Sale;
        }

        public List<SalesDTO> GetSalesData()
        {
            List<SalesDTO> sales = new List<SalesDTO>();
           List<Sales> allSales = context.Sales.Include("Customer").Include("Store").Include("Product").ToList();
            foreach(var item in allSales)
            {
                SalesDTO sale = mapper.Map<SalesDTO>(item);
                sales.Add(sale);
            }

            return sales;
        }

        public bool SaveSalesData(SalesDTO sales)
        {
            context.Sales.Add(mapper.Map<Sales>(sales));
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSalesData(SalesDTO sales)
        {
            context.Sales.Update(mapper.Map<Sales>(sales));
            if(context.SaveChanges()==1)
            {
                return true;
            }
            return false;
        }
    }
}
