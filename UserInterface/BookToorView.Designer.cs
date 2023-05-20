namespace UserInterface
{
    partial class BookToorView
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
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(119, 95);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(623, 25);
            textBox1.TabIndex = 42;
            textBox1.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 41;
            label1.Text = "Назва екскурсії";
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
            button3.TabIndex = 43;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            textBox3.Location = new Point(119, 151);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(200, 22);
            textBox3.TabIndex = 58;
            textBox3.Text = "...";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox4.Location = new Point(379, 273);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(200, 22);
            textBox4.TabIndex = 57;
            textBox4.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(379, 251);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 56;
            label4.Text = "Ціна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 55;
            label2.Text = "Дата";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(119, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 29);
            textBox2.TabIndex = 60;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 251);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 59;
            label3.Text = "Кількість людей";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(119, 324);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 61;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookToorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "BookToorView";
            Size = new Size(890, 500);
            Load += BookToorView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}
