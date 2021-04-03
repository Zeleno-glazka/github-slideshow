using System;

namespace Shinomotazh.Logic
{
    class Orders
    {
        public class Order
        {
            public string type { get; set; }
            public double earnings { get; set; }
            public double costs { get; set; }
            public Order(string type, double earnings, double costs)
            {
                this.type = type;
                this.earnings = earnings;
                this.costs = costs;
            }
            public override String ToString()
            {
                return " Получено денег: " + (earnings - costs) + " Тип работ:" + type;
            }
        }

        private Order[] order_types = {
            new Order("Смена покрышек ", 100, 20),
            new Order("Ремонт прокола ", 20, 9),
            new Order("Балансировка колес ", 30, 17),
            new Order("Чистка дисков ", 20, 6),
            new Order("Накачка шин ", 5, 2)
        };

        readonly Random rnd = new Random();

        Order[] orders;
        public Orders(int n)
        {
            orders = new Order[n];
            for (int i = 0; i < n; i++)
            {
                orders[i] = getRandomOrder();
            }
        }

        public Order this[int i]
        {
            get { return orders[i]; }
            set { orders[i] = value; }
        }

        public int GetSize()
        {
            return orders.Length;
        }
        public override String ToString()
        {
            String res = "Число заказов = " + GetSize() + "\r\n\r\n";
            foreach (Order order in orders)
                res += order + "\r\n";
            return res + "\r\n\r\n\r\n";
        }
        public double getProfit()
        {
            double res = 0;
            foreach (Order order in orders)
                res += order.earnings - order.costs;
            return res;
        }
        private Order getRandomOrder()
        {
            return order_types[rnd.Next(0, 4)];
        }
    }
}
