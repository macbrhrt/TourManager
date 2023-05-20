using Behavior;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #0.3.2 RegisteredPerson - наследник абстрактного класса Person
    public class RegisteredPerson : Person, IManipulatePersonalData, IEnumerable
    {
        public RegisteredPerson(string firstname, string lastname, string email, 
            string login, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Login = login;
            Password = password;
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string Email
        {
            get => email;
            set
            {
                if (value.Length < 3 || value.Length > 40) throw new Exception("Incorrect Email format");
                if (Storage.Instance.db.Guides.FirstOrDefault(it => it.Email == value) == null
                    || Storage.Instance.db.RegisteredPersons.FirstOrDefault(it => it.Email == value) == null) email = value;
                else throw new Exception("Login must be unique");
            }
        }
        public List<TicketTour> UpcomingTourTickets = new List<TicketTour>();
        private string email = String.Empty;

        public static RegisteredPerson? ById(Guid id)
        {
            return Storage.Instance.db.RegisteredPersons.FirstOrDefault(it => it.ID == id);
        }
        public static object? Authorization(string _login, string _password)
        {
            RegisteredPerson ? user = Storage.Instance.db.RegisteredPersons
                .FirstOrDefault(it => it.Login.Equals(_login) && it.Password.Equals(_password));
            CurrentSession.Account = user;
            return user==null?new Guest():user;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public TicketEnum GetEnumerator()
        {
            return new TicketEnum(UpcomingTourTickets);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
