using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remainder_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String fName, lName;
            int istVal,stVal,sum;
                istVal = System.Convert.ToInt32(text1.Text);
                stVal = System.Convert.ToInt32(text2.Text);
                sum = istVal + stVal;
            lblout.Text = "Total Value is " + sum.ToString();
            
           // MessageBox.Show("The Sum of tWo Number is " + sum);
        }

        private void Button1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text)){
                e.Cancel = true;
                errorProvider1.SetError(text1, "Please Enter a Value");
                text1.Focus();
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
