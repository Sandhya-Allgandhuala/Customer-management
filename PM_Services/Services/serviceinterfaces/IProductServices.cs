using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services.Services.serviceinterfaces
{
    public interface IProductServices
    {
        List<ProductDTO> GetProductData();
        ProductDTO GetProductbyId(int id);
        bool SaveProductData(ProductDTO product);
        bool UpdateProductData(ProductDTO product);
        bool DeleteProductData(ProductDTO deleteproduct);


    }
}
