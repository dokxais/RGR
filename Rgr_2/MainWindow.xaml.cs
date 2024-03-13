
using System;
using System.Windows;


namespace Rgr_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string spisok = "{0,-25}{1,-25}{2,-45}{3,-55}{4,-25}";

        public MainWindow()
        {
            InitializeComponent();
        }
        int fac(int n)
        {
            if (n == 1) return 1;
            return n * fac(n - 1);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Vivod.Items.Clear();
            Vivod.Items.Add(string.Format(spisok, "№", "Значение x", "Значение функции по формуле", "Значение функции по ряду", "ε расч"));

            int M = int.Parse(Box_M.Text);
            double a = double.Parse(Box_a.Text);
            double b = double.Parse(Box_b.Text);
            double h = double.Parse(Box_h.Text);
            double ε = double.Parse(Box_ε.Text);
            double x = a;
            double f2;
            double f1;

            double ε_acuracy;
            for (int i = 1; i <= M; i++)
            {
                if (x <= b)
                {
                    int k = 1;
                    double sum = x;
                    for (f1 = Math.Pow(x,4) / fac(3); ε <= Math.Abs(f1); f1 = Math.Pow(x, 4 * k) / fac(4 * k - 1))
                    {
                        sum = sum + f1;
                        k++;
                    }
                    f2 = x+ x/4 *(Math.Pow(Math.E, x) - 2*Math.Sin(x)-Math.Pow(Math.E,-x));
                    ε_acuracy = Math.Abs(sum - f2);
                    Vivod.Items.Add(string.Format(spisok, i+"\t", "  " + x, "\t  " + f2, "\t\t  " + sum, ε_acuracy));
                    x += h;
                }
            }
        }

    }
}

