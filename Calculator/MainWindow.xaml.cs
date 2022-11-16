using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate cal = new Calculate();

        double memory;

        public MainWindow()
        {
            InitializeComponent();
            buttonsbox.IsEnabled = false;
            displayTextbox.IsEnabled = false;
        }


        private void NumOpButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            displayTextbox.Text += button.Content.ToString();
        }

        private void MemoryAdd(object sender, RoutedEventArgs e)
        {
            int opPos = 0;
            if (displayTextbox.Text.Contains("="))
            {
                opPos = displayTextbox.Text.IndexOf("=");
            }
            memory = Double.Parse(displayTextbox.Text.Substring(opPos + 1, displayTextbox.Text.Length - opPos - 1));
        }

        private void MemoryDel(object sender, RoutedEventArgs e)
        {
            memory = 0;
        }

        private void MemoryPut(object sender, RoutedEventArgs e)
        {
            displayTextbox.Text += memory;
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                displayTextbox.Text = "Error! Try again.";
            }
        }

        private void FuncButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == onButton)
            {
                displayTextbox.Text = "";
                buttonsbox.IsEnabled = true;
                displayTextbox.IsEnabled = true;
            }
            else if (sender == offButton)
            {
                displayTextbox.Text = "Off";
                buttonsbox.IsEnabled = false;
                displayTextbox.IsEnabled = false;
            }
            else if (sender == clearButton)
            {
                displayTextbox.Text = "";
            }
        }

        public void Calculate()
        {
                int opPos = 0;
                double value1 = 0;
                double value2 = 0;
                double result = 0;
                string op = "";
                if (displayTextbox.Text.Contains("sin") || displayTextbox.Text.Contains("cos") || displayTextbox.Text.Contains("tan") || displayTextbox.Text.Contains("log10") || displayTextbox.Text.Contains("ln"))
                {
                    int opPos1 = 0; int opPos2 = 0;
                    opPos1 = displayTextbox.Text.IndexOf("("); opPos2 = displayTextbox.Text.IndexOf(")");
                    value1 = Double.Parse(displayTextbox.Text.Substring(opPos1 + 1, opPos2 - opPos1 - 1));
                    if (displayTextbox.Text.Contains("sin")) result = cal.sin(value1);
                    if (displayTextbox.Text.Contains("cos")) result = cal.cos(value1);
                    if (displayTextbox.Text.Contains("tan")) result = cal.tan(value1);
                    if (displayTextbox.Text.Contains("log10")) result = cal.log10(value1);
                    if (displayTextbox.Text.Contains("ln")) result = cal.ln(value1);
                    displayTextbox.Text += "= " + result.ToString();
                }
                else {

                    if (displayTextbox.Text.Contains("*"))
                    {
                        opPos = displayTextbox.Text.IndexOf("*");
                    }
                    else if (displayTextbox.Text.Contains("/"))
                    {
                        opPos = displayTextbox.Text.IndexOf("/");
                    }
                    else if (displayTextbox.Text.Contains("+"))
                    {
                        opPos = displayTextbox.Text.IndexOf("+");
                    }
                    else if (displayTextbox.Text.Contains("-"))
                    {
                        opPos = displayTextbox.Text.IndexOf("-");
                    }

                    value1 = Double.Parse(displayTextbox.Text.Substring(0, opPos));
                    op = displayTextbox.Text.Substring(opPos, 1);
                    value2 = Double.Parse(displayTextbox.Text.Substring(opPos + 1, displayTextbox.Text.Length - opPos - 1));

                    if (op == "*")
                    {
                        result = cal.multiply(value1, value2);
                        displayTextbox.Text += "= " + result.ToString();
                    }
                    else if (op == "/")
                    {
                        if (value2 == 0)
                        {
                            displayTextbox.Text = "Cannot divide by zero!";
                        }
                        else
                        {
                            result = cal.divide(value1, value2);
                            displayTextbox.Text += "= " + result.ToString();
                        }
                    }
                    else if (op == "+")
                    {
                        result = cal.add(value1, value2);
                        displayTextbox.Text += "= " + result.ToString();
                    }
                    else if (op == "-")
                    {
                        result = cal.subtract(value1, value2);
                        displayTextbox.Text += "= " + result.ToString();
                    }
                }
        }

        private void CalculateSin(object sender, RoutedEventArgs e)
        {
            double value = 0;
            double result = 0;
            value = Double.Parse(displayTextbox.Text.Substring(0, displayTextbox.Text.Length));
            //value = value * Math.PI / 180;
            result = cal.sin(value);
            displayTextbox.Text = "";
            displayTextbox.Text += "sin(" + value + ") = " + result.ToString();
        }

        private void CalculateCos(object sender, RoutedEventArgs e)
        {
            double value = 0;
            double result = 0;
            value = Double.Parse(displayTextbox.Text.Substring(0, displayTextbox.Text.Length));
            //value = value * Math.PI / 180;
            result = cal.cos(value);
            displayTextbox.Text = "";
            displayTextbox.Text += "cos(" + value + ") = " + result.ToString();
        }

        private void CalculateTan(object sender, RoutedEventArgs e)
        {
            double value = 0;
            double result = 0;
            value = Double.Parse(displayTextbox.Text.Substring(0, displayTextbox.Text.Length));
            //value = value * Math.PI / 180;
            result = cal.tan(value);
            displayTextbox.Text = "";
            displayTextbox.Text += "tan(" + value + ") = " + result.ToString();
        }

        private void CalculateLog10(object sender, RoutedEventArgs e)
        {
            double value = 0;
            double result = 0;
            value = Double.Parse(displayTextbox.Text.Substring(0, displayTextbox.Text.Length));
            result = cal.log10(value);
            displayTextbox.Text = "";
            displayTextbox.Text += "log10(" + value + ") = " + result.ToString();
        }

        private void CalculateLn(object sender, RoutedEventArgs e)
        {
            double value = 0;
            double result = 0;
            value = Double.Parse(displayTextbox.Text.Substring(0, displayTextbox.Text.Length));
            result = cal.ln(value);
            displayTextbox.Text = "";
            displayTextbox.Text += "ln(" + value + ") = " + result.ToString();
        }



    }
}
