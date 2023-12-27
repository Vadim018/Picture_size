using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.2\\img1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // змінюємо режим зображення
                pictureBox1.Size = new Size(150, 100); // зміна розмірів pictureBox
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.2\\img1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // змінюємо режим зображення
                pictureBox1.Size = new Size(300, 200); // зміна розмірів pictureBox
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.2\\img1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // змінюємо режим зображення
                pictureBox1.Size = new Size(600, 400); // зміна розмірів pictureBox
            }
            else
            {
                // якщо інший елемент вибраний, очистити PictureBox
                pictureBox1.Image = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Маленьке");
            comboBox1.Items.Add("Середнє");
            comboBox1.Items.Add("Велике");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width, height; // оголошення змінних для збереження ширини і висоти

            if (int.TryParse(textBox1.Text, out width) && int.TryParse(textBox2.Text, out height)) // перетворення введених значень ширини та висоти в цілі числа
            {
                Image img = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.2\\img1.jpg"); // завантаження фото з файлу

                pictureBox1.Size = new Size(width, height); // встановлення розмірів pictureBox1

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // встановлення режиму масштабування зображення

                double aspectRatio = (double)img.Width / img.Height; // визначення співвідношення сторін зображення

                if (width > height) // перевірка, яка зі сторін більша, і зміна розмірів pictureBox1 відповідно
                {
                    pictureBox1.Size = new Size(width, (int)(width / aspectRatio));
                } 
                else if (height > width)
                {
                    pictureBox1.Size = new Size((int)(height * aspectRatio), height);
                }
                pictureBox1.Image = img; // встановлення зображення для pictureBox1
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для ширини і висоти."); 
                // виведення повідомлення про помилку, якщо введені значення некоректні або взагалі ми їх не ввели
            }
        }
    }
}