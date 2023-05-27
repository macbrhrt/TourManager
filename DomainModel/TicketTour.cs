using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    //ToDo #0.5 TicketTour - класс билет на екскурсию
    public class TicketTour
    {
        public TicketTour(Guid personID, int tourID, DateTime recordingDate, short participants)
        {
            PersonID = personID;
            TourID = tourID;
            RecordingDate = recordingDate;
            Participants = participants;
            OnCreate?.Invoke("Ticket created. Details: [TourID:" + TourID + "] Дата: " + RecordingDate.ToString() + ". Кількість людей: " + Participants + ".");
        }

        public Guid PersonID { get; set; }
        public int TourID { get; set; }
        public DateTime RecordingDate { get; set; }
        public short Participants { get; set; }
        public string FullDesc { get => "[TourID:" + TourID+"] Дата: "+ RecordingDate.ToString()+". Кількість людей: "+Participants+"."; }
        
        event Message OnCreate;
        delegate void Message(string message);
    }
    public class TicketEnum : IEnumerator
    {
        public List<TicketTour> _tickets;
        int position = -1;

        public TicketEnum(List<TicketTour> list)
        {
            _tickets = list;
        }

        object IEnumerator.Current
        {
            get => Current;
        }
        public TicketTour Current
        {
            get { return _tickets[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _tickets.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
