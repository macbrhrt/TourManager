using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #1 Реализация колекций классов предметной области (базы данных)
    public partial class TourList : List<Tour> { }
    public partial class RegisteredPersonList : List<RegisteredPerson> { }
    public partial class GuideList : List<Guide> { }
    public partial class TicketList : List<TicketTour> { }

    public partial class Storage
    {
        private static Storage? instance = null;
        private Storage()
        {
            db = new DataBase();
        }
        public static Storage Instance
        {
            get
            {
                if (instance == null)
                    instance = new Storage();
                return instance;
            }
        }

        public DataBase db { get; private set; }
        public class DataBase
        {
            public DataBase()
            {
                Tours = new TourList();
                RegisteredPersons = new RegisteredPersonList();
                Guides = new GuideList();
                Tickets = new TicketList();
            }
            public TourList Tours { get; set; }
            public RegisteredPersonList RegisteredPersons { get; set; }
            public GuideList Guides { get; set; }
            public TicketList Tickets { get; set; }            
        }  
    }
}
