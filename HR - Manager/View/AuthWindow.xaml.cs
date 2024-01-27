using HR___Manager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HR___Manager.View
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public static AuthWindow autorizationWindow;
        public AuthWindow()
        {
            InitializeComponent();
            this.DataContext = new AuthViewModel();
            autorizationWindow = this;
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AuthViewModel).Password = txtPasswordBox.Password.ToString();

            (DataContext as AuthViewModel).AuthorInApp();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
