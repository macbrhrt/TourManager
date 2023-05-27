using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text.Json.Serialization;

namespace DomainModel
{
    //ToDo #0.4 класс Tour

    public class Tour : ITour
    {
        public Tour(DateTime eventDay, string city, string name, string description)
        {
            EventDay = eventDay;
            City = city;
            Name = name;
            Description = description;
            ID = counter++;
        }

        public Tour(DateTime eventDay, string city, string name, string description, short maxNumberPersons,
            short durationInHours, decimal pricePerPerson)
        {
            MaxNumberPersons = maxNumberPersons;
            EventDay = eventDay;
            City = city;
            Name = name;
            Description = description;
            DurationInHours = durationInHours;
            PricePerPerson = pricePerPerson;
            ID = counter++;
        }
        [JsonConstructor]
        public Tour(int ID, short maxNumberPersons, DateTime eventDay, string city, string name, string description, 
            short durationInHours, short participantsCount, decimal pricePerPerson, string priceNotification)
        {
            this.ID = ID;
            Name = name;
            MaxNumberPersons = maxNumberPersons;
            EventDay = eventDay;
            City = city;
            Description = description;
            DurationInHours = durationInHours;
            ParticipantsCount = participantsCount;
            PricePerPerson = pricePerPerson;
            PriceNotification = priceNotification;
        }

        public static int MaxDuration { get; set; } = 336;
        private static int counter = 1000;

        public List<Guid> Clients;
        private short maxNumberPersons = 20;
        private DateTime eventDay = DateTime.MaxValue;
        private string city = string.Empty;
        private string name = string.Empty;
        private string description = string.Empty;
        private short durationInHours = 0;
        private short participantsCount = 0;
        private decimal pricePerPerson = 0.0m;
        private string priceNotification = string.Empty;

        [JsonPropertyName("ID")]
        public int ID { get; private set; }
        [JsonPropertyName("MaxNumberPersons")]
        public short MaxNumberPersons
        {
            get => maxNumberPersons;
            set
            {
                if (value > 0 && value <= 20) maxNumberPersons = value;
                else throw new Exception("Недопустиме значення поля \"Макс. кількість учасників\"");
            }
        }
        [JsonPropertyName("EventDay")]
        public DateTime EventDay { 
            get => eventDay;
            set
            {
                if (value > DateTime.Now) eventDay = value;
                else throw new Exception("Недопустиме значення поля \"Дата\"");
            }
        }
        [JsonPropertyName("City")]
        public string City { 
            get => city;
            set
            {
                if (value.Length > 0 && value.Length <= 50) city = value;
                else throw new Exception("Недопустиме значення поля \"Місто\"");
            }
        }
        [JsonPropertyName("Name")]
        public string Name
        {
            get => name; set
            {
                if (value.Length > 0 && value.Length <= 100) name = value;
                else throw new Exception("Недопустиме значення поля \"Назва\"");
            }
        }
        [JsonPropertyName("Description")]
        public string Description { 
            get => description;
            set
            {
                if (value.Length > 0 && value.Length <= 3000) description = value;
                else throw new Exception("Недопустиме значення поля \"Описання\"");
            }
        }
        [JsonPropertyName("DurationInHours")]
        public short DurationInHours { 
            get => durationInHours;
            set
            {
                if (value > 1 && value <= MaxDuration) durationInHours = value;
                else throw new Exception("Недопустиме значення поля \"Макс. час проведення екскурсії\"");
            }
        }
        [JsonPropertyName("ParticipantsCount")]
        public short ParticipantsCount { 
            get => participantsCount;
            set
            {
                if (value >= 0 && value <= MaxNumberPersons) participantsCount = value;
                else throw new Exception("Превишено ліміт максимального значення поля \"Кількість учасників\"");
            }
        }
        [JsonPropertyName("PricePerPerson")]
        public decimal PricePerPerson { 
            get => pricePerPerson;
            set
            {
                if (value >= 0.0m && value <= 99999.99m) pricePerPerson = value;
                else throw new Exception("Недопустиме значення поля \"Ціна за людину\"");
            }
        }
        [JsonPropertyName("PriceNotification")]
        public string PriceNotification
        {
            get { return $"До cплати: {priceNotification}"; }
            set { priceNotification = value; }
        }
        public string FullDesc { get { return Name+". || Місто "+ City +". || " +  Description; } }


        public static bool Book(short participantsNumber, int tourID, RegisteredPerson client)
        {
            try
            {
                Tour t = ById(tourID);
                if (t.ParticipantsCount + participantsNumber <= t.MaxNumberPersons)
                {
                    TicketTour ticketTour = new TicketTour(client.ID, tourID, DateTime.Now, participantsNumber);
                    Storage.Instance.db.Tickets.Add(ticketTour);
                    t.ParticipantsCount += participantsNumber;
                    client.UpcomingTourTickets.Add(ticketTour);
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Tour? ById(int id)
        {
            return Storage.Instance.db.Tours.FirstOrDefault(it => it.ID == id);
        }

        public static decimal Mult(decimal x, decimal y) => (decimal)(x * y + (x * 50));
        public static decimal CalculatePrice(decimal persons, decimal pricePerPerson, Func<decimal, decimal, decimal> op)
        {
            return op(persons, pricePerPerson);
        }
    }
    
}
