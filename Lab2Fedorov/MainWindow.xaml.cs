using Lab2Fedorov.model;
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

namespace Lab2Fedorov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double RateDollar = 89.52;
        private double RateEuro = 97.09;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DollarVariant.IsChecked == true)
            {
                Dollar dollar = new Dollar(int.Parse(SecondSize.Text), RateDollar);
                ResFirst.Text = dollar.Trade().ToString();
            }
            else
            {
                Euro euro = new Euro(int.Parse(SecondSize.Text), RateEuro);
                ResFirst.Text = euro.Trade().ToString();
            }
        }
    }
}