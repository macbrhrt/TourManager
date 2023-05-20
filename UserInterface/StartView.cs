using DomainModel;

namespace UserInterface
{
    public partial class StartView : UserControl
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.RegTabPageIndex = views.AddRegisterTab();
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.RegTabPageIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentSession.IsAdmin == true) throw new Exception("You`ve been already authorized as admin!");
                if (textBoxLogin.Text=="admin" && textBoxPassword.Text =="admin")
                {
                    Views views = (Views)CurrentSession.ViewInstance;
                    CurrentSession.AdminTabPageIndex = views.AddAdminTab();
                    TabControl tbC = (TabControl)views.Controls[0];
                    tbC.SelectTab(CurrentSession.AdminTabPageIndex);
                    MessageBox.Show("Authorization has been successfully completed!\nAdminView opened!");
                    CurrentSession.IsAdmin = true;
                    return;
                }
                if (CurrentSession.Account.GetType() != typeof(Guest)) throw new Exception("You`ve been already authorized");
                if (CurrentSession.Account.GetType() == typeof(Guest))
                { 
                    CurrentSession.Account = RegisteredPerson.Authorization(textBoxLogin.Text, textBoxPassword.Text);
                    Views views = (Views)CurrentSession.ViewInstance;
                    views.showToursView1.button3.Visible = false;
                }
                if (CurrentSession.Account.GetType() == typeof(Guest))
                {
                    CurrentSession.Account = Guide.Authorization(textBoxLogin.Text, textBoxPassword.Text);
                    Views views = (Views)CurrentSession.ViewInstance;
                    views.showToursView1.button3.Visible = true;
                }
                if (CurrentSession.Account.GetType() == typeof(Guest)) throw new Exception("Authorization failed");
                MessageBox.Show("Authorization has been successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views views = (Views)CurrentSession.ViewInstance;
            CurrentSession.ChangePassTabPageIndex = views.AddChangePassTab();
            TabControl tbC = (TabControl)views.Controls[0];
            tbC.SelectTab(CurrentSession.ChangePassTabPageIndex);
        }
    }
}
