using System.ComponentModel.DataAnnotations;

namespace Phoenix_Store.Domain.Entities.Orders
{
    public enum OrderState 
    {
        [Display(Name ="درحال پردازش")]
        Processing=0,
        [Display(Name = "لغو شده")]
        Canceling =1,
        [Display(Name = "تحویل شده")]
        Delivered =2
    }
}
