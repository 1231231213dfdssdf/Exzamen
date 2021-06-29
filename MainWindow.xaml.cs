using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOtm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выход");
            this.Close(); //Отмена
        }


        private bool CheckEmail(string email)
        {
            if (email.IndexOf("@") > 0 && email.IndexOf(".") > 0)
            {
                if (email.Split('@')[1].Split('.').Length == 2)
                {
                    return true;
                }
            }
            return false;
        }



        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text.Length != 0) //Проверка эмейла
            {
                if (CheckEmail(TextBoxEmail.Text) == true) //Проверка эмейла
                {
                    if (TextBoxParol.Text.Length != 0) //Проверка пароля на наличие символов
                {
                    if (TextBoxParol.Text.Length > 5) //Проверка пароля на длину
                    {
                        if (TextBoxPovtorParol.Text.Length != 0) //Проверка повтора пароля на наличие символов
                        {
                        if (TextBoxPovtorParol.Text == TextBoxParol.Text) //Проверка на совпадение паролей
                            {
                            if (TextBoxName.Text.Length != 0) //Проверка имени
                                {
                            if (TextBoxLastName.Text.Length != 0) //Проверка фамилии
                                    {
                                if (TextBoxGender.Text.Length != 0) //Проверка пола
                                        {
                                    if (TextBoxDateOfBirth.Text.Length != 0) //Проверка даты рождения
                                            {
                                        if (TextBoxCountry.Text.Length != 0) //Проверка Страны
                                                {

                                            MessageBox.Show("Успешная регистрация");

                                        }
                                        else MessageBox.Show("Страна не заполнена");
                                    }
                                    else MessageBox.Show("Дата рождения не заполнена");
                                }
                                else MessageBox.Show("Пол не заполнен");
                            }
                            else MessageBox.Show("Фамилия не заполнена");
                        }
                        else MessageBox.Show("Имя не заполнено");
                        }
                        else MessageBox.Show("Пароли не совпадают");
                    }
                    else MessageBox.Show("Повторите Пароль");
                    }
                    else MessageBox.Show("Пароль должен содержать минимум 6 символов");
                }
                else MessageBox.Show("Пароль не заполнен");
                }
                else MessageBox.Show("Email заполнен не верно");
            }
            else MessageBox.Show("Email не заполнен");

        }
    }
}
