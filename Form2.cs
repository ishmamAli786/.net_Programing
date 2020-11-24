using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_IT_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Class1 st = new Class1();
            st.Speed = 100;
            MessageBox.Show("The Speed of Car Is", st.Speed.ToString());
            Class1 st1 = new Class1();
            st1.Size = 9;
            MessageBox.Show("The Size of Car Is", st1.Size.ToString());
            Class1 st2 = new Class1();
            st2.Weight = 56;
            MessageBox.Show("The Weight of Car Is", st2.Weight.ToString());
            Class1 st3 = new Class1();
            st3.EnginePower = 125;
            MessageBox.Show("The EnginePower of Car Is", st3.EnginePower.ToString());
            Class1 st4 = new Class1();
            st4.Breaks = "black";
            MessageBox.Show("The Color of Car Breaks is", st4.Breaks);
            Class1 st5 = new Class1();
            st5.Range = 70;
            MessageBox.Show("The Range of Car Is", st5.Range.ToString());
            Class1 st6 = new Class1();
            st6.Color = "Blue";
            MessageBox.Show("The Color of Car Is", st6.Color);
            Class1 st7 = new Class1();
            st7.Wheals = "Rounded";
            MessageBox.Show("The Shape of Car Wheals Is", st7.Wheals);
            Class1 st8 = new Class1();
            st8.Fuel = "Yellow";
            MessageBox.Show("The Color of Car Fuel Is", st8.Fuel);
            Class1 st9 = new Class1();
            st9.GearBox = "Square";
            MessageBox.Show("The Shape of Car GearBox Is", st9.GearBox);


        }
    }
}
