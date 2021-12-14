using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polityko_lb3.Models
{
    public static class StaticDB
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>()
        {
                new ProductModel()
            {
                Id = 3,
                Description = "Мяско рыбы",
                Name = "Рыбы",
                Price = "442 RUB"
            },
                new ProductModel()
            {
                Id = 4,
                Description = "Пиво Лидское",
                Name = "Вода",
                Price = "3235 RUB"
            },
                new ProductModel()
            {
                Id = 5,
                Description = "Мясo Барана",
                Name = "Мясо",
                Price = "94325 RUB"
            },
                new ProductModel()
            {
                Id = 6,
                Description = "Вода Бонаква",
                Name = "Вода",
                Price = "225 RUB"
            }
        };
    }
}
