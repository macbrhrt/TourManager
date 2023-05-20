using DomainModel;

namespace UserInterface
{
    public partial class Views : UserControl
    {
        public Views()
        {
            InitializeComponent();
        }

        public int AddAdminTab()
        {
            TabPage adminTabPage = new TabPage("adminTabPage");
            adminTabPage.Text = "Адмінка";
            adminTabPage.Controls.Add(new AdminView());
            adminTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(adminTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddRegisterTab()
        {
            TabPage regTabPage = new TabPage("regTabPage");
            regTabPage.Text = "Регістрація";
            regTabPage.Controls.Add(new RegisterView());
            regTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(regTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddChangePassTab()
        {
            TabPage changePassTabPage = new TabPage("changePassTabPage");
            changePassTabPage.Text = "Зміна паролю";
            changePassTabPage.Controls.Add(new ChangePasswordView());
            changePassTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(changePassTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddAccountTab()
        {
            TabPage accountTabPage = new TabPage("accountTabPage");
            accountTabPage.Text = "Акаунт";
            accountTabPage.Controls.Add(new AccountView());
            accountTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(accountTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddAccountTab(RegisteredPerson regp)
        {
            TabPage accountTabPage = new TabPage("accountTabPage");
            accountTabPage.Text = "Акаунт";
            accountTabPage.Controls.Add(new AccountView(regp));
            accountTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(accountTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddAccountTab(Guide guide)
        {
            TabPage accountTabPage = new TabPage("accountTabPage");
            accountTabPage.Text = "Акаунт";
            accountTabPage.Controls.Add(new AccountView(guide));
            accountTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(accountTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddCreateTourTab()
        {
            TabPage addTourTabPage = new TabPage("addTourTabPage");
            addTourTabPage.Text = "Створити екскурсію";
            addTourTabPage.Controls.Add(new AddTourView());
            addTourTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(addTourTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddTourTab(Tour tour)
        {
            TabPage tourTabPage = new TabPage("tourTabPage");
            tourTabPage.Text = "Перегляд екскурсії";
            TourView tourView = new TourView();
            tourView.Tour = tour;
            tourTabPage.Controls.Add(tourView);
            tourTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tourTabPage);
            return tabControl1.TabPages.Count - 1;
        }
        public int AddBookingTourTab(Tour tour)
        {
            TabPage bookToorTabPage = new TabPage("bookToorTabPage");
            bookToorTabPage.Text = "Забронювати екскурсію";
            BookToorView bookToorView = new BookToorView();
            bookToorView.Tour = tour;
            bookToorTabPage.Controls.Add(bookToorView);
            bookToorTabPage.Controls[0].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(bookToorTabPage);
            return tabControl1.TabPages.Count - 1;
        }
    }
}
