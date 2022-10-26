using Phoenix_Store.Common.Dto;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {
        ResultDto<ResultProductForSiteDto> Execute(Ordering ordering,string SearhKey,long? CatId,int Page, int pageSize);
    }
    public enum Ordering
    {
        notOrder=0,
        //<summary>
        //بیشترین بازدید
        //</summary>
        MostVisited=1,
        //<summary>
        //بهترین فروش
        //</summary>
        BestSelling = 2,
        //<summary>
        //محبوبترین
        //</summary>
        MostPopular = 3,
        //<summary>
        //جدیدترین
        //</summary>
        TheNewest = 4,
        //<summary>
        //ارزانترین
        //</summary>
        Cheapest = 5,
        //<summary>
        //گرانترین
        //</summary>
        MostExpensive = 6,
    }
}
