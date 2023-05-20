using DomainModel;

namespace UserInterface
{
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegisteredPerson user = new RegisteredPerson(textBox1.Text, textBox2.Text, textBox3.Text, textBoxLogin.Text, textBoxPassword.Text);
                Storage.Instance.db.RegisteredPersons.Add(user);
                MessageBox.Show("User registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Guide user = new Guide(textBox1.Text, textBox2.Text, textBox3.Text, textBoxLogin.Text, textBoxPassword.Text);
                Storage.Instance.db.Guides.Add(user);
                MessageBox.Show("Guide registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }
    }
}
