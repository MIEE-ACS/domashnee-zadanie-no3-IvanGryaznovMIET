using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
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


namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string decodedRUL = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string decodedRUl = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string decodedENL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string decodedENl = "abcdefghijklmnopqrstuvwxyz";
            int size = 33;
            int size1 = 26;
            int b = 0;
            char ras = 'b';
            string text1 = "";
            string text = tb1.Text;
            int n = text.Length;
            
            //Вариант 4. Шифр Атбаш. Заменить последнюю буквы на первую и т.п.
                for (int i = 0; i < n; i++)
                {
                    if (!Char.IsLetter(text[i]))
                    {
                        MessageBox.Show("Ошибка! Нужно вводить только буквы латинского алфавита или кирилицу.");
                        tb2.Text = "Failed!";
                        break;
                    }
                    for (int j = 0; j < size; j++)
                    {
                        if (text[i] == decodedRUL[j])
                        {
                            b = j;
                            ras = decodedRUL[size - b - 1];
                            text1=text1 + ras;
                        }
                    }
                    for (int k = 0; k < size; k++)
                    {
                        if (text[i] == decodedRUl[k])
                        {
                            b = k;
                            ras = decodedRUl[size - b - 1];
                            text1 = text1 + ras;
                        }
                    }
                    for (int c = 0; c < size1; c++)
                    {
                        if (text[i] == decodedENl[c])
                        {
                            b = c;
                            ras = decodedENl[size1 - b - 1];
                            text1 = text1 + ras;
                        }
                    }
                    for (int c = 0; c < size1; c++)
                    {
                        if (text[i] == decodedENL[c])
                        {
                            b = c;
                            ras = decodedENL[size1 - b - 1];
                            text1 = text1 + ras;
                        }
                    }
                }
            tb2.Text = text1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
