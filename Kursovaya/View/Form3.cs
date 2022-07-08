using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Приложение_из_примера_по_курсовой
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_start_MouseHover(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_start_MouseLeave(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_main_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0]; // создание экземпляра главной формы без создания новой копии
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void label_main_MouseHover(object sender, EventArgs e)
        {
            label_main.Font = new Font(label_main.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_main_MouseLeave(object sender, EventArgs e)
        {
            label_main.Font = new Font(label_main.Font, FontStyle.Bold);
        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
