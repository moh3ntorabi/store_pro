﻿namespace Phoenix_Store.Application.Services.Products.Queries.GetProductForSite
{
    public class ProductForSiteDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ImageSrc { get; set; }
        public int Stars { get; set; }
        public int Price { get; set; }
    }
}
