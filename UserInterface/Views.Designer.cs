namespace UserInterface
{
    partial class Views
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            startView1 = new StartView();
            tabPage2 = new TabPage();
            showToursView1 = new ShowToursView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 500);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(startView1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 469);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Головна";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // startView1
            // 
            startView1.Dock = DockStyle.Fill;
            startView1.Location = new Point(3, 3);
            startView1.Name = "startView1";
            startView1.Size = new Size(876, 463);
            startView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(showToursView1);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 469);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Екскурсії";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // showToursView1
            // 
            showToursView1.Dock = DockStyle.Fill;
            showToursView1.Location = new Point(3, 3);
            showToursView1.Name = "showToursView1";
            showToursView1.Size = new Size(876, 463);
            showToursView1.TabIndex = 0;
            // 
            // Views
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "Views";
            Size = new Size(890, 500);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        public TabControl tabControl1;
        public StartView startView1;
        private TabPage tabPage2;
        public ShowToursView showToursView1;
    }
}
