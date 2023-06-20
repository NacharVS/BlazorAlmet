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

        
    }



}
