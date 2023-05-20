using DomainModel;

namespace UserInterface
{
    public partial class ChangePasswordView : UserControl
    {
        private int? code;
        public ChangePasswordView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            code = rand.Next(1000, 9999);
            MessageBox.Show(code.ToString(), "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Person? person = Storage.Instance.db.RegisteredPersons.FirstOrDefault(it => it.Email == textBox1.Text);
                if (person is null) person = Storage.Instance.db.Guides.FirstOrDefault(it => it.Email == textBox1.Text);
                else if (person is null)
                {
                    MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (code == Convert.ToInt32(textBox2.Text))
                {
                    if (Person.ChangePassword(person, textBox1.Text, textBoxOldPass.Text, textBoxNewPass.Text)) MessageBox.Show("Success");
                    else throw new Exception("Failed");
                }
                else MessageBox.Show("Invalid code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Views views = (Views)CurrentSession.ViewInstance;
            views.tabControl1.TabPages.RemoveAt(views.tabControl1.SelectedIndex);
        }
    }
}
