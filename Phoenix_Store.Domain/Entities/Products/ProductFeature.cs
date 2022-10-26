﻿using Phoenix_Store.Domain.Entities.Commons;

namespace Phoenix_Store.Domain.Entities.Products
{
    public class ProductFeature : BaseEntity
    {
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }

    }
}
