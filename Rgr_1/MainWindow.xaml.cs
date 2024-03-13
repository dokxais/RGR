using System;
using System.Windows;

namespace Rgr_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double x1 = double.Parse(Box_x1.Text);
            double x = x1;
            double x2 = double.Parse(Box_x2.Text);
            double A = double.Parse(Box_A.Text);
            double M = double.Parse(Box_M.Text);
            double y;
            while (x <= x2)
            {
                if (x < 4*A)
                {
                    y = Math.Pow(16*A*A - Math.Pow(x-4*A,2),1.0/4.0);
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;

                }
                else if (x >= 4*A)
                {
                    y = 8*A*A*A/(Math.Pow(x-4*A,2)+4*A*A);
                    Answer.Text += $"y({x}) = " + y.ToString() + Environment.NewLine;
                }
                x += M;
            }
        }
    }
}
