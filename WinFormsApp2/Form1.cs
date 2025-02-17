namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int clickCount = 0; //������� ������
        private Color selectedColor = Color.Red; //  ���� ������ �������
        private PictureBox clockIcon; // ���������� ������ 

        // ������ ��� ������� �������
        private System.Windows.Forms.Timer alarmTimer;
        private int remainingSeconds;
        private System.Windows.Forms.Timer removeIconTimer; // ������ ��� �������� ������
        private System.Windows.Forms.Timer blinkTimer;
        private Color currentColor;
        private bool isBlinking = false; // ���� �������
        private Button button4; // ��������� ������ button4
        private bool isDrawing = false; // ���� ��� ������������ ��������� ���������
        private Point lastPoint; // ������� ������� ����



        public Form1()
        {
            InitializeComponent();
            ;// ���������� ������ � ComboBox
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("���������");
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("����������");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("������");
            // ��������� ������� ��� �������
            blinkTimer = new System.Windows.Forms.Timer();
            blinkTimer.Interval = 100; // �������� 500 �� ��� �������
            blinkTimer.Tick += BlinkTimer_Tick; // �������� �� ������� Tick
                                                // ������������� ������� ��� button6 (�������)
            button6.Click += button6_Click;

            // ������������� ��������� ����
            currentColor = Color.Red; // ������������� ������� �� ���������
                                      // �������� ������� ��� textBox2
            textBox2.TextChanged += textBox2_TextChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "������ �������";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label1.Text = "���� ������";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label1.Text = "���� �����";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �������� ��������� ���� �� ComboBox
            string selectedColor = comboBox1.SelectedItem.ToString();

            // ������ ���� ������ � textBox1 � ����������� �� ���������� �����
            switch (selectedColor)
            {
                case "�������":
                    textBox1.ForeColor = Color.Red;
                    break;
                case "���������":
                    textBox1.ForeColor = Color.Orange;
                    break;
                case "������":
                    textBox1.ForeColor = Color.Yellow;
                    break;
                case "�������":
                    textBox1.ForeColor = Color.Green;
                    break;
                case "�������":
                    textBox1.ForeColor = Color.LightBlue;
                    break;
                case "�����":
                    textBox1.ForeColor = Color.Blue;
                    break;
                case "����������":
                    textBox1.ForeColor = Color.Violet;
                    break;
                case "�����":
                    textBox1.ForeColor = Color.White;
                    break;
                case "������":
                    textBox1.ForeColor = Color.Black;
                    break;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                currentColor = Color.Red; // ������������� ������� ����
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--; // �������� �������
                int hoursLeft = remainingSeconds / 3600;
                int minutesLeft = (remainingSeconds % 3600) / 60;
                int secondsLeft = remainingSeconds % 60;

                // ��������� ����� �� ������
                label2.Text = $"{hoursLeft:D2}:{minutesLeft:D2}:{secondsLeft:D2} ��������";
            }
            else
            {
                // ������ ��������
                alarmTimer.Stop();
                label2.Text = "����� ������!";


                // ���������� ������ �������
                clockIcon = new PictureBox();
                Icon customIcon = new Icon("C:\\Users\\qpasa\\Desktop\\clock.ico"); // ���������� ���� � �����
                clockIcon.Image = customIcon.ToBitmap(); // ����������� Icon � Bitmap � ������������� ��� � PictureBox
                clockIcon.Size = new Size(200, 200);
                clockIcon.Location = new Point(600, 268); // ������������� ������� ������ �� �����
                this.Controls.Add(clockIcon); // ��������� ������ �� �����
                // ��������� ������ ��� �������� ������ ����� 2 �������
                removeIconTimer.Start();


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            // �������� ���������� ������ ��� ����������
            int hours = int.Parse(comboBox2.SelectedItem.ToString());
            int minutes = int.Parse(comboBox3.SelectedItem.ToString());
            int seconds = int.Parse(comboBox4.SelectedItem.ToString());

            // ��������� ����� ���������� ������
            remainingSeconds = hours * 3600 + minutes * 60 + seconds;

            // ��������� ������
            alarmTimer.Start();
            label2.Text = "������ �������, �����...";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // �������� ������� ��������� ������� � listBox1
            string selectedShape = listBox1.SelectedItem?.ToString();
            // ������ ������ � ����������� �� ���������� ��������
            if (selectedShape == "����")
            {
                // ������ ���� � ��������� ������
                Graphics g = e.Graphics;
                int diameter = 98; // ������� �����
                int x = (panel1.Width - diameter) / 2;  // ���������� ���� �� ������ �� ��� X
                int y = (panel1.Height - diameter) / 2; // ���������� ���� �� ������ �� ��� Y
                g.FillEllipse(new SolidBrush(selectedColor), x, y, diameter, diameter); // ������ ���� � ��������� ������
            }
            else if (selectedShape == "�������")
            {
                // ������ ������� � ��������� ������
                Graphics g = e.Graphics;
                int size = 98;//������ ��������
                int x = (panel1.Width - size) / 2;  // ���������� ������� �� ��� X
                int y = (panel1.Height - size) / 2; // ���������� ������� �� ��� Y
                g.FillRectangle(new SolidBrush(selectedColor), x, y, size, size); // ������ ������� � ��������� ������
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            // ������������� �����������, ���� ����������
            label3.Text = "���������� ������: 0"; // ��������� ����� ��� �����������

            // ������������� ��������� ����
            comboBox5.SelectedIndex = 0;
            // ���������� ComboBox ��� �������
            for (int i = 0; i < 24; i++)
            {
                comboBox2.Items.Add(i.ToString("D2")); // ���� (�� 00 �� 23)
            }

            for (int i = 0; i < 60; i++)
            {
                comboBox3.Items.Add(i.ToString("D2")); // ������ (�� 00 �� 59)
                comboBox4.Items.Add(i.ToString("D2")); // ������� (�� 00 �� 59)
            }

            // ������������� ��������� ��������
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            // ������������� �������
            alarmTimer = new System.Windows.Forms.Timer();
            alarmTimer.Interval = 1000; // ������ ����������� ������ �������
            alarmTimer.Tick += timer1_Tick;
            // ������������� ������� ��� �������� ������
            removeIconTimer = new System.Windows.Forms.Timer();
            removeIconTimer.Interval = 2000; // ������������� �������� � 2 �������
            removeIconTimer.Tick += removeIconTimer_Tick;
            // ������������� ������� ��� panel3
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;

        }
        private void removeIconTimer_Tick(object sender, EventArgs e)
        {
            // ������������� ������ �������� ������
            removeIconTimer.Stop();

            // ������� ������ � �����
            if (clockIcon != null)
            {
                this.Controls.Remove(clockIcon);
                clockIcon.Dispose(); // ����������� ������
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����� ������������ �������� �������, �������������� ������
            panel1.Invalidate(); // �������� ������� Paint ��� �����������
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������ ���� ������ �� combobox5
            string selectedColorName = comboBox5.SelectedItem.ToString();
            switch (selectedColorName)
            {
                case "�������":
                    selectedColor = Color.Red;
                    break;
                case "���������":
                    selectedColor = Color.Orange;
                    break;
                case "������":
                    selectedColor = Color.Yellow;
                    break;
                case "�������":
                    selectedColor = Color.Green;
                    break;
                case "�������":
                    selectedColor = Color.LightBlue;
                    break;
                case "�����":
                    selectedColor = Color.Blue;
                    break;
                case "����������":
                    selectedColor = Color.Violet;
                    break;
                case "�����":
                    selectedColor = Color.White;
                    break;
                case "������":
                    selectedColor = Color.Black;
                    break;
            }

            // �������������� ������ ��� ��������� ����� ������
            panel1.Invalidate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // MouseClick ��� ������������ ������ ����� ������� ����
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���������, ��� ���� ��� ���
            {
                clickCount++; // ����������� ������� ������
                label3.Text = $"���������� ������: {clickCount}"; // ��������� ����� �� �����

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isBlinking = true;  // �������� �������
                blinkTimer.Start(); // ��������� ������
            }
            else
            {
                isBlinking = false; // ��������� �������
                blinkTimer.Stop(); // ������������� ������
                panel2.BackColor = currentColor; // ������������� ���������� ����
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                currentColor = Color.Blue; // ������������� ����� ����
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                currentColor = Color.Green; // ������������� ������� ����
            }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (isBlinking)
            {
                if (panel2.BackColor == currentColor)
                {
                    panel2.BackColor = Color.Transparent; // ���������� ���� (�������� ������)
                }
                else
                {
                    panel2.BackColor = currentColor; // ������������� ��������� ����
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int newInterval;

            // ������� ������������� ��������� ����� � �����
            if (int.TryParse(textBox2.Text, out newInterval))
            {
                // ��������, ��� �������� ������ ����, ����� ��������� ����������� ��������
                if (newInterval > 0)
                {
                    blinkTimer.Interval = newInterval; // ��������� �������� �������
                }
            }
            else
            {
                // ���� ������� ������������ ��������, ���������� ���������
                // ����� ����� ��������� ��������� ������ ��� �������� ���������
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button4 == null) // ���������, �� ���������� �� ��� button4
            {
                // ������� ����� ������ button4
                button4 = new Button();
                button4.Size = new Size(74, 25); // ������ ������
                button4.Location = new Point(41, 354); // ������� ������
                button4.Text = "������"; // ����� �� ������

                // ��������� ���������� ��� ����� �� button4
                button4.Click += Button4_Click;

                // ��������� ������ �� �����
                this.Controls.Add(button4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button4 != null) // ���� button4 ����������
            {
                // ������� button4 � �����
                this.Controls.Remove(button4);
                button4.Dispose(); // ����������� ������
                button4 = null; // ���������� ������ �� ������

            }
        }
        // ���������� ��� ����� �� button4
        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ������ �� ������!");
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // �������� �� ����� ������ ����
            {
                isDrawing = true; // �������� ���������
                lastPoint = e.Location; // ��������� ��������� �����
            }

        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) // ���� ������
            {
                using (Graphics g = panel3.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location); // ������ ����� ����� ���������� � ������� ������
                }

                lastPoint = e.Location; // ��������� ����� ��� ��������� �����
            }

        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false; // ������������� ���������
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                panel3.Invalidate(); // ������� ������ (�������������� �)
            }
        }
    }
}
