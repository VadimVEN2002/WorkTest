using _Приложение_из_примера_по_курсовой.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Приложение_из_примера_по_курсовой
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_main_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0]; // создание экземпляра главной формы без создания новой копии
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TGroup group1 = new TGroup(); //создание новой группы
            richTextBox1.Text = group1.ShowGroup(); //вывод содержимого группы в новое окно
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_main_MouseHover(object sender, EventArgs e)
        {
            label_main.Font = new Font(label_main.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_main_MouseLeave(object sender, EventArgs e)
        {
            label_main.Font = new Font(label_main.Font, FontStyle.Bold);
        }

        private void label_information_MouseHover(object sender, EventArgs e)
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_information_MouseLeave(object sender, EventArgs e)
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Bold);
        }

        private void label_information_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
