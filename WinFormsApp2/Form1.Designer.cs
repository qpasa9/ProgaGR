namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            comboBox5 = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            BlinkTimer = new System.Windows.Forms.Timer(components);
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            textBox2 = new TextBox();
            button3 = new Button();
            button5 = new Button();
            bindingSource1 = new BindingSource(components);
            panel3 = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(41, 122);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Очистить строку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(41, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 1;
            textBox1.Text = "Введите текст";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(726, 138);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 18);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Красный";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 88);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(100, 22);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Цвет текста";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(726, 162);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 18);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Синий";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(726, 191);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 18);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Зеленый";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(41, 250);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(100, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(41, 221);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 8;
            progressBar1.Click += progressBar1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(837, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 109);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox2.Location = new Point(505, 216);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(38, 22);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox3.Location = new Point(549, 216);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(39, 22);
            comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox4.Location = new Point(594, 216);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(39, 22);
            comboBox4.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(505, 244);
            button2.Name = "button2";
            button2.Size = new Size(118, 24);
            button2.TabIndex = 13;
            button2.Text = "Запустить таймер";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 270);
            label2.Name = "label2";
            label2.Size = new Size(0, 14);
            label2.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Items.AddRange(new object[] { "Круг", "Квадрат" });
            listBox1.Location = new Point(880, 127);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 46);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Голубой", "Синий", "Фиолетовый", "Белый", "Черный" });
            comboBox5.Location = new Point(880, 187);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(120, 22);
            comboBox5.TabIndex = 16;
            comboBox5.Text = "Цвет фигуры";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(892, 397);
            label3.Name = "label3";
            label3.Size = new Size(38, 14);
            label3.TabIndex = 17;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(622, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 109);
            panel2.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(726, 218);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 18);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Вкл/Выкл";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // BlinkTimer
            // 
            BlinkTimer.Tick += BlinkTimer_Tick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 420);
            splitter1.TabIndex = 21;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 420);
            splitter2.TabIndex = 22;
            splitter2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(622, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(66, 22);
            textBox2.TabIndex = 23;
            textBox2.Text = "Скорость";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(41, 301);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "Создать кнопку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(41, 327);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 25;
            button5.Text = "Удалить кнопку";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Cursor = Cursors.Cross;
            panel3.Location = new Point(297, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 197);
            panel3.TabIndex = 19;
            // 
            // button6
            // 
            button6.Location = new Point(297, 221);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 26;
            button6.Text = "Очистить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 420);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(comboBox5);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(panel1);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООП";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Label label1;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button2;
        private Label label2;
        private ListBox listBox1;
        private ComboBox comboBox5;
        private Label label3;
        private Panel panel2;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer BlinkTimer;
        private Splitter splitter1;
        private Splitter splitter2;
        private TextBox textBox2;
        private Button button3;
        private Button button5;
        private BindingSource bindingSource1;
        private Panel panel3;
        private Button button6;
    }
}
