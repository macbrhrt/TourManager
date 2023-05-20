using DomainModel;

namespace UserInterface
{
    public partial class TourView : UserControl
    {
        public Tour Tour { get; set; }
        public TourView()
        {
            InitializeComponent();
            if (CurrentSession.Account.GetType() == typeof(RegisteredPerson))
            {
                button1.Visible = true;
            }
            else 
            {
                button1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void TourView_Load(object sender, EventArgs e)
        {
            textBox1.Text = Tour.Name;
            textBox2.Text = Tour.City;
            textBox3.Text = Tour.Description;
            textBox7.Text = Tour.EventDay.ToString();
            textBox6.Text = Tour.PricePerPerson.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            int index = views.AddBookingTourTab(Tour);
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(index);
        }
    }
}
