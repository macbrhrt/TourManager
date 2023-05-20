namespace UserInterface
{
    partial class AccountView
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            listBox1 = new ListBox();
            bsData = new BindingSource(components);
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(345, 161);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 25;
            textBox2.Text = "...";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(345, 100);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 24;
            textBox1.Text = "...";
            // 
            // button2
            // 
            button2.Location = new Point(345, 229);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 23;
            button2.Text = "Змінити пароль";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(345, 200);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 22;
            button1.Text = "Розкрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(345, 142);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 21;
            label9.Text = "Пароль";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(345, 81);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 20;
            label7.Text = "Логін";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(137, 221);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 19;
            label6.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(137, 202);
            label5.Name = "label5";
            label5.Size = new Size(126, 19);
            label5.TabIndex = 18;
            label5.Text = "Електронна пошта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(137, 160);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 17;
            label4.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(137, 141);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 16;
            label3.Text = "Номер телефону";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(137, 100);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 15;
            label2.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 81);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 14;
            label1.Text = "Ім`я";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 10;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(76, 31);
            button3.TabIndex = 30;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(510, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 184);
            listBox1.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(510, 81);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 32;
            label8.Text = "Екскурсії/квитки";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 10;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(556, 351);
            button4.Name = "button4";
            button4.Size = new Size(218, 31);
            button4.TabIndex = 34;
            button4.Text = "Видалити екскурсію";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 10;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(556, 314);
            button5.Name = "button5";
            button5.Size = new Size(218, 31);
            button5.TabIndex = 33;
            button5.Text = "Переглянути детальніше";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AccountView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountView";
            Size = new Size(890, 500);
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private ListBox listBox1;
        private BindingSource bsData;
        private Label label8;
        public Button button4;
        private Button button5;
    }
}
