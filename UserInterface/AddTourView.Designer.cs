using Behavior;

namespace UserInterface
{
    partial class AddTourView
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 48);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 15;
            label2.Text = "Назва екскурсії";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(136, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 29);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(136, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 29);
            textBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 114);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 17;
            label1.Text = "Місто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 19;
            label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(136, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(371, 70);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(388, 160);
            textBox3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(371, 48);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 22;
            label4.Text = "Описання";
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
            button3.TabIndex = 31;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4 = new PHTextBox("0...20");
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(136, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 29);
            textBox4.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(136, 243);
            label5.Name = "label5";
            label5.Size = new Size(202, 19);
            label5.TabIndex = 32;
            label5.Text = "Максимальне число учасників";
            // 
            // textBox5
            // 
            textBox5 = new PHTextBox("0...336 (hours)");
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(138, 354);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 29);
            textBox5.TabIndex = 35;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(136, 313);
            label6.Name = "label6";
            label6.Size = new Size(202, 49);
            label6.TabIndex = 34;
            label6.Text = "Максимальний час проведення екскурсії";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(559, 317);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 29);
            textBox6.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(559, 295);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 36;
            label7.Text = "Ціна за людину";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(586, 355);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 38;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddTourView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "AddTourView";
            Size = new Size(890, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Button button1;
    }
}
