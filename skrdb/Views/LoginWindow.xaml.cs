using System.Windows;

namespace skrdb.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(
            object sender,
            RoutedEventArgs e
        )
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(username))
            {
                StatusTextBlock.Text = "Bitte Benutzername eingeben.";
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                StatusTextBlock.Text = "Bitte Passwort eingeben.";
                return;
            }

            StatusTextBlock.Text = "Login wird geprüft...";

            MessageBox.Show(
                $"Benutzer: {username}",
                "Test",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}