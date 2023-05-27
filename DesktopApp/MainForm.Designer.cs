namespace DesktopApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            views1 = new UserInterface.Views();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиДаніToolStripMenuItem = new ToolStripMenuItem();
            UsersTojSONItem = new ToolStripMenuItem();
            guidesToJSONItem = new ToolStripMenuItem();
            toursToJSONItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            jsonToUsersItem = new ToolStripMenuItem();
            jsonToGuidesItem = new ToolStripMenuItem();
            jsonToToursItem = new ToolStripMenuItem();
            акаунтToolStripMenuItem = new ToolStripMenuItem();
            вийтиToolStripMenuItem = new ToolStripMenuItem();
            сторінкаАкаунтуToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // views1
            // 
            views1.Dock = DockStyle.Fill;
            views1.Location = new Point(0, 0);
            views1.Name = "views1";
            views1.Padding = new Padding(0, 25, 0, 0);
            views1.Size = new Size(874, 491);
            views1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, акаунтToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиДаніToolStripMenuItem, відкритиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Visible = false;
            // 
            // зберегтиДаніToolStripMenuItem
            // 
            зберегтиДаніToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UsersTojSONItem, guidesToJSONItem, toursToJSONItem });
            зберегтиДаніToolStripMenuItem.Name = "зберегтиДаніToolStripMenuItem";
            зберегтиДаніToolStripMenuItem.Size = new Size(180, 22);
            зберегтиДаніToolStripMenuItem.Text = "Зберегти дані";
            // 
            // UsersTojSONItem
            // 
            UsersTojSONItem.Name = "UsersTojSONItem";
            UsersTojSONItem.Size = new Size(155, 22);
            UsersTojSONItem.Text = "Users to JSON";
            UsersTojSONItem.Click += usersTojSONItem_Click;
            // 
            // guidesToJSONItem
            // 
            guidesToJSONItem.Name = "guidesToJSONItem";
            guidesToJSONItem.Size = new Size(155, 22);
            guidesToJSONItem.Text = "Guides to JSON";
            guidesToJSONItem.Click += guidesToJSONItem_Click;
            // 
            // toursToJSONItem
            // 
            toursToJSONItem.Name = "toursToJSONItem";
            toursToJSONItem.Size = new Size(155, 22);
            toursToJSONItem.Text = "Tours to JSON";
            toursToJSONItem.Click += toursToJSONItem_Click;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonToUsersItem, jsonToGuidesItem, jsonToToursItem });
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(180, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // jsonToUsersItem
            // 
            jsonToUsersItem.Name = "jsonToUsersItem";
            jsonToUsersItem.Size = new Size(155, 22);
            jsonToUsersItem.Text = "JSON to Users";
            jsonToUsersItem.Click += jsonToUsersItem_Click;
            // 
            // jsonToGuidesItem
            // 
            jsonToGuidesItem.Name = "jsonToGuidesItem";
            jsonToGuidesItem.Size = new Size(155, 22);
            jsonToGuidesItem.Text = "JSON to Guides";
            jsonToGuidesItem.Click += jsonToGuidesItem_Click;
            // 
            // jsonToToursItem
            // 
            jsonToToursItem.Name = "jsonToToursItem";
            jsonToToursItem.Size = new Size(155, 22);
            jsonToToursItem.Text = "JSON to Tours";
            jsonToToursItem.Click += jsonToToursItem_Click;
            // 
            // акаунтToolStripMenuItem
            // 
            акаунтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вийтиToolStripMenuItem, сторінкаАкаунтуToolStripMenuItem });
            акаунтToolStripMenuItem.Name = "акаунтToolStripMenuItem";
            акаунтToolStripMenuItem.Size = new Size(57, 20);
            акаунтToolStripMenuItem.Text = "Акаунт";
            // 
            // вийтиToolStripMenuItem
            // 
            вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            вийтиToolStripMenuItem.Size = new Size(168, 22);
            вийтиToolStripMenuItem.Text = "Вийти";
            вийтиToolStripMenuItem.Click += вийтиToolStripMenuItem_Click;
            // 
            // сторінкаАкаунтуToolStripMenuItem
            // 
            сторінкаАкаунтуToolStripMenuItem.Name = "сторінкаАкаунтуToolStripMenuItem";
            сторінкаАкаунтуToolStripMenuItem.Size = new Size(168, 22);
            сторінкаАкаунтуToolStripMenuItem.Text = "Сторінка акаунту";
            сторінкаАкаунтуToolStripMenuItem.Click += сторінкаАкаунтуToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(874, 491);
            Controls.Add(menuStrip1);
            Controls.Add(views1);
            Name = "MainForm";
            Text = "TourManager";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserInterface.Views views1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem акаунтToolStripMenuItem;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиДаніToolStripMenuItem;
        private ToolStripMenuItem UsersTojSONItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem jsonToUsersItem;
        private ToolStripMenuItem guidesToJSONItem;
        private ToolStripMenuItem toursToJSONItem;
        private ToolStripMenuItem jsonToGuidesItem;
        private ToolStripMenuItem jsonToToursItem;
        private ToolStripMenuItem сторінкаАкаунтуToolStripMenuItem;
    }
}