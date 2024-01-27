using HR___Manager.View;
using HR___Manager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HR___Manager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public KorzinaMV _korzinaVM;
        private AddOrEditWindpws _AddOrEditWindpws;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new KorzinaMV();
            _korzinaVM = new KorzinaMV();
            
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //Обработчик нажатия на кнопку - Закрытие приложения
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        //Информация о программе
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данное приложение создано для заказов Спецальной одежды для разных спецслужб: Военные, пожарные и прочие\n\n" +
                "Приложение находится на стадии разработки, все жалобы и предложения присылайте на почту: holodok522@mail.ru\n\n" +
                "Я обязательно учту каждое предложение и постараюсь решить ваши проблемы\n\n" +
                "Над проектом работал:\nФилипьев Констрантин Олегович\n" +
                "Студент группы ИС-32\n\n\n" +
                "Версия приложения на момент показа: v0.1.1", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        //Обработка нажатия на кнопку - Обновление бд
        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as KorzinaMV).LoadData();
        }

        //Обработчик нажатия на кнопку - Сохранение информации
        private void btnSaveClick_Click(object sender, RoutedEventArgs e)
        {

        }

        #region
        private void DobavitVKorzinu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("В разработке", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        #endregion

        #region
        //Делает Border с информацией о товаре видимым
        /*private void btnBrowseItem_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib = Visibility.Visible;
        }

        //Делает Border с информацией о товаре невидимым
        private void btnInv_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib = Visibility.Hidden;
        }
        #endregion
        #region
        //Делает Border с Редактированием данных Видимым
        private void btnRedact_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib2 = Visibility.Visible;
        }

        //Делает Border с Редактированием данных невидимыми
        private void btnInvBorder2Click_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib2 = Visibility.Hidden;
        }
        #endregion
        #region
        //Делает Border Корзины данных Видимым
        private void btnKorzina_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib3 = Visibility.Visible;
        }
        //Делает Border Корзины данных Нивидимым
        private void btnInvBorder3Click_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).BtnVisib3 = Visibility.Hidden;
        }*/
        #endregion

       

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            var addOrEdit = new AddOrEditWindpws(_korzinaVM.SelectAccountData);
            _AddOrEditWindpws = addOrEdit;
            addOrEdit.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addOrEdit = new AddOrEditWindpws(null);
            addOrEdit.Show();
        }
    }

}

