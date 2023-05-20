namespace UserInterface
{
    partial class TourView
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
            button1 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox7 = new TextBox();
            button2 = new Button();
            bsData = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(133, 344);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 53;
            button1.Text = "Забронювати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            textBox6.Location = new Point(133, 313);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(200, 22);
            textBox6.TabIndex = 52;
            textBox6.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(133, 291);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 51;
            label7.Text = "Ціна за людину";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(370, 180);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(388, 224);
            textBox3.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(370, 158);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 45;
            label4.Text = "Описання";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(135, 227);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 43;
            label3.Text = "Дата";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            textBox2.Location = new Point(135, 180);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(200, 22);
            textBox2.TabIndex = 42;
            textBox2.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 158);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 41;
            label1.Text = "Місто";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(135, 113);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(623, 25);
            textBox1.TabIndex = 40;
            textBox1.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 91);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 39;
            label2.Text = "Назва екскурсії";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            textBox7.Location = new Point(135, 249);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(200, 22);
            textBox7.TabIndex = 54;
            textBox7.Text = "...";
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
            button2.TabIndex = 55;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TourView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "TourView";
            Size = new Size(890, 500);
            Load += TourView_Load;
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox7;
        private Button button2;
        public BindingSource bsData;
    }
}
