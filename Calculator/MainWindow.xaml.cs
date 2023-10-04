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

        List<Calculation> calcstore = new List<Calculation>();

        string calculation = "0";
        Actions action;

        int outcalc = 0;

        enum Actions
        {
            Plus,
            Minus,
            Times,
            Divide,
            None
        }

        private void Update(bool doneCalc)
        {
            if(doneCalc)
            {
                TextBox.Text = outcalc.ToString();
            } else
            {
                TextBox.Text = calculation;
            }
        }

        private void Calculate()
        {
            if (calcstore.Count <= 0) return;

            int number = calcstore[0].inputNumber;
            Actions lastAction = Actions.None;

            for (int i = 0; i < calcstore.Count; i++)
            {
                Calculation c = calcstore[i];

                if(c.action == Actions.None && lastAction != Actions.None)
                {
                    if(lastAction == Actions.Plus)
                    {
                        number += c.inputNumber;
                    } else if(lastAction == Actions.Minus)
                    {
                        number -= c.inputNumber;
                    } else if(lastAction == Actions.Times)
                    {
                        number *= c.inputNumber;
                    } else if(lastAction == Actions.Divide)
                    {
                        number /= c.inputNumber;
                    } else
                    {
                        Task.Factory.StartNew(() => { MessageBox.Show("Could not evaluate"); });
                    }
                } else if(c.action == Actions.Plus)
                {
                    lastAction = c.action;
                    //number += c.inputNumber;
                } else if(c.action == Actions.Minus)
                {
                    lastAction = c.action;
                } else if(c.action == Actions.Times)
                {
                    lastAction = c.action;
                } else if(c.action == Actions.Divide)
                {
                    lastAction = c.action;
                }
            }

            outcalc = number;
            Update(true);

            calcstore.Clear();
        }

        class Calculation
        {
            public Actions action;
            public int inputNumber;
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
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

            Update(false);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            calculation = "0";
            Update(false);
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
            Update(false);
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

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            calcstore.Add(new Calculation()
            {
                action = Actions.None,
                inputNumber = int.Parse(calculation)
            });

            Calculate();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            calcstore.Add(new Calculation()
            {
                action = Actions.Plus,
                inputNumber = int.Parse(calculation)
            });

            calculation = "";
            Update(false);
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            calcstore.Add(new Calculation()
            {
                action = Actions.Minus,
                inputNumber = int.Parse(calculation)
            });

            calculation = "";
            Update(false);
        }

        private void TimesButton_Click(object sender, RoutedEventArgs e)
        {
            calcstore.Add(new Calculation()
            {
                action = Actions.Times,
                inputNumber = int.Parse(calculation)
            });

            calculation = "";
            Update(false);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            calcstore.Add(new Calculation()
            {
                action = Actions.Divide,
                inputNumber = int.Parse(calculation)
            });

            calculation = "";
            Update(false);
        }
    }
}
