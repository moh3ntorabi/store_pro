using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductFeature
{
    public interface IDeleteProductFeatureService
    {
        ResultDto Execute(long FeatureId);
    }
    public class DeleteProductFeatureService : IDeleteProductFeatureService
    {
        private readonly IDataBaseContext _context;
        public DeleteProductFeatureService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long FeatureId)
        {
            var feature = _context.ProductFeatures.Find(FeatureId);
            if (feature == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = ".ویژگی یافت نشد"
                };
            }
            feature.RemoveTime = DateTime.Now;
            feature.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "ویژگی حذف شد"
            };
        }
    }
}
