namespace UserInterface
{
    partial class ChangePasswordView
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
            button2 = new Button();
            label4 = new Label();
            textBoxOldPass = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBoxNewPass = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 10;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(315, 355);
            button2.Name = "button2";
            button2.Size = new Size(218, 31);
            button2.TabIndex = 29;
            button2.Text = "Змінити пароль";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(300, 211);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 28;
            label4.Text = "Старий пароль";
            // 
            // textBoxOldPass
            // 
            textBoxOldPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOldPass.Location = new Point(300, 235);
            textBoxOldPass.Name = "textBoxOldPass";
            textBoxOldPass.PasswordChar = '*';
            textBoxOldPass.Size = new Size(250, 29);
            textBoxOldPass.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 53);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 31;
            label3.Text = "Електронна пошта";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(300, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 29);
            textBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(300, 272);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 33;
            label1.Text = "Новий пароль";
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPass.Location = new Point(300, 296);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PasswordChar = '*';
            textBoxNewPass.Size = new Size(250, 29);
            textBoxNewPass.TabIndex = 32;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(593, 105);
            button1.Name = "button1";
            button1.Size = new Size(218, 31);
            button1.TabIndex = 34;
            button1.Text = "Отримати код";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(300, 112);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 36;
            label2.Text = "Код";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(300, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 29);
            textBox2.TabIndex = 35;
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
            button3.TabIndex = 37;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxNewPass);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBoxOldPass);
            Name = "ChangePasswordView";
            Size = new Size(850, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label4;
        private TextBox textBoxOldPass;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxNewPass;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
    }
}
