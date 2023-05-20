using Behavior;
using DomainModel;
using System.Text.Json;
using System.Windows.Forms;
using UserInterface;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentSession.ViewInstance = views1;
        }

        private void ‚ËÈÚËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentSession.Account = new Guest();
            for (int i = views1.tabControl1.TabPages.Count-1; i > 1; i--)
            {
                views1.tabControl1.TabPages.RemoveAt(i);
            }
            CurrentSession.IsAdmin = false;
        }
        private void ÒÚÓ≥ÌÍ‡¿Í‡ÛÌÚÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrentSession.Account.GetType() != typeof(Guest))
            {
                Views views = (Views)CurrentSession.ViewInstance;
                CurrentSession.AccountTabPageIndex = views.AddAccountTab();
                TabControl tbC = (TabControl)views.Controls[0];
                tbC.SelectTab(CurrentSession.AccountTabPageIndex);
            }
        }

        //---------------------------------------------------

        private void usersTojSONItem_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(Storage.Instance.db.RegisteredPersons);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "json";
                saveFile.AddExtension = true;
                if (saveFile.ShowDialog() == DialogResult.Cancel) return;
                string path = saveFile.FileName;
                File.WriteAllText(path, json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void guidesToJSONItem_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(Storage.Instance.db.Guides);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "json";
                saveFile.AddExtension = true;
                if (saveFile.ShowDialog() == DialogResult.Cancel) return;
                string path = saveFile.FileName;
                File.WriteAllText(path, json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toursToJSONItem_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(Storage.Instance.db.Tours);
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "json";
                saveFile.AddExtension = true;
                if (saveFile.ShowDialog() == DialogResult.Cancel) return;
                string path = saveFile.FileName;
                File.WriteAllText(path, json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void jsonToUsersItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "json";
                openFile.AddExtension = true;
                if (openFile.ShowDialog() == DialogResult.Cancel) return;
                string path = openFile.FileName;
                string json = File.ReadAllText(path);
                if (JsonSerializer.Deserialize<RegisteredPersonList>(json) != null)
                    Storage.Instance.db.RegisteredPersons = JsonSerializer.Deserialize<RegisteredPersonList>(json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void jsonToGuidesItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "json";
                openFile.AddExtension = true;
                if (openFile.ShowDialog() == DialogResult.Cancel) return;
                string path = openFile.FileName;
                string json = File.ReadAllText(path);
                if (JsonSerializer.Deserialize<GuideList>(json) != null)
                    Storage.Instance.db.Guides = JsonSerializer.Deserialize<GuideList>(json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void jsonToToursItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "json";
                openFile.AddExtension = true;
                if (openFile.ShowDialog() == DialogResult.Cancel) return;
                string path = openFile.FileName;
                string json = File.ReadAllText(path);
                if (JsonSerializer.Deserialize<TourList>(json) != null)
                    Storage.Instance.db.Tours = JsonSerializer.Deserialize<TourList>(json);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

    }
}