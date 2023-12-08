using GreenThumb.Manager;
using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private async void btn_RegisterUser(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameRegister.Text;
            string password = txtPasswordRegister.Text;

            bool isAdded = await UserManager.RegisterUser(username, password);
            if (isAdded)
            {
                MessageBox.Show("User successfully added!");
            }
            else
            {
                MessageBox.Show("That user already exists!");
            }

        }

        private void btn_GoBackToSignIn(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new();
            signInWindow.Show();
            Close();
        }
    }
}
