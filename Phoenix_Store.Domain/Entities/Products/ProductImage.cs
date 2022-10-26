using Phoenix_Store.Domain.Entities.Commons;

namespace Phoenix_Store.Domain.Entities.Products
{
    public class ProductImage : BaseEntity
    {
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
        public string Src { get; set; }
    }
}
