using AutoMapper;
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
    public class ProductServices : IProductServices
    {
        private readonly IMapper mapper;
        private readonly PMContext context;
        public ProductServices(IMapper Mapper , PMContext Context)
        {
            mapper = Mapper;
            context = Context;
        }


        public bool DeleteProductData(ProductDTO deleteCustomer)
        {
            context.Products.Remove(mapper.Map<Product>(deleteCustomer));
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public ProductDTO GetProductbyId(int id)
        {
            ProductDTO product = new ProductDTO();
            var productRecord = context.Products.Find(id);
            product = mapper.Map<ProductDTO>(productRecord);
            return product;
        }

        public List<ProductDTO> GetProductData()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            var AllProducts = context.Products.ToList();
            foreach(var item in AllProducts)
            {
                ProductDTO product = mapper.Map<ProductDTO>(item);
                products.Add(product);
            }
            return products;
        }

        public bool SaveProductData(ProductDTO customer)
        {
            Product productRecord = mapper.Map<Product>(customer);
            context.Products.Add(productRecord);
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateProductData(ProductDTO product)
        {
            context.Products.Update(mapper.Map<Product>(product));
            if(context.SaveChanges()==1)
            {
                return true;
            }
            return false;
        }
    }
}
