using KinopoiskApp.ViewModels;
using KinopoiskApp.Views;
using Windows.UI.Xaml.Controls;

namespace KinopoiskApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(MoviesPageView));
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer is NavigationViewItem item)
            {
                var tag = item.Tag?.ToString();

                switch (tag)
                {
                    case "movies":
                        ContentFrame.Navigate(typeof(MoviesPageView));
                        break;
                    case "favorites":
                        ContentFrame.Navigate(typeof(FavoritesPageView));
                        break;
                }
            }
        }
    }
}