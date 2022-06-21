namespace Store.Models
{
    public partial class OrderdetailsModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        public virtual OrdersModel Order { get; set; } = null!;
        public virtual ProductModel Product { get; set; } = null!;
    }
}
