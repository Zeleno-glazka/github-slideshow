using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinomotazh.Logic
{
    class TireService
    {

        Random _random = new Random();
        Ads _ads = new Ads();
        List<Demands> _demands = new List<Demands>();//Список заказов по дням (каждый элемент - список заказов в i день)
        Season _season;
        double rent_cost;
        double salaries_cost;
        double equipment_maintenance;
		AutherShine autherShine = new AutherShine();
		double rest;
		public double comPlat;
		public double strax;
		Boolean weHaveNewShineAround;


		public TireService(DateTime simulated_date, double rent, double salaries)
        {
            rent_cost = rent;
            salaries_cost = salaries;
            _season = new Season(simulated_date);
            _demands.Add(GetDailyDemands());
        }

        public Demands GetDailyDemands()
        {
            int ads_clients = _ads.GetClientQuantity();
            double season_eff = _season.getCurrentSeasonEfficiency();
            int daily_demands_quantity = (int)((_random.Next(5, 25) + ads_clients) * season_eff);
            return new Demands(daily_demands_quantity);
        }

		
		public double GetDailyProfit(int A)
        {
            equipment_maintenance = _demands.Last().GetSize() * 10;
			if (A == 2) rest = 0;
			else rest = rent_cost + salaries_cost + comPlat + strax;
			double res = _demands.Last().getProfit() - equipment_maintenance - rest + autherShine.dopMoneyForPrice;
			weHaveNewShineAround = autherShine.NewShineGo(res);
			if (weHaveNewShineAround == true)
			{
				autherShine.NewShine();
			}
			return res > 0 ? res * 0.7 : res;

        }

        public double GetADSBudget()
        {
            double ads_budget = 0.0 >= GetDailyProfit(2) ? 0.0 : GetDailyProfit(2) * 0.3;
            return ads_budget;
        }

        public void NextDay()
        {
            _demands.Add(GetDailyDemands());
            _ads.GiveMoneyForADS(GetADSBudget());
            _season.addDay();
        }

		public double newYear()
		{
			var rand = new Random();
			double money=rand.Next(1, 5)*200; //вероятность поломки оборудования и его закупка
			return money;
		}
    }
}
