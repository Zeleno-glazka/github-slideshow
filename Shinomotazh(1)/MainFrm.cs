using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shinomotazh
{
    public partial class MainFrm : Form
    {
		double n_money;
        Logic.TireService tireService;
        int curr_day = 0;
        DateTime startDate;
        double curr_money;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (DefaultTmr.Enabled)
                DefaultTmr.Stop();
            else
                DefaultTmr.Start();
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            DefaultChrt.ChartAreas[0].AxisX.Minimum = 0;
            curr_money = Double.Parse(StartMoneyTB.Text);
            startDate = StartDateDTP.Value;
            double rent = Double.Parse(RentTB.Text);
            double salaries = Double.Parse(SalaryTB.Text);
            tireService = new Logic.TireService(startDate, rent, salaries);
                    tireService.comPlat = Double.Parse(tb_KomPlat.Text);
                    tireService.strax = Double.Parse(tb_strax.Text);
			        DefaultTmr.Interval = 500 - (int)SpeedNUD.Value * 10;
            DefaultTmr.Start();
        }

        private void DefaultTmr_Tick(object sender, EventArgs e)
        {
            tireService.NextDay();
            
            DefaultChrt.Series[0].Points.AddXY(curr_day, curr_money);

			if (startDate.AddDays(curr_day).Month != startDate.AddDays(curr_day + 1).Month)
			{
				curr_money += tireService.GetDailyProfit(1);
				tb_mounth.Text += "Дата:" + startDate.AddDays(curr_day).ToShortDateString() + "\r\n" +
					"Зарплата: " + Double.Parse(SalaryTB.Text)
					+ "\r\n" +
					"Аренда: " + Double.Parse(RentTB.Text) + "\r\n" + 
				"Комунальные платежи: " + Double.Parse(tb_KomPlat.Text)
					+ "\r\n" + "\r\n";
			}
			else
			{
				curr_money += tireService.GetDailyProfit(2);
			}
			if (startDate.AddDays(curr_day).Year != startDate.AddDays(curr_day + 1).Year)
			{
				curr_money += tireService.newYear();
				tb_mounth.Text += "Дата:" + startDate.AddDays(curr_day).ToShortDateString() + "\r\n" +
					"Закупка оборудования: " + tireService.newYear()
					+ "\r\n";
			}
			




			ReportTB.Text += "Дата: " + startDate.AddDays(curr_day).ToShortDateString() +
					 "\r\n" + "Выручка = " + tireService.GetDailyProfit(2) +
					 "\r\n" + "Рекламный бюджет = " + tireService.GetADSBudget() +
					"\r\n" + tireService.GetDailyDemands().ToString();
				n_money = curr_money;
				n_money = Math.Round(n_money, 0);
				lb_money.Text = $"Денег: {n_money} ";
				curr_day++;
			
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DefaultChrt_Click(object sender, EventArgs e)
        {

        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

        private void tb_mountc_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
