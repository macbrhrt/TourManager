using DomainModel;

namespace UserInterface
{
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
            bsUsers.DataSource = Storage.Instance.db.RegisteredPersons;
            dataGridView1.DataSource = bsUsers.DataSource;
            bsGuides.DataSource = Storage.Instance.db.Guides;
            dataGridView2.DataSource = bsGuides.DataSource;
            bsTours.DataSource = Storage.Instance.db.Tours;
            dataGridView3.DataSource = bsTours.DataSource;
            bsTickets.DataSource = Storage.Instance.db.Tickets;
            dataGridView4.DataSource = bsTickets.DataSource;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView4_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    bsUsers.RemoveAt(item.Index);
                }
                dataGridView1.DataSource = null;
                bsUsers.DataSource = Storage.Instance.db.RegisteredPersons;
                dataGridView1.DataSource = bsUsers.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    bsGuides.RemoveAt(item.Index);
                }
                dataGridView2.DataSource = null;
                bsGuides.DataSource = Storage.Instance.db.Guides;
                dataGridView2.DataSource = bsGuides.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
                {
                    bsUsers.RemoveAt(item.Index);
                }
                dataGridView4.DataSource = null;
                bsTickets.DataSource = Storage.Instance.db.Tickets;
                dataGridView4.DataSource = bsTickets.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    bsTours.RemoveAt(item.Index);
                }
                dataGridView3.DataSource = null;
                bsTours.DataSource = Storage.Instance.db.Tours;
                dataGridView3.DataSource = bsTours.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                RegisteredPerson? regP = null;
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    regP = Storage.Instance.db.RegisteredPersons.Find(it => it.ID == (Guid)item.Cells[4].Value);
                    if (regP is not null) break;
                }
                if (regP is not null)
                {
                    Views views = (Views)CurrentSession.ViewInstance;
                    CurrentSession.AccountTabPageIndex = views.AddAccountTab(regP);
                    TabControl tbC = (TabControl)views.Controls[0];
                    tbC.SelectTab(CurrentSession.AccountTabPageIndex);
                }
                else throw new Exception("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Guide? guide = null;
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    guide = Storage.Instance.db.Guides.Find(it => it.ID == (Guid)item.Cells[4].Value);
                    if (guide is not null) break;
                }
                if (guide is not null)
                {
                    Views views = (Views)CurrentSession.ViewInstance;
                    CurrentSession.AccountTabPageIndex = views.AddAccountTab(guide);
                    TabControl tbC = (TabControl)views.Controls[0];
                    tbC.SelectTab(CurrentSession.AccountTabPageIndex);
                }
                else throw new Exception("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Tour? tour = null;
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    tour = Storage.Instance.db.Tours.Find(it => it.ID == (int)item.Cells[0].Value);
                    if (tour is not null) break;
                }
                if (tour is not null)
                {
                    Views views = (Views)CurrentSession.ViewInstance;
                    CurrentSession.TourTabPageIndex = views.AddTourTab(tour);
                    TabControl tbC = (TabControl)views.Controls[0];
                    tbC.SelectTab(CurrentSession.TourTabPageIndex);
                }
                else throw new Exception("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
