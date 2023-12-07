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

            bool isNotAuthenticated = await UserManager.SignInUser(username, password);

            if (isNotAuthenticated)
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
    }
}
