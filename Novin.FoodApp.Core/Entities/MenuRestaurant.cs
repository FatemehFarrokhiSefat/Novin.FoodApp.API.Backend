using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.FoodApp.Core.Entities
{
    public class MenuRestaurant : BaseEntity
    {
        public string? TitleAppetizer { get; set; }
        public string? AppetizerDescription { get; set; }
        public double AppetizerPrice { get; set; }
        //
        public string TitleMainDish { get; set; }
        public string DescriptionMainDish { get; set; }
        public double MainDishPrice { get; set; }
        //
        public string? TitleDessert { get; set; }
        public string? DescriptionDessert { get; set; }
        public double? DessertPrice { get; set; }
        //
        public string? TitleDrink { get; set; }
        public double? DrinkPrice { get; set; }
        //
        public string? TitleSideDishes { get; set; }
        public double SideDishesPrice { get; set; }
        public DateTime MenuUpdate { get; set; }
    }
}
