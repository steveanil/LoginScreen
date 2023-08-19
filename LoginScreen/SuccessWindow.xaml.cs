using System;
using System.Windows;
using System.Windows.Input;


namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for SuccessWindow.xaml
    /// </summary>
    public partial class SuccessWindow : Window
    {
        public SuccessWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
