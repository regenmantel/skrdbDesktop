using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
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
            string userDataFolder = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ),
                "SKRDB",
                "WebView2"
            );

            CoreWebView2Environment environment =
                await CoreWebView2Environment.CreateAsync(
                    userDataFolder: userDataFolder
                );

            await Browser.EnsureCoreWebView2Async(
                environment
            );

            Browser.Source = new Uri(
                "https://skrdb.de/"
            );
        }
    }
}