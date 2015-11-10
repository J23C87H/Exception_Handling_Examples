using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException()
            : base("Custom Exception: ")
        {

        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unhandled_Btn_Click(object sender, EventArgs e)
        {


            int n1 = 1;
            int n2 = 0;
            int res;

            MessageBox.Show("This example shows what happens when a divide by zero exception is NOT handled");

            res = n1 / n2;

        }

        private void handled_Btn_Click(object sender, EventArgs e)
        {

            int n1 = 1;
            int n2 = 0;
            int res;

            MessageBox.Show("This example shows what happens when a divide by zero exception is handled");


            try
            {
                res = n1 / n2;
            }
            catch(DivideByZeroException dbz)
            {
                MessageBox.Show("Exception: " + dbz.Message);
            }

        }

        private void custom_Btn_Click(object sender, EventArgs e)
        {


            try
            {
                throw new CustomException();
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message + " " + textBox1.Text);
            }
        }

        private void reset_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
