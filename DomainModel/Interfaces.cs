using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #0.1 Интерфейсы

    public interface IPerson
    {
        public static abstract bool ChangePassword
            (Person person, string email, string oldPassword, string newPassword);
        public string Login { get; set; }
        public string Password { get; set; }
    }
    public interface IManipulatePersonalData
    {
        public static abstract object? Authorization(string _login, string _password);
    }
    public interface ITour
    {
        public string PriceNotification { get; set; }
        public static abstract decimal Mult(decimal x, decimal y);
        public static abstract decimal CalculatePrice
            (decimal persons, decimal pricePerPerson, Func<decimal, decimal, decimal> op);        
    }
}
