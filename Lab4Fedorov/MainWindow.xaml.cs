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

namespace Lab4Fedorov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Price<int>[]? Products { get; set; } = null;
        private bool isNameSort = true;
        private bool isPriceSort = true;
        public MainWindow()
        {
            InitializeComponent();
            mmCopy.IsEnabled = false;
            mmCreate.IsEnabled = false;
            tbCreate.IsEnabled = false;
            tbCopy.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbCount.Text.Length != 0)
            {
                Products = null;
                Products = new Price<int>[int.Parse(tbCount.Text)];
                MessageBox.Show("Массив размером " + Products.Length + " элемента создан");
                Price<int>.Count = 0;
                mmCopy.IsEnabled = true;
                mmCreate.IsEnabled = true;
                tbCreate.IsEnabled = true;
                tbCopy.IsEnabled = true;
                productList.ItemsSource = null;
                stCount.Content = "Создано " + Price<int>.Count + " из " + tbCount.Text;
            }
            else
            {
                MessageBox.Show("Введите размер массива");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Add();
        }

        private void mmCopy_Click(object sender, RoutedEventArgs e)
        {
            Copy();
        }
        void GridViewColumnHeaderClickedHandler(object sender,
                                        RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            if (headerClicked!.Content.ToString() == "Название магазина")
            {
                if (isNameSort)
                {
                    Array.Sort(Products!);
                }
                else
                {
                    Products = Products!.OrderByDescending(p => p.NameShop).ToArray();
                }
                isNameSort = !isNameSort;
            }
            else if (headerClicked.Content.ToString() == "Цена")
            {
                if (isPriceSort)
                {
                    Array.Sort(Products!, new PriceComparator());
                }
                else
                {
                    Products = Products!.OrderByDescending(p => p.PriceRub).ToArray();
                }
                isPriceSort = !isPriceSort;
            }
            productList.ItemsSource = null;
            productList.ItemsSource = Products;
        }

        private void tbCopy_Click(object sender, RoutedEventArgs e)
        {
            Copy();
        }

        private void tbCreate_Click(object sender, RoutedEventArgs e)
        {
            Add();
        }

        private void Copy()
        {
            if (productList.SelectedItems.Count != 0)
            {
                Price<int>? price = productList.SelectedItem as Price<int>;
                Products![Price<int>.Count] = (Price<int>)price!.Clone();
                productList.ItemsSource = null;
                productList.ItemsSource = Products;
                Price<int>.Count++;
                stCount.Content = "Создано " + Price<int>.Count + " из " + tbCount.Text;
            }
        }

        private void Add()
        {
            if (Products!.Length > Price<int>.Count)
            {
                AddProduct add = new AddProduct();
                if (add.ShowDialog() == true)
                {
                    Products[Price<int>.Count] = new Price<int>();
                    Products[Price<int>.Count].IdProduct = add.ID;
                    Products[Price<int>.Count].NameShop = add.Name;
                    Products[Price<int>.Count].PriceRub = add.Price;
                    Price<int>.Count++;
                }
                productList.ItemsSource = null;
                productList.ItemsSource = Products;
                stCount.Content = "Создано " + Price<int>.Count + " из " + tbCount.Text;
            }
            else
            {
                MessageBox.Show("Массив полностью заполнен");
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }
    }
}