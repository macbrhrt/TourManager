using DomainModel;

namespace UserInterface
{
    public partial class BookToorView : UserControl
    {
        public Tour Tour { get; set; }
        public BookToorView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == String.Empty) return;
            Tour.PriceNotification = Tour.CalculatePrice(Convert.ToDecimal(textBox2.Text), Tour.PricePerPerson, Tour.Mult).ToString();
            textBox4.Text = Tour.PriceNotification;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox2.Text) + Tour.ParticipantsCount > Tour.MaxNumberPersons)
            {
                int temp = Tour.MaxNumberPersons - Tour.ParticipantsCount;
                MessageBox.Show("Достигнуто ліміту для кількості учасників. Залишилось місць: " + temp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegisteredPerson regP = (RegisteredPerson)CurrentSession.Account;
            DialogResult result = MessageBox.Show("Чи достатньо коштів на рахунку?", "TEST", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Недостатньо коштів. Операцію бронювання екскурсії зупинено", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else Tour.Book(Convert.ToInt16(textBox2.Text), Tour.ID, regP);
        }

        private void BookToorView_Load(object sender, EventArgs e)
        {
            textBox1.Text = Tour.Name;
            textBox3.Text = Tour.EventDay.ToString();
        }
    }
}
