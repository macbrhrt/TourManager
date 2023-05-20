using Behavior;

namespace UserInterface
{
    partial class StartView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartView));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(85, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 225);
            panel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(102, 348);
            label4.Name = "label4";
            label4.Size = new Size(321, 30);
            label4.TabIndex = 18;
            label4.Text = "Запис на екскурсій, розповсюдження власних екскурсій \r\nта багато іншого";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(196, 48);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 17;
            label3.Text = "TourManager";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(611, 245);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(68, 15);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Регістрація";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(519, 131);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 15;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, 71);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 14;
            label1.Text = "Логін";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(598, 291);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Забули пароль?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(566, 211);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 12;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(519, 155);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 29);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(519, 95);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 29);
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "StartView";
            Size = new Size(850, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
    }
}
