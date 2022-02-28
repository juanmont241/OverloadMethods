using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            instructionLabel.Text = "Enter: \n\n1 value for a circle\n2 values for a rectangle";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double result;
            try
            {
                if (value2Input.Text == "")
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    result = Area(value1);
                }

                else
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    double value2 = Convert.ToDouble(value2Input.Text);
                    result = Area(value1, value2);
                }

                areaOutput.Text = $"{result.ToString(".##")} units squared";
            }

            catch
            {
                areaOutput.Text = "ERROR";
            }
        }

        /// <summary>
        /// This method will calaculate the area of a circle
        /// </summary>
        /// <param name="radius"> value to used</param>
        /// <returns></returns>

        public double Area(double radius)
        {
            //area = pi * r^2
            double area = radius * radius * 3.14;
            return area;
        }

        public double Area(double length, double width)
        {
            double area = length * width;
            return area;
        }

    }
}
