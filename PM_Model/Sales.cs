﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Model
{
    public class Sales
    {
        public int Id { get; set; }                                                                                                     
        public DateTime DateSold { get; set; }
        #region Relation
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }

        #endregion


    }
}
