namespace Store.Models
{
    public partial class CategoryModel
    {
        public CategoryModel()
        {
            Producttables = new HashSet<ProductModel>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<ProductModel> Producttables { get; set; }
    }
}
