using System;
using System.Collections.Generic;
using System.Linq;
namespace Store.Models
{
    public partial class ProductModel
    {
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public int ProductStock { get; set; }
        public decimal ProductWeight { get; set; }
        public int CategoryId { get; set; }

        public virtual CategoryModel Category { get; set; } = null!;


    }
}
