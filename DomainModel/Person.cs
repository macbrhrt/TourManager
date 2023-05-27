namespace DomainModel
{
    //ToDo #0.2 Первый абстрактный класс Person

    public abstract class Person : IPerson
    {

        public Guid ID { get; set; } = Guid.NewGuid();
        private string login = string.Empty;
        private string password = string.Empty;
        public string Login { 
            get => login; 
            set
            {
                if (value.Length < 3 || value.Length > 40) throw new Exception("Довжина логіну має бути від 3 до 40 символів");
                if (Storage.Instance.db.Guides.FirstOrDefault(it => it.Login == value) == null
                    || Storage.Instance.db.RegisteredPersons.FirstOrDefault(it => it.Login == value) == null) login = value;
                else throw new Exception("Логін вже зайнятий");
            }
        }
        public string Password { 
            get => password;
            set
            {
                if (value.Length >= 6 && value.Length <= 40)
                    password = value;
                else throw new Exception("Довжина паролю має бути від 6 до 40 символів");
            }
        }

        public static bool ChangePassword(Person person, string email, string oldPassword, string newPassword)
        {
            try
            {
                if (person.Password == oldPassword)
                {
                    person.Password = newPassword;
                }
                else throw new Exception();
            }
            catch
            {
                return false;
            }
            return true;
        }
       
        public override string ToString()
        {
            return $"{ID} | {Login} | {Password}";
        }
    }   
}