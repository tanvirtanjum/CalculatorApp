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
using MySql.Data;

namespace CalculatorApp
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

        private void pBTN_Click(object sender, RoutedEventArgs e)
        {
            numberchecking nc = new numberchecking();
            operation op = new operation();

            if (nc.checking(ftb.Text, stb.Text) == true)
            {
                double result = op.addition(nc);
                rTB.Text = "" + result;
            }

            else
            {
                rTB.Text = "Invalid Input/s. Try again.";
            }
        }

        private void mBTN_Click(object sender, RoutedEventArgs e)
        {
            numberchecking nc = new numberchecking();
            operation op = new operation();

            if (nc.checking(ftb.Text, stb.Text) == true)
            {
                double result = op.subtraction(nc);
                rTB.Text = "" + result;
            }

            else
            {
                rTB.Text = "Invalid Input/s. Try again."; ;
            }
        }

        private void muBTN_Click(object sender, RoutedEventArgs e)
        {
            numberchecking nc = new numberchecking();
            operation op = new operation();

            if (nc.checking(ftb.Text, stb.Text) == true)
            {
                double result = op.multiplication(nc);
                rTB.Text = "" + result;
            }

            else
            {
                rTB.Text = "Invalid Input/s. Try again.";
            }
        }

        private void dBTN_Click(object sender, RoutedEventArgs e)
        {
            numberchecking nc = new numberchecking();
            operation op = new operation();

            if (nc.checking(ftb.Text, stb.Text) == true)
            {
                try
                {
                    double result = op.division(nc);
                    rTB.Text = "" + result;
                }

                catch(Exception ex)
                {
                    rTB.Text = "" + ex.Message;
                }
            }

            else
            {
                rTB.Text = "Invalid Input/s. Try again.";
            }
        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            ftb.Text = "";
            stb.Text = "";
            rTB.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(ftb.IsFocused == false && stb.IsFocused == false)
            {
                switch (e.Key)
                {
                    case Key.Enter:
                        {
                            ftb.Clear();
                            stb.Clear();
                            rTB.Clear();
                            break;
                        }
                    case Key.A:
                        {
                            numberchecking nc = new numberchecking();
                            operation op = new operation();

                            if (nc.checking(ftb.Text, stb.Text) == true)
                            {
                                double result = op.addition(nc);
                                rTB.Text = "" + result;
                            }

                            else
                            {
                                rTB.Text = "Invalid Input/s. Try again.";
                            }
                            break;
                        }
                    case Key.S:
                        {
                            numberchecking nc = new numberchecking();
                            operation op = new operation();

                            if (nc.checking(ftb.Text, stb.Text) == true)
                            {
                                double result = op.subtraction(nc);
                                rTB.Text = "" + result;
                            }

                            else
                            {
                                rTB.Text = "Invalid Input/s. Try again.";
                            }
                            break;
                        }
                    case Key.M:
                        {
                            numberchecking nc = new numberchecking();
                            operation op = new operation();

                            if (nc.checking(ftb.Text, stb.Text) == true)
                            {
                                double result = op.multiplication(nc);
                                rTB.Text = "" + result;
                            }

                            else
                            {
                                rTB.Text = "Invalid Input/s. Try again.";
                            }
                            break;
                        }
                    case Key.D:
                        {
                            numberchecking nc = new numberchecking();
                            operation op = new operation();

                            if (nc.checking(ftb.Text, stb.Text) == true)
                            {
                                double result = op.division(nc);
                                rTB.Text = "" + result;
                            }

                            else
                            {
                                rTB.Text = "Invalid Input/s. Try again.";
                            }
                            break;
                        }
                    case Key.Escape:
                        {
                            this.Close();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            switch (e.Key)
            {
                case Key.Enter:
                    {
                        ftb.Clear();
                        stb.Clear();
                        rTB.Clear();
                        break;
                    }
                case Key.Escape:
                    {
                        this.Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }

    
}
