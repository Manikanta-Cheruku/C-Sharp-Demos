using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticVariableDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class JointAccount
        {
            static int balance = 10000;//here it should be static else amount will not be deducted because it is a non static and it have multiple copy but static will remember the values;

            public void withdraw(int amt)
            {
                balance = balance - amt;
                MessageBox.Show("The Current baalnce is " + balance);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            JointAccount account = new JointAccount();
            account.withdraw(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JointAccount account = new JointAccount();
            account.withdraw(Convert.ToInt32(textBox1.Text));
        }
    }
}
