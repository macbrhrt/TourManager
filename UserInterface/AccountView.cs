using DomainModel;
using System;

namespace UserInterface
{
    public partial class AccountView : UserControl
    {
        private Person Person { get; set; }
        public AccountView()
        {
            InitializeComponent();
            if (CurrentSession.Account.GetType() == typeof(RegisteredPerson))
            {
                label9.Text = "Квитки";
                RegisteredPerson person = (RegisteredPerson)CurrentSession.Account;
                Person = person;
                List<TicketTour> list = person.UpcomingTourTickets;
                listBox1.DataSource = list;
                listBox1.ScrollAlwaysVisible = true;
                listBox1.HorizontalScrollbar = true;
                listBox1.ValueMember = "FullDesc";
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = true;
                label2.Text = person.LastName + " " + person.FirstName;
                label4.Text = person.PhoneNumber;
                label6.Text = person.Email;
                textBox1.Text = person.Login;
                textBox2.Text = person.Password;
            }
            else if (CurrentSession.Account.GetType() == typeof(Guide))
            {
                label9.Text = "Мої екскурсії";
                Guide guide = (Guide)CurrentSession.Account;
                Person = guide;
                List<Tour> list = guide.PlacedTours;
                listBox1.DataSource = list;
                listBox1.ScrollAlwaysVisible = true;
                listBox1.HorizontalScrollbar = true;
                listBox1.ValueMember = "FullDesc";
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                label2.Text = guide.LastName + " " + guide.FirstName;
                label4.Text = guide.PhoneNumber;
                label6.Text = guide.Email;
                textBox1.Text = guide.Login;
                textBox2.Text = guide.Password;
            }
        }
        public AccountView(RegisteredPerson regP)
        {
            InitializeComponent();
            Person = regP;
            label9.Text = "Квитки";
            List<TicketTour> list = regP.UpcomingTourTickets;
            listBox1.DataSource = list;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ValueMember = "FullDesc";
            button4.Visible = false;
            button5.Visible = false;
            label2.Text = regP.LastName + " " + regP.FirstName;
            label4.Text = regP.PhoneNumber;
            label6.Text = regP.Email;
            textBox1.Text = regP.Login;
            textBox2.Text = regP.Password;
        }
        public AccountView(Guide guide)
        {
            InitializeComponent();
            Person = guide;
            label9.Text = "Мої екскурсії";
            List<Tour> list = guide.PlacedTours;
            listBox1.DataSource = list;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ValueMember = "FullDesc";
            button4.Visible = true;
            button5.Visible = true;
            label2.Text = guide.LastName + " " + guide.FirstName;
            label4.Text = guide.PhoneNumber;
            label6.Text = guide.Email;
            textBox1.Text = guide.Login;
            textBox2.Text = guide.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.ChangePassTabPageIndex = views.AddChangePassTab();
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.ChangePassTabPageIndex);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*') textBox2.PasswordChar = new char();
            else textBox2.PasswordChar = '*';
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.TourTabPageIndex = views.AddTourTab((Tour)listBox1.SelectedItem);
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.TourTabPageIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Guide guide = (Guide)Person;
            Tour selectedTour = (Tour)listBox1.SelectedItem;
            guide.DeleteMyTour(selectedTour.ID);
            Views views = (Views)CurrentSession.ViewInstance;
            views.showToursView1.RefreshList();
            RefreshList();
            Refresh();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            RegisteredPerson regP = (RegisteredPerson)Person;
            TicketTour selectedTicket = (TicketTour)listBox1.SelectedItem;
            regP.UpcomingTourTickets.Remove(selectedTicket);
            Storage.Instance.db.Tickets.Remove(selectedTicket);
            Views views = (Views)CurrentSession.ViewInstance;
            RefreshList();
            Refresh();
        }
        public void ClearList()
        {
            listBox1.DataSource = null;
            listBox1.ValueMember = String.Empty;
        }
        public void RefreshList()
        {
            ClearList();
            if (listBox1.Items.Count > 0)
            {
                Guide guide = (Guide)CurrentSession.Account;
                List<Tour> list = guide.PlacedTours;
                listBox1.DataSource = list;
                listBox1.ValueMember = "FullDesc";
            }

        }

    }
}
