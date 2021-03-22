using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services.ViewModel
{
    public class SalesDTO
    {
        public int Id { get; set; }
        public DateTime DateSold { get; set; }

        #region Relation
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public virtual CustomerDTO Customer { get; set; }
        public virtual ProductDTO Product { get; set; }
        public virtual StoreDTO Store { get; set; }

        #endregion
    }
}
