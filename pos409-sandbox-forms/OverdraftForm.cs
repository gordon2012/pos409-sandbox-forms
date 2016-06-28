using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace pos409_sandbox_forms
{
    public partial class OverdraftForm : Form
    {
        public OverdraftForm()
        {
            InitializeComponent();


            

        }

        public Func<string, string> currency = (val) => double.Parse(val).ToString("C");

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = currency(textBox1.Text);


        }
    }

    class OverdrawnEventArgs : EventArgs
    {
        public double Balance, Amount;

        OverdrawnEventArgs(double balance, double amount)
        {
            Balance = balance;
            Amount = amount;
        }
    }




    class BankAccount
    {
        public double Balance { get; set; }

        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {

            }
        }




    }

    class OverdraftAccount : BankAccount
    {

    }


}
