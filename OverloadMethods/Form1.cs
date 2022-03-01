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

            titleLabel.Text = "Perimeter Calculator";
            instructionLabel.Text = "Enter: \n\n1 value for a circle\n2 values for a rectangle\n3 values for a traingle";
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            double result;
            try
            {
                if (value2Input.Text == "" && value3Input.Text == "")
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    result = Perimeter(value1);
                }

                else if (value3Input.Text == "")
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    double value2 = Convert.ToDouble(value2Input.Text);
                    result = Perimeter(value1, value2);
                }

                else
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    double value2 = Convert.ToDouble(value2Input.Text);
                    double value3 = Convert.ToDouble(value3Input.Text);
                    result = Perimeter(value1, value2, value3);
                   
                }

                perimeterOutput.Text = $"The Perimeter is {result.ToString(".##")} ";
            }

            catch
            {
                perimeterOutput.Text = "ERROR";
            }
        }

        /// <summary>
        /// This method will measure the perimeter for the circle
        /// </summary>
        /// <param name="diameter"> This measures the diameter and pi</param>
        /// <returns></returns>

        public double Perimeter(double diameter)
        {
            double Perimeter = diameter * 3.14;
            return Perimeter;
        }

        /// <summary>
        /// This method will measure the perimeter for the rectangle
        /// </summary>
        /// <param name="length">Measures the length times 2</param>
        /// <param name="width">Measures the width times 2</param>
        /// <returns></returns>
       
        public double Perimeter(double length, double width)
        {
            double Perimeter = (2 * length) + (2* width);
            return Perimeter;
        }

        /// <summary>
        /// This method will measure the perimeter for the triangle
        /// </summary>
        /// <param name="a">Adds to the sum (a, b, c)</param>
        /// <param name="b">Adds to the sum (a, b, c)</param>
        /// <param name="c">Adds to the sum (a, b, c)</param>
        /// <returns></returns>
       
        public double Perimeter(double a, double b, double c)
        {
            double Perimeter = a + b + c;
            return Perimeter;
        }
    }
}
