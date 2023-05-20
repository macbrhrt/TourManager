using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #0.3.3 Guest - наследник абстрактного класса Person

    public class Guest : Person
    {
        public Guest()
        {
            Login = "guest1616";
            Password = "qwerty1616";
        }
        public static string Name { get; } = "User";

    }
}
