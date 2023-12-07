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

            if ()
            {
                // Create a User

                await UserManager.RegisterUser(username, password);

                MessageBox.Show("You have successfully registered!", "Well done");

                // Öppna window
            }
            else if (UserManager.ValidateUsername(username) == false)
            {
                MessageBox.Show("That Username is already taken!", "Warning");
            }
            else
            {
                MessageBox.Show("Some of the fields are empty!", "Warning!");
            }
        }
    }
}
