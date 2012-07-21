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
            await MethodWithThrow();
        }

        public async Task MethodWithThrow()
        {
            await Task.Delay(1);
            throw new Exception();
        }
    }
}
