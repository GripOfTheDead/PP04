using HR___Manager.DbEntity;
using HR___Manager.View;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HRManagerModel.Model;
using HR___Manager;
using HR___Manager.ViewModel;

namespace HR___Manager.ViewModel
{
    public class AuthViewModel : BaseViewModel
    {
        private string _buttonDescription = "Войти";
        private User _user;
        private string _login;
        private string _password;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ButtonDes
        {
            get => _buttonDescription;
            set
            {
                _buttonDescription = value;
                OnPropertyChanged(nameof(ButtonDes));
            }
        }
        public async Task<bool> Authorization(string login, string password)
        {
            try
            {

                var result = await DbHRManager.Db.User.FirstOrDefaultAsync(user => user.Login == login && user.Password == password);
                _user = result;
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Исключения!", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
        }

        public async void AuthorInApp()
        {
            ButtonDes = "Подождите";

            if (await Authorization(Login, Password))
            {
                EntrUser.User = _user;
                
                var newWindow = new MainWindow();
                newWindow.Show();

                MessageBox.Show("Вы успешно авторизировались!", "Авторизация!", MessageBoxButton.OK, MessageBoxImage.Information);

                foreach (var item in App.Current.Windows)
                {
                    if (item is AuthWindow)
                    {
                        (item as Window)?.Close();
                    }
                }
                ButtonDes = "Войти";
                return;

            }
            MessageBox.Show("Неверный логин или пароль, или пустые поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            ButtonDes = "Войти";

        }

    }
}
