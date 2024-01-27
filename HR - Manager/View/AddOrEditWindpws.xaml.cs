using HR___Manager.DbEntity;
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
using System.Windows.Shapes;

namespace HR___Manager.View
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditWindpws.xaml
    /// </summary>
    public partial class AddOrEditWindpws : Window
    {
        public Employees _employees;
        private readonly KorzinaMV _KorzinaVM;
        public AddOrEditWindpws(Employees employees)
        {
            InitializeComponent();
            _KorzinaVM = new KorzinaMV();
            
            if (employees is null)
            {
                _employees = employees = new Employees();
            }
            else
            {
                _employees = employees;
            }

            this.DataContext = _employees;
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
