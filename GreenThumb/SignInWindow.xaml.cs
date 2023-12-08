using GreenThumb.Manager;
using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private async void btn_SignIn(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool IsAuthenticated = await UserManager.SignInUser(username, password);

            if (IsAuthenticated)
            {
                PlantWindow plWindow = new();
                plWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or password!", "Warning");
            }

        }

        private void btn_GoToRegister(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.Show();
            Close();
        }
    }
}
