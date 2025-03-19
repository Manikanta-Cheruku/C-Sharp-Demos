using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritancePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("*******************");
            }

            public abstract void area(int x, int y);
        }
        class Triangle : Polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("Area of Triangle :" + (0.5* x * y));
            }
        }

        class Rectangle : Polygon
        {
            public override void area(int x, int y)
            {
                MessageBox.Show("Area of Rectangle :" + (x * y));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Polygon obj;
            obj = new Triangle();
            obj.area(12, 20);
            obj = new Rectangle();
            obj.area(12, 20);
            obj.testfunction();
        }
    }
}
