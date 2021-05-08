using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PettyCash pc = new PettyCash();
            Person workers = new Person();
            for (int i = 0, amount = 100; i < 4; i++, amount += 100)
                if (!pc.withdraw(i, amount))
                    textBox2.Text = textBox2.Text +"No money for" + workers.name(i);
                else
                    textBox2.Text = textBox2.Text + amount + " dollars for " + workers.name(i);
                    textBox2.Text = textBox2.Text + "Remaining balance is " + pc.getBalance();
        }
    }
}
