using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._1Lab8._2
{
    public partial class Form3 : Form
    {
        MagicBall mb = new MagicBall();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = mb.MainMethod();
        }
    }

    public class MagicBall
    {
        Random rnd = new Random();
        int k = 1;
        decimal A;
        static decimal p0 = 0M;
        static decimal p1 = p0 + 0.1M;
        static decimal p2 = p1 + 0.2M;
        static decimal p3 = p2 + 0.15M;
        static decimal p4 = p3 + 0.25M;
        static decimal p5 = p4 + 0.2M;
        static decimal p6 = 1M;
        
        public string MainMethod()
        {
            A = rnd.Next(0, 100);
            A /= 100;
            if (A >p0 & A<p1)
            { k = 1; }
            else if (A>p1 & A<=p2)
            { k = 2; }
            else if (A>p2 & A<=p3)
            { k = 3; }
            else if (A>p3 & A<=p4)
            { k = 4; }
            else if (A >p4 & A<=p5)
            { k = 5; }
            else if (A>p5 & A<p6)
            { k = 6; }
            switch(k)
            {
                case 1:
                    return "Не могу знать";
                case 2:
                    return "Нет";
                case 3:
                    return "Без сомнений";
                case 4:
                    return "Да";
                case 5:
                    return "Мало шансов";
                case 6:
                    return "Не сейчас";
            }
            return "";
        }
    }
}
