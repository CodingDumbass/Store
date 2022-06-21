namespace Store.Models
{
    public partial class OrdersModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string OrderAddress { get; set; } = null!;
        public string OrderEmail { get; set; } = null!;
        public string OrderStatus { get; set; } = null!;

        public virtual CustomerModel Customer { get; set; } = null!;
    }
}
