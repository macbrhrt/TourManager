using DomainModel;

namespace UserInterface
{
    public partial class ShowToursView : UserControl
    {
        bool pressedFilter = false;
        public ShowToursView()
        {
            InitializeComponent();
            List<Tour> list = Storage.Instance.db.Tours;
            listBoxTours.DataSource = list;
            listBoxTours.ScrollAlwaysVisible = true;
            listBoxTours.HorizontalScrollbar = true;
            listBoxTours.ValueMember = "FullDesc";
            comboBox1.DataSource = list.DistinctBy(p => p.City).ToList();
            comboBox1.ValueMember = "City";
        }
        public void ClearList()
        {
            listBoxTours.DataSource = null;
            listBoxTours.ValueMember = "";
        }
        public void RefreshList()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "";
            ClearList();
            if (Storage.Instance.db.Tours.Count > 0)
            {
                List<Tour> list = Storage.Instance.db.Tours;
                listBoxTours.DataSource = list;
                listBoxTours.ValueMember = "FullDesc";
                comboBox1.DataSource = list;
                comboBox1.ValueMember = "City";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (CurrentSession.Account.GetType() != typeof(Guide))
            {
                MessageBox.Show("Only guide can add tours.");
                return;
            }
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.CreateTourTabPageIndex = views.AddCreateTourTab();
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.CreateTourTabPageIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.TourTabPageIndex = views.AddTourTab((Tour)listBoxTours.SelectedItem);
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.TourTabPageIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Storage.Instance.db.Tours.Count > 0)
            {

                if (pressedFilter)
                {
                    pressedFilter = false;
                    RefreshList();
                }
                else
                {
                    //ClearList();
                    RefreshList();
                    List<Tour> list = Storage.Instance.db.Tours;
                    listBoxTours.DataSource = list.FindAll(it => it.City == comboBox1.SelectedValue.ToString());
                    listBoxTours.ValueMember = "FullDesc";
                    pressedFilter = true;
                }
            }
        }

        private void listBoxTours_DoubleClick(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
