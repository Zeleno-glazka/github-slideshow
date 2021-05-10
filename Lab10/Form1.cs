using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        Game g = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value == 3 | numericUpDown2.Value == 3)
            {
                if (numericUpDown1.Value == 3) MessageBox.Show("Победил игрок", "Начать заново", MessageBoxButtons.OK);
                MessageBox.Show("Победил компьютер", "Начать заново", MessageBoxButtons.OK);
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
            else
            {
                int[] array = g.GenerateCombinationForPlayer();
                numericUpDown3.Value = array[0];
                numericUpDown4.Value = array[1];
                numericUpDown5.Value = array[2];
                numericUpDown6.Value = array[3];
                numericUpDown7.Value = array[4];
                numericUpDown8.Value = array[5];

                array = g.GenerateCombinationForComputer();
                numericUpDown9.Value = array[0];
                numericUpDown10.Value = array[1];
                numericUpDown11.Value = array[2];
                numericUpDown12.Value = array[3];
                numericUpDown13.Value = array[4];
                numericUpDown14.Value = array[5];

                if (g.Compare()) 
                {
                    numericUpDown1.Value++;
                }
                else
                {
                    numericUpDown2.Value++;
                }
                
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди бросают кости.\nУ кого больше дублей тот побеждает в раунде.\nИгра идет до трех побед","Ok",MessageBoxButtons.OK);
        }
    }

    public class Game
    {
        Random rnd = new Random();
        int sumPlayer = 0;
        int sumComputer = 0;
        int[] number = new int[6] { 1, 2, 3, 4, 5, 6 };
        public int[] GenerateCombinationForPlayer()
        {
            decimal[] prob = new decimal[6] { 0.18m, 0.17m, 0.17m, 0.16m, 0.16m, 0.16m };
            int[] array = new int[6];
            int k;
            decimal A;
            for(int i = 0; i < array.Length; i++)
            {
                A = (decimal)rnd.NextDouble();
                for (k = -1; A > 0;k++)
                {
                    A -= prob[k + 1];
                }
                array[i] = number[k];
            }
            return array;
        }

        public int[] GenerateCombinationForComputer()
        {
            decimal[] prob = new decimal[6] { 0.05m, 0.05m, 0.15m, 0.2m, 0.25m, 0.3m };
            int[] array = new int[6];
            int k;
            decimal A;
            for (int i = 0; i < array.Length; i++)
            {
                A = (decimal)rnd.NextDouble();
                for (k = -1; A > 0; k++)
                {
                    A -= prob[k + 1];
                }
                array[i] = number[k];
            }
            return array;
        }

        public bool Compare()
        {
            if (sumPlayer > sumComputer) return true;
            return false;
        }
    }

  
}
