namespace BlazorAlmet.Data
{
    public class User
    {
        public User(string name, string surname, string email, int age, bool isDriver, string vacancy)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Age = age;
            IsDriver = isDriver;
            Vacancy = vacancy;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsDriver { get; set; }
        public string Vacancy { get; set; }

        public static List<User> GetSomeUsers()
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
