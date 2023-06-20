using BlazorAlmet.Data;

namespace BlazorAlmet.Servises
{
    public class UserService
    {
        public  User GetSingleUser()
        {
            return new User("Petr", "Petrov", "Petr@mail.ru", 22, true, "Driver");
        }
        public List<User> GetSomeUsers()
        {
            var list = new List<User>();
            list.Add(new User("Ivan", "Ivanov", "IvanIvanov@mail.ru", 33, false, "Manager"));
            list.Add(new User("Petr", "Petrov", "Petr@mail.ru", 22, true, "Driver"));
            list.Add(new User("Fedor", "Ivanov", "FedorIvanov@mail.ru", 42, true, "TeamLeader"));
            list.Add(new User("Ivan", "Ivanov", "IvanIvanov@mail.ru", 44, false, "Manager"));
            list.Add(new User("Ivan", "Ivanov", "IvanIvanov@mail.ru", 51, true, "Manager"));
            return list;
        }
    }
}
