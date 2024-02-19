using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3Fedorov
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
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                Money m1 = new Money()
                {
                    Rubles = long.Parse(FirstOne.Text),
                    Cent = byte.Parse(FirstTwo.Text)
                };
                Money m2 = new Money()
                {
                    Rubles = long.Parse(SecondOne.Text),
                    Cent = byte.Parse(SecondTwo.Text)
                };
                Money res = m1 + m2;
                Result.Text = res.ToString();
            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                Money m1 = new Money()
                {
                    Rubles = long.Parse(FirstOne.Text),
                    Cent = byte.Parse(FirstTwo.Text)
                };
                Money m2 = new Money()
                {
                    Rubles = long.Parse(SecondOne.Text),
                    Cent = byte.Parse(SecondTwo.Text)
                };
                Money res = m1 - m2;
                Result.Text = res.ToString();
            }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                Money m1 = new Money()
                {
                    Rubles = long.Parse(FirstOne.Text),
                    Cent = byte.Parse(FirstTwo.Text)
                };
                Money m2 = new Money()
                {
                    Rubles = long.Parse(SecondOne.Text),
                    Cent = byte.Parse(SecondTwo.Text)
                };
                Money res = m1 * m2;
                Result.Text = res.ToString();
            }

            private void Button_Click_3(object sender, RoutedEventArgs e)
            {
                Money m1 = new Money()
                {
                    Rubles = long.Parse(FirstOne.Text),
                    Cent = byte.Parse(FirstTwo.Text)
                };
                Money m2 = new Money()
                {
                    Rubles = long.Parse(SecondOne.Text),
                    Cent = byte.Parse(SecondTwo.Text)
                };
                Result.Text = (m1 == m2).ToString();
            }
        }
}

