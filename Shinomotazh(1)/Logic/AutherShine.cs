using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinomotazh.Logic
{
	class AutherShine
	{
		public int shinAround = 0;
		public double dopMoneyForPrice = 200;
		public Boolean NewShineGo(double money)
		{
			Boolean yesOrNo = false;
			var rand = new Random();
			int a = rand.Next(1, 5);
			if ((money > 1000) && (a==2) && (shinAround<=4)) //Шиномонтажка приносит много денег, и срабатывает фактор вероятности
			{
				shinAround++;
			}
			return yesOrNo;
		}
		public void NewShine()
		{
			dopMoneyForPrice = dopMoneyForPrice / (shinAround+1);
		}

	}
}
