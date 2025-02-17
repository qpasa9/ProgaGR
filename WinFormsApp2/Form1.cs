namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int clickCount = 0; //счетчик кликов
        private Color selectedColor = Color.Red; //  цвет фигуры красный
        private PictureBox clockIcon; // переменная иконки 

        // Таймер для отсчета времени
        private System.Windows.Forms.Timer alarmTimer;
        private int remainingSeconds;
        private System.Windows.Forms.Timer removeIconTimer; // Таймер для удаления иконки
        private System.Windows.Forms.Timer blinkTimer;
        private Color currentColor;
        private bool isBlinking = false; // Флаг мигания
        private Button button4; // Объявляем кнопку button4
        private bool isDrawing = false; // Флаг для отслеживания состояния рисования
        private Point lastPoint; // Текущая позиция мыши



        public Form1()
        {
            InitializeComponent();
            ;// Добавление цветов в ComboBox
            comboBox1.Items.Add("Красный");
            comboBox1.Items.Add("Оранжевый");
            comboBox1.Items.Add("Желтый");
            comboBox1.Items.Add("Зеленый");
            comboBox1.Items.Add("Голубой");
            comboBox1.Items.Add("Синий");
            comboBox1.Items.Add("Фиолетовый");
            comboBox1.Items.Add("Белый");
            comboBox1.Items.Add("Черный");
            // Настройка таймера для мигания
            blinkTimer = new System.Windows.Forms.Timer();
            blinkTimer.Interval = 100; // Интервал 500 мс для мигания
            blinkTimer.Tick += BlinkTimer_Tick; // Подписка на событие Tick
                                                // Устанавливаем событие для button6 (очистка)
            button6.Click += button6_Click;

            // Устанавливаем начальный цвет
            currentColor = Color.Red; // Устанавливаем красный по умолчанию
                                      // Привязка события для textBox2
            textBox2.TextChanged += textBox2_TextChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Строка очищена";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label1.Text = "Ввод текста";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label1.Text = "Есть текст";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный цвет из ComboBox
            string selectedColor = comboBox1.SelectedItem.ToString();

            // Меняем цвет текста в textBox1 в зависимости от выбранного цвета
            switch (selectedColor)
            {
                case "Красный":
                    textBox1.ForeColor = Color.Red;
                    break;
                case "Оранжевый":
                    textBox1.ForeColor = Color.Orange;
                    break;
                case "Желтый":
                    textBox1.ForeColor = Color.Yellow;
                    break;
                case "Зеленый":
                    textBox1.ForeColor = Color.Green;
                    break;
                case "Голубой":
                    textBox1.ForeColor = Color.LightBlue;
                    break;
                case "Синий":
                    textBox1.ForeColor = Color.Blue;
                    break;
                case "Фиолетовый":
                    textBox1.ForeColor = Color.Violet;
                    break;
                case "Белый":
                    textBox1.ForeColor = Color.White;
                    break;
                case "Черный":
                    textBox1.ForeColor = Color.Black;
                    break;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                currentColor = Color.Red; // Устанавливаем красный цвет
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
                remainingSeconds--; // Отнимаем секунду
                int hoursLeft = remainingSeconds / 3600;
                int minutesLeft = (remainingSeconds % 3600) / 60;
                int secondsLeft = remainingSeconds % 60;

                // Обновляем текст на экране
                label2.Text = $"{hoursLeft:D2}:{minutesLeft:D2}:{secondsLeft:D2} осталось";
            }
            else
            {
                // Таймер завершен
                alarmTimer.Stop();
                label2.Text = "Время пришло!";


                // Показываем иконку времени
                clockIcon = new PictureBox();
                Icon customIcon = new Icon("C:\\Users\\qpasa\\Desktop\\clock.ico"); // Указывайте путь к файлу
                clockIcon.Image = customIcon.ToBitmap(); // Преобразуем Icon в Bitmap и устанавливаем его в PictureBox
                clockIcon.Size = new Size(200, 200);
                clockIcon.Location = new Point(600, 268); // Устанавливаем позицию иконки на форме
                this.Controls.Add(clockIcon); // Добавляем иконку на форму
                // Запускаем таймер для удаления иконки через 2 секунды
                removeIconTimer.Start();


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            // Получаем количество секунд для будильника
            int hours = int.Parse(comboBox2.SelectedItem.ToString());
            int minutes = int.Parse(comboBox3.SelectedItem.ToString());
            int seconds = int.Parse(comboBox4.SelectedItem.ToString());

            // Вычисляем общее количество секунд
            remainingSeconds = hours * 3600 + minutes * 60 + seconds;

            // Запускаем таймер
            alarmTimer.Start();
            label2.Text = "Таймер включен, ждите...";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Получаем текущий выбранный элемент в listBox1
            string selectedShape = listBox1.SelectedItem?.ToString();
            // Рисуем фигуру в зависимости от выбранного элемента
            if (selectedShape == "Круг")
            {
                // Рисуем круг с выбранным цветом
                Graphics g = e.Graphics;
                int diameter = 98; // Диаметр круга
                int x = (panel1.Width - diameter) / 2;  // Центрируем круг по панели по оси X
                int y = (panel1.Height - diameter) / 2; // Центрируем круг по панели по оси Y
                g.FillEllipse(new SolidBrush(selectedColor), x, y, diameter, diameter); // Рисуем круг с выбранным цветом
            }
            else if (selectedShape == "Квадрат")
            {
                // Рисуем квадрат с выбранным цветом
                Graphics g = e.Graphics;
                int size = 98;//Размер квадрата
                int x = (panel1.Width - size) / 2;  // Центрируем квадрат по оси X
                int y = (panel1.Height - size) / 2; // Центрируем квадрат по оси Y
                g.FillRectangle(new SolidBrush(selectedColor), x, y, size, size); // Рисуем квадрат с выбранным цветом
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            // Инициализация компонентов, если необходимо
            label3.Text = "Количество кликов: 0"; // Начальный текст для отображения

            // Устанавливаем начальный цвет
            comboBox5.SelectedIndex = 0;
            // Заполнение ComboBox для времени
            for (int i = 0; i < 24; i++)
            {
                comboBox2.Items.Add(i.ToString("D2")); // Часы (от 00 до 23)
            }

            for (int i = 0; i < 60; i++)
            {
                comboBox3.Items.Add(i.ToString("D2")); // Минуты (от 00 до 59)
                comboBox4.Items.Add(i.ToString("D2")); // Секунды (от 00 до 59)
            }

            // Устанавливаем начальные значения
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            // Инициализация таймера
            alarmTimer = new System.Windows.Forms.Timer();
            alarmTimer.Interval = 1000; // Таймер срабатывает каждую секунду
            alarmTimer.Tick += timer1_Tick;
            // Инициализация таймера для удаления иконки
            removeIconTimer = new System.Windows.Forms.Timer();
            removeIconTimer.Interval = 2000; // Устанавливаем интервал в 2 секунды
            removeIconTimer.Tick += removeIconTimer_Tick;
            // Устанавливаем событие для panel3
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;

        }
        private void removeIconTimer_Tick(object sender, EventArgs e)
        {
            // Останавливаем таймер удаления иконки
            removeIconTimer.Stop();

            // Удаляем иконку с формы
            if (clockIcon != null)
            {
                this.Controls.Remove(clockIcon);
                clockIcon.Dispose(); // Освобождаем память
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Когда пользователь выбирает элемент, перерисовываем панель
            panel1.Invalidate(); // Вызываем событие Paint для перерисовки
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Меняем цвет фигуры из combobox5
            string selectedColorName = comboBox5.SelectedItem.ToString();
            switch (selectedColorName)
            {
                case "Красный":
                    selectedColor = Color.Red;
                    break;
                case "Оранжевый":
                    selectedColor = Color.Orange;
                    break;
                case "Желтый":
                    selectedColor = Color.Yellow;
                    break;
                case "Зеленый":
                    selectedColor = Color.Green;
                    break;
                case "Голубой":
                    selectedColor = Color.LightBlue;
                    break;
                case "Синий":
                    selectedColor = Color.Blue;
                    break;
                case "Фиолетовый":
                    selectedColor = Color.Violet;
                    break;
                case "Белый":
                    selectedColor = Color.White;
                    break;
                case "Черный":
                    selectedColor = Color.Black;
                    break;
            }

            // Перерисовываем панель для изменения цвета фигуры
            panel1.Invalidate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // MouseClick для отслеживания кликов левой кнопкой мыши
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверяем, что клик был ЛКМ
            {
                clickCount++; // Увеличиваем счетчик кликов
                label3.Text = $"Количество кликов: {clickCount}"; // Обновляем текст на метке

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isBlinking = true;  // Включаем мигание
                blinkTimer.Start(); // Запускаем таймер
            }
            else
            {
                isBlinking = false; // Выключаем мигание
                blinkTimer.Stop(); // Останавливаем таймер
                panel2.BackColor = currentColor; // Устанавливаем постоянный цвет
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                currentColor = Color.Blue; // Устанавливаем синий цвет
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                currentColor = Color.Green; // Устанавливаем зеленый цвет
            }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (isBlinking)
            {
                if (panel2.BackColor == currentColor)
                {
                    panel2.BackColor = Color.Transparent; // Прозрачный цвет (мигающий эффект)
                }
                else
                {
                    panel2.BackColor = currentColor; // Устанавливаем выбранный цвет
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int newInterval;

            // Попытка преобразовать введенный текст в число
            if (int.TryParse(textBox2.Text, out newInterval))
            {
                // Убедимся, что интервал больше нуля, иначе установим минимальное значение
                if (newInterval > 0)
                {
                    blinkTimer.Interval = newInterval; // Обновляем интервал таймера
                }
            }
            else
            {
                // Если введено некорректное значение, игнорируем изменения
                // Можно также поставить обработку ошибки или показать сообщение
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button4 == null) // Проверяем, не существует ли уже button4
            {
                // Создаем новую кнопку button4
                button4 = new Button();
                button4.Size = new Size(74, 25); // Размер кнопки
                button4.Location = new Point(41, 354); // Позиция кнопки
                button4.Text = "Кнопка"; // Текст на кнопке

                // Добавляем обработчик для клика на button4
                button4.Click += Button4_Click;

                // Добавляем кнопку на форму
                this.Controls.Add(button4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button4 != null) // Если button4 существует
            {
                // Удаляем button4 с формы
                this.Controls.Remove(button4);
                button4.Dispose(); // Освобождаем память
                button4 = null; // Сбрасываем ссылку на кнопку

            }
        }
        // Обработчик для клика на button4
        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на Кнопку!");
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверка на левую кнопку мыши
            {
                isDrawing = true; // Включаем рисование
                lastPoint = e.Location; // Сохраняем начальную точку
            }

        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) // Если рисуем
            {
                using (Graphics g = panel3.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location); // Рисуем линию между предыдущей и текущей точкой
                }

                lastPoint = e.Location; // Обновляем точку для следующей линии
            }

        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false; // Останавливаем рисование
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                panel3.Invalidate(); // Очищаем панель (перерисовываем её)
            }
        }
    }
}
