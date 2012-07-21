using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace App8
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void ButtonClick(object sender, RoutedEventArgs e)
        {
            // interesting side note:
            // the exception raised below is piped out to our handler
            // but the method itself has an async/await pair
            // and it raises the unhandled exception
            await MethodWithThrow();

            // this code does not suffer that issue
            // and allows you to drop the async keyword from the method signature
            //MethodWithThrow()
        }

        public async Task MethodWithThrow()
        {
            await Task.Delay(1);
            throw new Exception();
        }
    }
}
