﻿using Phoenix_Store.Application.Services.Common.Queries.GetHomePageImages;
using Phoenix_Store.Application.Services.Common.Queries.GetSlider;
using Phoenix_Store.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Models.ViewModels.HomePages
{
    public class HomePagesViewModel
    {
        public List<SliderDto> Sliders { get; set; }
        public List<HomePageImagesDto> PageImages { get; set; }
        public List<ProductForSiteDto> Laptop { get; set; }
        public List<ProductForSiteDto> Mobile { get; set; }
        public List<ProductForSiteDto> Camera { get; set; }
    }
}
