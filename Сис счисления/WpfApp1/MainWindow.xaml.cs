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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddForBd AFB = new AddForBd();
        LoadAtBd LAB = new LoadAtBd();
        AnyToDecimal ATD = new AnyToDecimal();
        DecimalToAny DTA = new DecimalToAny();
        MathOpertionSwitch MOS = new MathOpertionSwitch();
        CheckForAnyInconsistency CFAI = new CheckForAnyInconsistency();
        Check CHK = new Check();
        shiaEntities SHIA = new shiaEntities();

        public MainWindow()
        {
            InitializeComponent();
            comboboh.SelectedIndex = 0;
            comboboh_Copy.SelectedIndex = 0;
            comboboh_Copy1.SelectedIndex = 0;
        }

        private int returnmath(string ma)
        {
            if (ma == "+")
            {
                return 1;
            }
            else if (ma == "-")
            {
                return 2;
            }
            else if (ma == "*")
            {
                return 3;
            }
            else if (ma == "/")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool check1 = CFAI.interstelar(enteredfirst.Text), check2 = CFAI.interstelar(enteredsecond.Text), check3, check4;
            int first, second, result, firstcheck = 0, secondcheck, resultcheck, MathOp = returnmath(comboboh_Copy2.Text);
            if (comboboh_Copy2.Text != "")
            {
                if (check1 == true && check2 == true)
                {
                    check3 = CFAI.checkerd(enteredfirst.Text, comboboh.Text, check1);
                    check4 = CFAI.checkerd(enteredsecond.Text, comboboh_Copy.Text, check2);
                    if (check3 == true && check4 == true)
                    {
                        if (comboboh.Text == "10" && comboboh_Copy.Text == "10")
                        {
                            firstcheck = CHK.check(Convert.ToInt32(enteredfirst.Text), 10);
                            secondcheck = CHK.check(Convert.ToInt32(enteredsecond.Text), 10);
                            if (firstcheck > 0 && secondcheck > 0)
                            {
                                resultcheck = CHK.CheckMathOperInBD(Convert.ToInt32(enteredfirst.Text), Convert.ToInt32(comboboh.Text), Convert.ToInt32(enteredsecond.Text), Convert.ToInt32(comboboh_Copy.Text), comboboh_Copy2.Text);
                                if (resultcheck > 0)
                                {
                                    resulted.Text = LAB.ReturnResultMathOper(firstcheck, secondcheck, 10).ToString();
                                }
                                else
                                {
                                    first = Convert.ToInt32(enteredfirst.Text);
                                    second = Convert.ToInt32(enteredsecond.Text);
                                    result = MOS.mathoper(MathOp, first, second);
                                    AFB.insertSisSchis(result);
                                    AFB.insertOperWith(first, 10, second, 10, result, 10, comboboh_Copy2.Text);
                                    resulted.Text = result.ToString();
                                }
                            }
                            else if (firstcheck > 0 && secondcheck == 0)
                            {
                                first = Convert.ToInt32(enteredfirst.Text);
                                second = Convert.ToInt32(enteredsecond.Text);
                                result = MOS.mathoper(MathOp, first, second);
                                AFB.insertSisSchis(second);
                                AFB.insertSisSchis(result);
                                AFB.insertOperWith(first, 10, second, 10, result, 10, comboboh_Copy2.Text);
                                resulted.Text = result.ToString();
                            }
                            else if (firstcheck == 0 && secondcheck > 0)
                            {
                                first = Convert.ToInt32(enteredfirst.Text);
                                second = Convert.ToInt32(enteredsecond.Text);
                                result = MOS.mathoper(MathOp, first, second);
                                AFB.insertSisSchis(first);
                                AFB.insertSisSchis(result);
                                AFB.insertOperWith(first, 10, second, 10, result, 10, comboboh_Copy2.Text);
                                resulted.Text = result.ToString();
                            }
                            else
                            {
                                first = Convert.ToInt32(enteredfirst.Text);
                                second = Convert.ToInt32(enteredsecond.Text);
                                result = MOS.mathoper(MathOp, first, second);
                                AFB.insertSisSchis(first);
                                AFB.insertSisSchis(second);
                                AFB.insertSisSchis(result);
                                AFB.insertOperWith(first, 10, second, 10, result, 10, comboboh_Copy2.Text);
                                resulted.Text = result.ToString();
                            }
                        }
                        else if (comboboh.Text == "10" && comboboh_Copy.Text != "10")
                        {

                        }
                        else if (comboboh.Text != "10" && comboboh_Copy.Text == "10")
                        {

                        }
                        else
                        {

                        }
                    }
                    else if (check4 == true)
                    {
                        MessageBox.Show("первое число");
                    }
                    else
                    {
                        MessageBox.Show("второе число");
                    }
                }
                else if (check2 == true)
                {
                    MessageBox.Show("первое число");
                }
                else
                {
                    MessageBox.Show("второе число");
                }
            }
            else
            {
                MessageBox.Show("Не выбранн знак операции");
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            comboboh.SelectedIndex = 0;
            comboboh_Copy.SelectedIndex = 0;
            comboboh_Copy1.SelectedIndex = 0;
            enteredfirst.Clear();
            enteredsecond.Clear();
            resulted.Clear();
        }
    }
}

