namespace Store.Models
{
    public partial class PackageModel
    {
        public DateOnly PackagedDate { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public string PackageSource { get; set; } = null!;
        public int ProductId { get; set; }

        public virtual ProductModel Product { get; set; } = null!;
    }
}
