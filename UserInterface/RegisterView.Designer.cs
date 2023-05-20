namespace UserInterface
{
    partial class RegisterView
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 192);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 19;
            label2.Text = "Фамілія";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 132);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 18;
            label1.Text = "Ім`я";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(171, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 29);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(171, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 29);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 259);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 21;
            label3.Text = "Електронна пошта";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(171, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 29);
            textBox3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(440, 192);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 25;
            label4.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(440, 132);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 24;
            label5.Text = "Логін";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(440, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 29);
            textBoxPassword.TabIndex = 23;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(440, 156);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 29);
            textBoxLogin.TabIndex = 22;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(456, 281);
            button1.Name = "button1";
            button1.Size = new Size(218, 31);
            button1.TabIndex = 26;
            button1.Text = "Зареєструвати користувача";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(253, 71);
            label6.Name = "label6";
            label6.Size = new Size(321, 30);
            label6.TabIndex = 28;
            label6.Text = "Запис на екскурсій, розповсюдження власних екскурсій \r\nта багато іншого";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(359, 36);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 27;
            label7.Text = "TourManager";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.BorderSize = 10;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(76, 31);
            button2.TabIndex = 29;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 10;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(456, 340);
            button3.Name = "button3";
            button3.Size = new Size(218, 31);
            button3.TabIndex = 30;
            button3.Text = "Зареєструвати гіда";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegisterView";
            Size = new Size(850, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}
