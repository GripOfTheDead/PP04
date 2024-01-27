using HR___Manager.DbEntity;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace HR___Manager.ViewModel
{
    public class KorzinaMV : BaseViewModel
    {
        private ObservableCollection<Employees> _employees;

        private Employees _employee;

        public KorzinaMV()
        {
            EmployeesCollection = new ObservableCollection<Employees>();
            LoadData();
        }
        public ObservableCollection<Employees> EmployeesCollection
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(EmployeesCollection));
            }
        }

        public Employees SelectAccountData
        {
            get => _employee;
            set
            {
                _employee = value;
                OnPropertyChanged(nameof(SelectAccountData));
            }
        }
        public void LoadData()
        {
            if (_employees.Count > 0)
            {
                _employees.Clear();
            }

            var result = DbHRManager.Db.Employees.ToList();

            result.ForEach(a => EmployeesCollection.Add(a));
        }

        public void DeleteData()
        {
            if (SelectAccountData != null)
            {
                using (var db = new HRManagerEntities())
                {
                    var infoEmployees = db.Employees.Find(SelectAccountData.UserInfoID);
                    if (infoEmployees != null)
                    {
                        db.Employees.Remove(infoEmployees);
                        db.SaveChanges();
                        SelectAccountData = null;
                        LoadData();
                        MessageBox.Show("Объект успешно удален", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите объект для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

