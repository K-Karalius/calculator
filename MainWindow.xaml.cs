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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    enum Operation {None, Addition, Subtraction, Multiplication, Division}

    public partial class MainWindow : Window
    {
        

        private String savedNumber;
        private Operation operation;
        private bool IsEqualExecuted;
        public MainWindow()
        {
            InitializeComponent();
            answer.Text = "0";
            savedNumber = "";
            operation = Operation.None;
            IsEqualExecuted = false;
        }
        
        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeOperation(Operation.Division);
        }

        private void MultipleButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeOperation(Operation.Multiplication);
        }

        private void SubtractionButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeOperation(Operation.Subtraction);

        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeOperation(Operation.Addition);

        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (!answer.Text.Contains('.'))
            {
                AddToNumber('.');
            }

        }
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double temp;
            switch (operation)
            {
                case Operation.Addition:
                    temp = (Double.Parse(savedNumber) + Double.Parse(answer.Text));
                    answer.Text = temp.ToString();
                    break;
                case Operation.Subtraction:
                    temp = (Double.Parse(savedNumber) - Double.Parse(answer.Text));
                    answer.Text = temp.ToString();
                    break;
                case Operation.Multiplication:
                    temp = (Double.Parse(savedNumber) * Double.Parse(answer.Text));
                    answer.Text = temp.ToString();
                    break;
                case Operation.Division:
                    if (answer.Text.Equals("0"))
                    {
                        temp = Double.NaN;
                        answer.Text = temp.ToString();
                    }
                    else
                    {
                        temp = (Double.Parse(savedNumber) / Double.Parse(answer.Text));
                        answer.Text = temp.ToString();
                    }
                    break;
                case Operation.None:
                    break;
            }
            operation = Operation.None;
            IsEqualExecuted = true;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = "0";
            savedNumber = "";
            operation = Operation.None;

        }
        
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('0');
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('1');
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('2');
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('3');
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('4');
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('5');
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('6');
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('7');
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('8');
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            AddToNumber('9');
        }

        private void AddToNumber(char charToAdd)
        {
            if (IsEqualExecuted)
            {
                answer.Text = "0";
                IsEqualExecuted = false;
            }

            if (answer.Text.Count(c => c == '0') == answer.Text.Length && charToAdd != '.')
            {
                answer.Text = charToAdd.ToString();
                IsEqualExecuted = false;
            }
            else
            {
                answer.Text += charToAdd;
            }
            
        }

        private void ChangeOperation(Operation oper)
        {
            if (operation == Operation.None)
            {
                operation = oper;
                savedNumber = answer.Text.ToString();
                answer.Text = "0";
            }
            else
            {
                operation = oper;
            }
        }
      
    }
}
