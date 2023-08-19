using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Input;
using BCrypt.Net;

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CredentialsManager credManager = new CredentialsManager();
        public MainWindow()
        {
            InitializeComponent();
        }
        //drag screen
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //Login button
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = userTxt.Text;

            string password = passTxt.Password;


            if (credManager.Authenticate(username, password))
            {
                var successWindow = new SuccessWindow();
                successWindow.Show();
                Close();
            } else
            {
                MessageBox.Show("Invalid Username or Password. Please try again!", "Wrong Credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
