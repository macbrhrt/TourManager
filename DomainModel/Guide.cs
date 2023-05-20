using Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #0.3.1 Guide - наследник абстрактного класса Person

    public class Guide : Person, IManipulatePersonalData
    {
        public Guide(string firstname, string lastname, string email,
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

        public List<Tour> PlacedTours = new List<Tour>();
        private string email = String.Empty;

        public bool AddMyTour(Tour newTour) 
        {
            try
            {
                if (Storage.Instance.db.Tours.Contains(newTour)) return false;
                Storage.Instance.db.Tours.Add(newTour);
                PlacedTours.Add(newTour);
            }
            catch (Exception)
            {
                return false;
            }            
            return true;
        }
        public bool DeleteMyTour(int tourID)
        {
            try
            {
                Tour itemToRemove = Storage.Instance.db.Tours.First(it => it.ID == tourID);
                if (itemToRemove != null) {
                    Storage.Instance.db.Tours.Remove(itemToRemove);
                    PlacedTours.Remove(itemToRemove);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static Guide? ById(Guid id)
        {
            return Storage.Instance.db.Guides.FirstOrDefault(it => it.ID == id);
        }
        public static object? Authorization(string _login, string _password)
        {
            Guide? user = Storage.Instance.db.Guides
                .FirstOrDefault(it => it.Login.Equals(_login) && it.Password.Equals(_password));
            CurrentSession.Account = user;
            return user == null ? new Guest() : user;
        }
    }
}
