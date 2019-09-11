using AlamoCorp.UWP.Core.Models.Core;
using AlamoCorp.UWP.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace AlamoCorp.UWP.Views
{
    public sealed partial class ProductsLanding : UserControl
    {
        private List<Product> Products;
        public ProductsLanding()
        {
            this.InitializeComponent();
            SetValues();
        }

        private async void SetValues()
        {
            Products = await ProductsService.GetProductsAsync();
            ProductsGridView.ItemsSource = Products;
        }

        private void OnItemClicked(object sender, ItemClickEventArgs e)
        {
            var Product = (Product)e.ClickedItem;
            //Image img = new Image();
            //BitmapImage bitmapImage = new BitmapImage();
            //Uri uri = new Uri(Product.MainImageURL);
            //bitmapImage.UriSource = uri;

            ProductImage.Source = new BitmapImage(new Uri(Product.MainImageURL));
            ProductName.Text = Product.Name;
            Description.Text = Product.Description;
            Price.Text = Product.Price.ToString();

        }

        private void OnAddtoCart(object sender, RoutedEventArgs e)
        {

        }

        private void OnPlaceOrder(object sender, RoutedEventArgs e)
        {

        }
    }
}
