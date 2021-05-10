using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._1Lab8._2
{
    public partial class Form2 : Form
    {
        TellMe answer = new TellMe();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = answer.MainMethod();
        }
    }

    public class TellMe
    {
        Random rnd = new Random();
        decimal p = 0.6M;
        public string MainMethod()
        {
            decimal a = rnd.Next(0, 100);
            a /= 100;
            if (a<p)
            {
                return "Yes!";
            }
            return "No!";
        }
    }


}
