using System;
using System.Windows;

namespace skrdb
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(
            object sender,
            RoutedEventArgs e
        )
        {
            await Browser.EnsureCoreWebView2Async();

            Browser.Source = new Uri(
                "https://skrdb.de/login"
            );
        }
    }
}