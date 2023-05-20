namespace UserInterface
{
    partial class AdminView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsUsers = new BindingSource(components);
            splitter2 = new Splitter();
            tabPage2 = new TabPage();
            button6 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            firstNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bsGuides = new BindingSource(components);
            splitter3 = new Splitter();
            tabPage3 = new TabPage();
            button7 = new Button();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            iDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            maxNumberPersonsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            durationInHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            participantsCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pricePerPersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceNotificationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsTours = new BindingSource(components);
            splitter4 = new Splitter();
            tabPage4 = new TabPage();
            button4 = new Button();
            dataGridView4 = new DataGridView();
            personIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tourIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recordingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            participantsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullDescDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bsTickets = new BindingSource(components);
            splitter1 = new Splitter();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsGuides).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTours).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTickets).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(splitter2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(45, 94);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 2;
            button5.Text = "Переглянути";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(45, 65);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 0;
            button1.Text = "Видалити запис";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsUsers;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(203, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(636, 416);
            dataGridView1.TabIndex = 1;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // bsUsers
            // 
            bsUsers.DataSource = typeof(DomainModel.RegisteredPersonList);
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(200, 416);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(splitter3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Guides";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(45, 94);
            button6.Name = "button6";
            button6.Size = new Size(107, 23);
            button6.TabIndex = 3;
            button6.Text = "Переглянути";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 65);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 2;
            button2.Text = "Видалити запис";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn1, lastNameDataGridViewTextBoxColumn1, phoneNumberDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, iDDataGridViewTextBoxColumn1, loginDataGridViewTextBoxColumn1, passwordDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = bsGuides;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(203, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(636, 416);
            dataGridView2.TabIndex = 1;
            dataGridView2.DataError += dataGridView2_DataError;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            loginDataGridViewTextBoxColumn1.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn1.HeaderText = "Login";
            loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // bsGuides
            // 
            bsGuides.DataSource = typeof(DomainModel.GuideList);
            // 
            // splitter3
            // 
            splitter3.Location = new Point(3, 3);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(200, 416);
            splitter3.TabIndex = 0;
            splitter3.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(splitter4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(842, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tours";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(45, 94);
            button7.Name = "button7";
            button7.Size = new Size(107, 23);
            button7.TabIndex = 3;
            button7.Text = "Переглянути";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 65);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 2;
            button3.Text = "Видалити запис";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn2, maxNumberPersonsDataGridViewTextBoxColumn, eventDayDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, durationInHoursDataGridViewTextBoxColumn, participantsCountDataGridViewTextBoxColumn, pricePerPersonDataGridViewTextBoxColumn, priceNotificationDataGridViewTextBoxColumn, fullDescDataGridViewTextBoxColumn });
            dataGridView3.DataSource = bsTours;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(203, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(636, 416);
            dataGridView3.TabIndex = 1;
            dataGridView3.DataError += dataGridView3_DataError;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // maxNumberPersonsDataGridViewTextBoxColumn
            // 
            maxNumberPersonsDataGridViewTextBoxColumn.DataPropertyName = "MaxNumberPersons";
            maxNumberPersonsDataGridViewTextBoxColumn.HeaderText = "MaxNumberPersons";
            maxNumberPersonsDataGridViewTextBoxColumn.Name = "maxNumberPersonsDataGridViewTextBoxColumn";
            // 
            // eventDayDataGridViewTextBoxColumn
            // 
            eventDayDataGridViewTextBoxColumn.DataPropertyName = "EventDay";
            eventDayDataGridViewTextBoxColumn.HeaderText = "EventDay";
            eventDayDataGridViewTextBoxColumn.Name = "eventDayDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // durationInHoursDataGridViewTextBoxColumn
            // 
            durationInHoursDataGridViewTextBoxColumn.DataPropertyName = "DurationInHours";
            durationInHoursDataGridViewTextBoxColumn.HeaderText = "DurationInHours";
            durationInHoursDataGridViewTextBoxColumn.Name = "durationInHoursDataGridViewTextBoxColumn";
            // 
            // participantsCountDataGridViewTextBoxColumn
            // 
            participantsCountDataGridViewTextBoxColumn.DataPropertyName = "ParticipantsCount";
            participantsCountDataGridViewTextBoxColumn.HeaderText = "ParticipantsCount";
            participantsCountDataGridViewTextBoxColumn.Name = "participantsCountDataGridViewTextBoxColumn";
            // 
            // pricePerPersonDataGridViewTextBoxColumn
            // 
            pricePerPersonDataGridViewTextBoxColumn.DataPropertyName = "PricePerPerson";
            pricePerPersonDataGridViewTextBoxColumn.HeaderText = "PricePerPerson";
            pricePerPersonDataGridViewTextBoxColumn.Name = "pricePerPersonDataGridViewTextBoxColumn";
            // 
            // priceNotificationDataGridViewTextBoxColumn
            // 
            priceNotificationDataGridViewTextBoxColumn.DataPropertyName = "PriceNotification";
            priceNotificationDataGridViewTextBoxColumn.HeaderText = "PriceNotification";
            priceNotificationDataGridViewTextBoxColumn.Name = "priceNotificationDataGridViewTextBoxColumn";
            // 
            // fullDescDataGridViewTextBoxColumn
            // 
            fullDescDataGridViewTextBoxColumn.DataPropertyName = "FullDesc";
            fullDescDataGridViewTextBoxColumn.HeaderText = "FullDesc";
            fullDescDataGridViewTextBoxColumn.Name = "fullDescDataGridViewTextBoxColumn";
            fullDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTours
            // 
            bsTours.DataSource = typeof(DomainModel.TourList);
            // 
            // splitter4
            // 
            splitter4.Location = new Point(3, 3);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(200, 416);
            splitter4.TabIndex = 0;
            splitter4.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(splitter1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(842, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tickets";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(45, 65);
            button4.Name = "button4";
            button4.Size = new Size(107, 23);
            button4.TabIndex = 2;
            button4.Text = "Видалити запис";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { personIDDataGridViewTextBoxColumn, tourIDDataGridViewTextBoxColumn, recordingDateDataGridViewTextBoxColumn, participantsDataGridViewTextBoxColumn, fullDescDataGridViewTextBoxColumn1 });
            dataGridView4.DataSource = bsTickets;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(203, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(636, 416);
            dataGridView4.TabIndex = 1;
            dataGridView4.DataError += dataGridView4_DataError;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            tourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID";
            tourIDDataGridViewTextBoxColumn.HeaderText = "TourID";
            tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            // 
            // recordingDateDataGridViewTextBoxColumn
            // 
            recordingDateDataGridViewTextBoxColumn.DataPropertyName = "RecordingDate";
            recordingDateDataGridViewTextBoxColumn.HeaderText = "RecordingDate";
            recordingDateDataGridViewTextBoxColumn.Name = "recordingDateDataGridViewTextBoxColumn";
            // 
            // participantsDataGridViewTextBoxColumn
            // 
            participantsDataGridViewTextBoxColumn.DataPropertyName = "Participants";
            participantsDataGridViewTextBoxColumn.HeaderText = "Participants";
            participantsDataGridViewTextBoxColumn.Name = "participantsDataGridViewTextBoxColumn";
            // 
            // fullDescDataGridViewTextBoxColumn1
            // 
            fullDescDataGridViewTextBoxColumn1.DataPropertyName = "FullDesc";
            fullDescDataGridViewTextBoxColumn1.HeaderText = "FullDesc";
            fullDescDataGridViewTextBoxColumn1.Name = "fullDescDataGridViewTextBoxColumn1";
            fullDescDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsTickets
            // 
            bsTickets.DataSource = typeof(DomainModel.TicketList);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(200, 416);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "AdminView";
            Size = new Size(850, 450);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUsers).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsGuides).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTours).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Splitter splitter2;
        private Splitter splitter3;
        private TabPage tabPage3;
        private Splitter splitter4;
        private TabPage tabPage4;
        private Splitter splitter1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource bsUsers;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource bsGuides;
        private BindingSource bsTours;
        private BindingSource bsTickets;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn maxNumberPersonsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationInHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn participantsCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceNotificationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recordingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn participantsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullDescDataGridViewTextBoxColumn1;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
