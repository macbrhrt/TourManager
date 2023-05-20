using DomainModel;

namespace Tests
{
    //ToDo #2 UNIT тесты
   
    [TestClass]
    public class DomainModelTests
    {
        [TestMethod]
        public void AddMyTour_Test1()
        {
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio","name", "Very long description");
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            Assert.AreEqual(t, Tour.ById(id));
        }
        [TestMethod]
        public void AddMyTour_Test2()
        {
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio", "name", "Very long description");            
            bool res = guide.AddMyTour(t);
            Assert.IsTrue(guide.PlacedTours.Contains(t) && res == true);
        }
        [TestMethod]
        public void DeleteMyTour_Test1()
        {
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio", "name", "Very long description");
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            guide.DeleteMyTour(id);
            Assert.IsNull(Tour.ById(id));
        }
        [TestMethod]
        public void DeleteMyTour_Test2_Failed()
        {
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio", "name", "Very long description");
            int id = t.ID;
            Assert.IsFalse(guide.DeleteMyTour(id));
        }
        [TestMethod]
        public void CalculatePrice_Test1()
        {
            decimal p = Tour.CalculatePrice(3, 599, Tour.Mult);
            Assert.AreEqual<decimal> (1947, p);
        }
        [TestMethod]
        public void Booking_Test1()
        {
            var db = Storage.Instance.db;
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio","name", "Very long description");
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            Tour.Book(2, id, user);
            Assert.IsNotNull(user.UpcomingTourTickets.FirstOrDefault(it => it.TourID == id && it.PersonID == user.ID));
        }
        [TestMethod]
        public void Booking_Test2()
        {
            var db = Storage.Instance.db;
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio","name", "Very long description");
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            Tour.Book(2, id, user);
            TicketTour tt = Storage.Instance.db.Tickets[0];
            //Assert.AreEqual(true, tt != null && tt.TourID == id && tt.PersonID == user.ID && tt.Participants == 2);
            Assert.IsTrue(tt.PersonID == user.UpcomingTourTickets[0].PersonID);

        }
        [TestMethod]
        public void Booking_Test3_Failed()
        {
            var db = Storage.Instance.db;
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio", "name", "Very long description");
            RegisteredPerson user = null;
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            Assert.IsFalse(Tour.Book(2, id, user));
        } 
        [TestMethod]
        public void ById_Test1_Failed()
        {
            Guide guide = new Guide("john", "doe", "sdsddss@gmail.com", "kkok1616", "12334456");
            Tour t = new Tour(Convert.ToDateTime("05/01/2024"), "Tokio", "name", "Very long description");
            int id = t.ID;
            bool res = guide.AddMyTour(t);
            guide.DeleteMyTour(id);
            Assert.IsNull(Tour.ById(id));
        }
        [TestMethod]
        public void ChangePassword_Test1()
        {
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            Storage.Instance.db.RegisteredPersons.Add(user);
            string newPass = "secret password";
            RegisteredPerson.ChangePassword(user, "ddfgs8888@gmail.com", "12334456", newPass);
            Assert.AreEqual(newPass, user.Password);
        }
        [TestMethod]
        public void ChangePassword_Test2_Failed()
        {
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            Storage.Instance.db.RegisteredPersons.Add(user);
            string newPass = "secret password";
            RegisteredPerson.ChangePassword(user, "ddfgs8888@gmail.com", "blahblahblah", newPass);
            Assert.IsFalse(newPass == user.Password);
        }
        [TestMethod]
        public void Authorization_Test1()
        {
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            user.Login = "newlogin";
            user.Password = "newpass1616";
            Storage.Instance.db.RegisteredPersons.Add(user);
            Assert.AreEqual(user, RegisteredPerson.Authorization("newlogin", "newpass1616"));
        }
        [TestMethod]
        public void Authorization_Test2_Failed()
        {
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "ppsspp1616", "12334456");
            Storage.Instance.db.RegisteredPersons.Add(user);
            Assert.IsTrue(RegisteredPerson.Authorization("unknwn", "unknwn").GetType() == typeof(Guest));
        }
        [TestMethod]
        public void Authorization_Test3_Failed()
        {
            RegisteredPerson user = new RegisteredPerson("user", "1", "ddfgs8888@gmail.com", "78954678", "78954678");
            Storage.Instance.db.RegisteredPersons.Clear();
            Storage.Instance.db.RegisteredPersons.Add(user);
            string newPass = "secret password";
            RegisteredPerson.ChangePassword(user, "ddfgs8888@gmail.com", "78954678", newPass);
            Assert.IsTrue(RegisteredPerson.Authorization("78954678", "78954678").GetType()==typeof(Guest));
        }
    }
}