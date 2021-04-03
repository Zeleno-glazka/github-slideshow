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
        Logic.TireFitting tireFitting;
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
            tireFitting = new Logic.TireFitting(startDate, rent, salaries);
            DefaultTmr.Interval = 500 - (int)SpeedNUD.Value * 10;
            DefaultTmr.Start();
        }

        private void DefaultTmr_Tick(object sender, EventArgs e)
        {
            tireFitting.NextDay();
            curr_money += tireFitting.GetDailyProfit();
            DefaultChrt.Series[0].Points.AddXY(curr_day, curr_money);
            AnswerTB.Text += "Дата: " + startDate.AddDays(curr_day).ToShortDateString() +
                 "\r\n" + "Выручка = " + tireFitting.GetDailyProfit() +
                 "\r\n" + "Рекламный бюджет = " + tireFitting.GetADSBudget() +
                "\r\n" + tireFitting.GetDailyOrders().ToString();
            curr_day++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DefaultChrt_Click(object sender, EventArgs e)
        {

        }
    }
}
