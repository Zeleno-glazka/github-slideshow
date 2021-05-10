using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        ModelGenerateEvents MGE = new ModelGenerateEvents();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MGE.SetData((int)numericUpDown5.Value, numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, 0.0m))
            {
                chart1.Series[0].Points.Clear();
                decimal[] pointsY = MGE.GetData();
                for(int i = 0; i < pointsY.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, pointsY[i]);
                }
            }
            else
            {
                MessageBox.Show("Не выполнено условие нормировки","Ok", MessageBoxButtons.OK);
            }
        }
    }

    public class ModelGenerateEvents
    {

        Random rnd = new Random();
        int N;
        int[] statistic;
        decimal[] prob;
        public bool SetData(int N,params decimal[] m)
        {
            prob = new decimal[m.Length];
            this.N = N;
            statistic = new int[m.Length];
            prob[m.Length - 1] = 1;
            statistic[m.Length - 1] = 0;
            for (int i =0;i<m.Length-1;i++)
            {
                prob[i] = m[i];
                prob[m.Length-1]-=m[i];
                statistic[i] = 0;
            }
            if (prob[m.Length - 1] < 0) return false;
            return true;
        }

        public decimal[] GetData()
        {
            decimal[] freq = new decimal[statistic.Length];
            int k;
            decimal A;
            for(int i = 0; i < N; i++)
            {
                A = (decimal)rnd.NextDouble();
                for(k=-1;A>0;k++)
                {
                    A -= prob[k + 1];
                }
                statistic[k]++;
            }
            for(int i = 1; i < statistic.Length; i++)
            {
                freq[i] = (decimal)statistic[i] / N;
            }
            return freq;
        }

    }
}
