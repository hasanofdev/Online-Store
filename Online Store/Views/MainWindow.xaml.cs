using Online_Store.Models;
using Online_Store.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Online_Store.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ProductItem> Products;
        public ObservableCollection<ProductItem> Basket;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Basket = new();
            Products = new();

            foreach (var item in FakeData.FakeData.GetProducts)
            {
                ProductsPnl.Children.Add(new ProductItem_UC(item, ref ProductsPnl, Basket));
            }
        }

        private void BasketBtn_Click(object sender, RoutedEventArgs e)
        {
            BasketView basket = new(Basket);
            basket.ShowDialog();
        }
    }
}
