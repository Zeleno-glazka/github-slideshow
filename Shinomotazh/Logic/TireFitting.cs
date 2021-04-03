using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinomotazh.Logic
{
    class TireFitting
    {

        Random _random = new Random();
        Ads _ads = new Ads();
        List<Orders> _orders = new List<Orders>();//Список заказов по дням (каждый элемент - список заказов в i день)
        Season _season;
        double rent_cost;
        double salaries_cost;
        double equipment_maintenance;

        public TireFitting(DateTime simulated_date, double rent, double salaries)
        {
            rent_cost = rent;
            salaries_cost = salaries;
            _season = new Season(simulated_date);
            _orders.Add(GetDailyOrders());
        }

        public Orders GetDailyOrders()
        {
            int ads_clients = _ads.GetClientQuantity();
            double season_eff = _season.getCurrentSeasonEfficiency();
            int daily_orders_quantity = (int)((_random.Next(5, 25) + ads_clients) * season_eff);
            return new Orders(daily_orders_quantity);
        }

        public double GetDailyProfit()
        {
            equipment_maintenance = _orders.Last().GetSize() * 10;
            double res = _orders.Last().getProfit() - equipment_maintenance - (rent_cost + salaries_cost) / 30;
            return res > 0 ? res * 0.7 : res;

        }

        public double GetADSBudget()
        {
            double ads_budget = 0.0 >= GetDailyProfit() ? 0.0 : GetDailyProfit() * 0.3;
            return ads_budget;
        }

        public void NextDay()
        {
            _orders.Add(GetDailyOrders());
            _ads.GiveMoneyForADS(GetADSBudget());
            _season.addDay();
        }
    }
}
