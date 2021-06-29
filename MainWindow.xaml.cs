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
            this.Close(); //Отмена
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text.Length != 0)
            {
                if(TextBoxParol.Text.Length != 0)
                {
                    if (TextBoxParol.Text.Length > 5)
                    {
                        if (TextBoxPovtorParol.Text.Length != 0)
                    {
                        if (TextBoxPovtorParol.Text == TextBoxParol.Text)
                        {
                            if (TextBoxName.Text.Length != 0)
                            {
                            if (TextBoxLastName.Text.Length != 0)
                            {
                                if (TextBoxGender.Text.Length != 0)
                                {
                                    if (TextBoxDateOfBirth.Text.Length != 0)
                                    {
                                        if (TextBoxCountry.Text.Length != 0)
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
            else MessageBox.Show("Email не заполнен");

        }
    }
}
