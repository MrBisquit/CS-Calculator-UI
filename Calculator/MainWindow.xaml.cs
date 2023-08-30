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
        public MainWindow()
        {
            InitializeComponent();
        }

        string calculation = "0";

        private void Update()
        {
            TextBox.Text = calculation;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if(calculation == "0")
            {
                calculation = "1";
            } else
            {
                calculation += "1";
            }

            Update();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if(calculation == "0")
            {
                calculation = "2";
            } else
            {
                calculation += "2";
            }

            Update();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if(calculation == "0")
            {
                calculation = "3";
            } else
            {
                calculation += "3";
            }

            Update();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "4";
            }
            else
            {
                calculation += "4";
            }

            Update();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "5";
            }
            else
            {
                calculation += "5";
            }

            Update();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "6";
            }
            else
            {
                calculation += "6";
            }

            Update();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "7";
            }
            else
            {
                calculation += "7";
            }

            Update();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "8";
            }
            else
            {
                calculation += "8";
            }

            Update();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "0")
            {
                calculation = "9";
            }
            else
            {
                calculation += "9";
            }

            Update();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if(calculation == "0")
            {
                // Do nothing because we don't need to.
            } else
            {
                calculation += "0";
            }

            Update();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            calculation = "0";
            Update();
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            char[] splitCalculation = calculation.ToCharArray();
            string newCalculation = "";
            for (int i = 0; i < splitCalculation.Length - 1; i++)
            {
                newCalculation += splitCalculation[i];
            }
            
            if (newCalculation == "")
            {
                calculation = "0";
            }
            else
            {
                calculation = newCalculation;
            }
            Update();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                    Zero_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D1:
                    One_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D2:
                    Two_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D3:
                    Three_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D4:
                    Four_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D5:
                    Five_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D6:
                    Six_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D7:
                    Seven_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D8:
                    Eight_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.D9:
                    Nine_Click(new object(), new RoutedEventArgs());
                    break;
                case Key.Back:
                    Backspace_Click(new object(), new RoutedEventArgs());
                    break;
            }
        }
    }
}
