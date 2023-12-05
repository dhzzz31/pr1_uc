using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //метод Факториала (перестановки)
        private int Factorial(int n)
        {
            int result = 1;
            // Цикл от 1 до n для вычисления факториала числа n
            for (int i = 1; i <= n; i++)
            {
                result *= i; // Накапливание произведения чисел от 1 до n
            }
            return result; // Возвращается результат вычисления факториала
        }
        //метод размещения
        // Метод размещения: вычисляет число размещений из n элементов по m
        private int Place(int n, int m)
        {
            int numerator = Factorial(n); // Числитель - факториал n
            int denominator = Factorial(n - m); // Знаменатель - факториал (n - m)
            return numerator / denominator; // Возвращается результат деления
        }
        // Метод Сочетания: вычисляет число сочетаний из n элементов по m
        private int Combination(int n, int m)
        {
            int numerator = Factorial(n); // Числитель - факториал n
            int denominator = Factorial(n - m) * Factorial(m); // Знаменатель - факториал (n - m) * факториал m
            return numerator / denominator; // Возвращается результат деления
        }
        private int n, m;
        //кнопка Сочетание
        // Обработчик нажатия кнопки "Сочетание"
        private void btnCombin_Click(object sender, EventArgs e)
        {
            // Проверка корректности введенных данных перед вычислением
            if (!check()) return;
            // Получение данных из текстовых полей
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            int result = Combination(n, m); // Вычисление числа сочетаний
                                            // Отображение результата на форме
            lblCombin.Text = result.ToString();
            ClearFields(); // Очистка полей ввода
        }
        // Обработчик нажатия кнопки "Размещение"
        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            int result = Place(n, m); // Вычисление числа размещений
            lblPlace.Text = result.ToString(); // Отображение результата на форме
            ClearFields(); // Очистка полей ввода
        }
        // Обработчик нажатия кнопки "Перестановка"
        private void btnPermut_Click(object sender, EventArgs e)
        {
            if (!checkFac()) return;
            int n = int.Parse(txtN.Text);
            int result = Factorial(n); // Вычисление факториала числа n (перестановки)
            lblPermut.Text = result.ToString(); // Отображение результата на форме
            ClearFields(); // Очистка полей ввода
        }
        // Метод для очистки текстовых полей
        private void ClearFields()
        {
            txtN.Text = "";
            txtM.Text = "";
        }
        // Обработчик изменения текста в поле ввода для n
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            txtN.MaxLength = 2; // Максимальное количество символов в поле
            if (!int.TryParse(txtN.Text, out int number)) // Проверка, является ли введенный текст числом
            {
                txtN.Text = ""; // Очистка поля, если введенный текст не является числом
            }
            else if (number > 15 || number < 1) // Проверка диапазона значений
            {
                MessageBox.Show("Введите число от 1 до 15 "); // Вывод сообщения об ошибке
                txtN.Text = ""; // Очистка поля
            }
        }
        // Обработчик изменения текста в поле ввода для m
        private void txtM_TextChanged(object sender, EventArgs e)
        {
            txtM.MaxLength = 2; // Максимальное количество символов в поле
            if (!int.TryParse(txtM.Text, out int number)) // Проверка, является ли введенный текст числом
            {
                txtM.Text = ""; // Очистка поля, если введенный текст не является числом
            }
            else if (number > 15 || number < 1) // Проверка диапазона значений
            {
                MessageBox.Show("Число должно быть от 1 до 15."); // Вывод сообщения об ошибке
                txtM.Text = ""; // Очистка поля
            }
        }
        // Метод для проверки заполненности полей n и m перед вычислением
        private bool check()
        {
            if (string.IsNullOrWhiteSpace(txtN.Text) || string.IsNullOrWhiteSpace(txtM.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка"); // Вывод сообщения об ошибке, если поля пустые
                return false;
            }
            return true;
        }

        private void lblPermut_Click(object sender, EventArgs e)
        {

        }

        // Метод для проверки заполненности поля n перед вычислением факториала
        private bool checkFac()
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка"); // Вывод сообщения об ошибке, если поле пустое
                return false;
            }
            return true;
        }

    }
}

