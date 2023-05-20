using DomainModel;

namespace DesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Storage.Instance.db.RegisteredPersons.AddRange(new RegisteredPerson[]
            {
                new RegisteredPerson("john1", "doe1", "tempmail@mail.com", "johndoe9", "pass8888"){PhoneNumber = "096544123"},
                new RegisteredPerson("bill2", "smitty2", "manchkin999@ukr.net", "lock1499", "zxcv789"){PhoneNumber = "093956357"},
                new RegisteredPerson("lee3", "goo wa3", "llghjj@gmail.com", "aldhuin", "12334566"){PhoneNumber = "07543554"},
                new RegisteredPerson("lerk4", "dee4", "berock@mail.net", "jj1616", "trackluck"){PhoneNumber = "0975544"}
            });
            Storage.Instance.db.Guides.AddRange(new Guide[]
            {
                new Guide("test", "test", "test", "test", "testtest"),
                new Guide("jhuu1", "whuu1", "test2", "jhuu1888", "pass8888"),
                new Guide("lu2", "wrack2", "test3", "luwrack", "zxcv789"),
                new Guide("olee3", "haa3", "test4", "veinfm9", "12334566"),
                new Guide("pack4", "jeen4", "test", "flacko1616", "trackluck")
            });
            Storage.Instance.db.Tours.AddRange(new Tour[]
            {
                new Tour(Convert.ToDateTime("2023-07-1"), "Прага", "Денна екскурсія по головним туристичним місцям городу", "Плюс повний обід в ресторані на борту кораблі.", 10, 9, 1000m)
            });
            Storage.Instance.db.Guides[0].AddMyTour(new Tour(Convert.ToDateTime("2023-06-28"), "Вісагінас", "Краса в загадочності тихого городка на краю Литви", "Відчуй красу Азерою!...", 15, 10, 599.99m));
            Storage.Instance.db.Guides[0].AddMyTour(new Tour(Convert.ToDateTime("2023-06-19"), "Запоріжжя", "Екскурсія по Хортиці від гіда поглибленого в таємниці історії Січі", "...", 20, 5, 400m));

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}