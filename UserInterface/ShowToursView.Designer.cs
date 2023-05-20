namespace UserInterface
{
    partial class ShowToursView
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
            components = new System.ComponentModel.Container();
            listBoxTours = new ListBox();
            bsTours = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsTours).BeginInit();
            SuspendLayout();
            // 
            // listBoxTours
            // 
            listBoxTours.DataSource = bsTours;
            listBoxTours.FormattingEnabled = true;
            listBoxTours.ItemHeight = 15;
            listBoxTours.Location = new Point(180, 99);
            listBoxTours.Name = "listBoxTours";
            listBoxTours.Size = new Size(466, 259);
            listBoxTours.TabIndex = 0;
            listBoxTours.DoubleClick += listBoxTours_DoubleClick;
            // 
            // bsTours
            // 
            bsTours.DataSource = typeof(DomainModel.TourList);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 75);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 1;
            label1.Text = "Доступні екскурсії:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(195, 364);
            button1.Name = "button1";
            button1.Size = new Size(218, 31);
            button1.TabIndex = 30;
            button1.Text = "Переглянути детальніше";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 10;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(419, 364);
            button3.Name = "button3";
            button3.Size = new Size(218, 31);
            button3.TabIndex = 32;
            button3.Text = "Створити екскурсію";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(668, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(668, 113);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 34;
            label2.Text = "Фільтрація";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(668, 145);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 35;
            label3.Text = "За містом:";
            // 
            // button2
            // 
            button2.Location = new Point(687, 203);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "ок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ShowToursView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBoxTours);
            Name = "ShowToursView";
            Size = new Size(850, 450);
            ((System.ComponentModel.ISupportInitialize)bsTours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public BindingSource bsTours;
        private Label label1;
        private Button button1;
        public Button button3;
        public ListBox listBoxTours;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}
