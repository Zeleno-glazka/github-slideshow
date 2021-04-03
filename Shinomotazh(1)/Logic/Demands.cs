using System;

namespace Shinomotazh.Logic
{
    class Demands
    {
        public class Demand
        {
            public string type { get; set; }
            public double earnings { get; set; }
            public double costs { get; set; }
            public Demand(string type, double earnings, double costs)
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

        private Demand[] demand_types = {
            new Demand("Смена покрышек ", 100, 20),
            new Demand("Ремонт прокола ", 20, 9),
            new Demand("Балансировка колес ", 30, 17),
            new Demand("Чистка дисков ", 20, 6),
            new Demand("Накачка шин ", 5, 2)
        };

        readonly Random dmnd = new Random();

        Demand[] demands;
        public Demands(int n)
        {
            demands = new Demand[n];
            for (int i = 0; i < n; i++)
            {
                demands[i] = getRandomDemand();
            }
        }

        public Demand this[int i]
        {
            get { return demands[i]; }
            set { demands[i] = value; }
        }

        public int GetSize()
        {
            return demands.Length;
        }
        public override String ToString()
        {
            String res = "Число заказов = " + GetSize() + "\r\n\r\n";
            foreach (Demand Demand in demands)
                res += Demand + "\r\n";
            return res + "\r\n\r\n\r\n";
        }
        public double getProfit()
        {
            double res = 0;
            foreach (Demand Demand in demands)
                res += Demand.earnings - Demand.costs;
            return res;
        }
        private Demand getRandomDemand()
        {
            return demand_types[dmnd.Next(0, 4)];
        }
    }
}

