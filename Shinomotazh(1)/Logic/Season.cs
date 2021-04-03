using System;
using System.Collections.Generic;

namespace Shinomotazh.Logic
{
    class Season
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        Dictionary<Seasons, double> seasons_efficiency = new Dictionary<Seasons, double>() //Нагруженность во время каждого сезона
        {
            [Seasons.Winter] = 0.3,
            [Seasons.Spring] = 0.9,
            [Seasons.Summer] = 0.5,
            [Seasons.Autumn] = 0.7
        };

        DateTime curr_date;

        public Season(DateTime date)
        {
            curr_date = date;
        }

        Seasons getSeason(DateTime date)
        {
            int day = date.DayOfYear - Convert.ToInt32((DateTime.IsLeapYear(date.Year)) && date.DayOfYear > 59);
            if (day < 80 || day >= 355) return Seasons.Winter;
            if (day >= 80 && day < 172) return Seasons.Spring;
            if (day >= 172 && day < 266) return Seasons.Summer;
            return Seasons.Autumn;
        }

        public void addDay()
        {
            curr_date = curr_date.AddDays(1);
        }

        public double getCurrentSeasonEfficiency()
        {
            double res;
            Seasons curr_season = getSeason(curr_date);
            seasons_efficiency.TryGetValue(curr_season, out res);
            return res;
        }
    }
}
