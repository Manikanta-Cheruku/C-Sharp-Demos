using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Father //sealed keyword will seal and not anyone to inherit frm this
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi..Car..");
            }
        }

        class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes Box")
            }
    
        }

        class GrandSon : Son {

            public void BMWCar()
            {
                MessageBox.Show("BMW inheritance ....");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            grandSon.maruthicar();
            grandSon.MBCar();
            grandSon.BMWCar();

            Father father = new Father();
            father.maruthicar();
            //  father.MBCar();   // cant call sub clas function using base class object
            // father.BMWCar();
        }
    }
}
