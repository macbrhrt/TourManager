using DomainModel;

namespace UserInterface
{
    public partial class AddTourView : UserControl
    {
        public AddTourView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            try
            {
                Tour tour = new Tour(dateTimePicker1.Value, textBox2.Text, textBox1.Text, textBox3.Text,
                    Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToDecimal(textBox6.Text));
                Guide guide = (Guide)CurrentSession.Account;
                if (guide.AddMyTour(tour)) MessageBox.Show("Tour added succesfully!");
                else throw new Exception("Invalid property value");
                views.showToursView1.RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }
    }
}
