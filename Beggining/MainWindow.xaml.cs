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

namespace Beggining
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
            try
            {

            double var1 = double.Parse(Var1.Text);
            double var2 = double.Parse(Var2.Text);
            double S = var1 + var2;
            Result.Text = S.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                double var1 = double.Parse(Var1.Text);
                double var2 = double.Parse(Var2.Text);
                double S = var1 - var2;
                Result.Text = S.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

                double var1 = double.Parse(Var1.Text);
                double var2 = double.Parse(Var2.Text);
                double S = var1 * var2;
                Result.Text = S.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {

                double var1 = double.Parse(Var1.Text);
                double var2 = double.Parse(Var2.Text);
                if (var2 == 0) MessageBox.Show("Деление на ноль запрещено");
                else
                {
                    double S = var1 / var2;
                    Result.Text = S.ToString();
                }                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}