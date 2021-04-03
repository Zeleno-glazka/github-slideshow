using System;
using System.Collections.Generic;


namespace Shinomotazh.Logic
{
    class Ads
    {
        const int DELAY = 2;                                 //Задержка равная кол-ву дней через которое реклама привлечет клиентов
        const double EFFICIENCY = 0.03;                      //Корректирующий коэффицент эффективности рекламы
        private List<int> clients_from_ads = new List<int>();//Список клиентов привлеченных рекламой по дням (сколько клиентов привлечено в i день)
        public void GiveMoneyForADS(double money)
        {
            //в нашей модели имеется логарифмическая зависимость эффективности рекламы от затраченных средств 
            int clients = money > 0 ? (int)(Math.Log(money * EFFICIENCY)) : 0;
            clients_from_ads.Add(clients);
        }

        public int GetClientQuantity()
        {
            if (clients_from_ads.Count <= 2) return 0;
            return clients_from_ads[clients_from_ads.Count - DELAY];//реклама работает с задержкой
        }
    }
}
