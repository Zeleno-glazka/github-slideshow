using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinomotazh.Logic
{
    class Orders
    {
        class Order
        {
            public string type { get; set; }
            public double earnings { get; set; }
            public double costs { get; set; }
            Order(string type, double earnings, double costs)
            {
                this.type = type;
                this.earnings = earnings;
                this.costs = costs;
            }
        }
        private Order[] _orders = {
            new Order("Смена покрышек", 100, 10),
            new Order("Ремонт прокола", 20, 5),
            new Order("Балансировка колес", 30, 9),
            new Order("Чистка дисков", 20, 3),
            new Order("Накачка шин", 5, 2)
        };

        Random rnd = new Random();

        Orders()
        {
            Console.WriteLine(_orders[2].type);
        }

        Order getRandomOrder()
        {
            return order[rnd.Next(0, 4)];
        }
    }
}

