using HR___Manager.DbEntity;

namespace HRManagerModel.Model
{
    public static class EntrUser
    {

        private static User _user;
        public static User User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }
        //public static bool CheckOnTheAdmin() => _user?.UserRole.RoleName == "Администратор";

    }
}
