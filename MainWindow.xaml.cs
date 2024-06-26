using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace testdatetime
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
        static string Zodiak(int d, int m)
        {
            if ((d >= 21 && m == 3) || (d <= 20 && m == 4)) return "Овен, юпитер, камень ";
            if ((d >= 21 && m == 4) || (d <= 20 && m == 5)) return "Телец, юпитер, камень";
            if ((d >= 21 && m == 5) || (d <= 21 && m == 6)) return "Близнецы, юпитер, камень";
            if ((d >= 22 && m == 6) || (d <= 22 && m == 7)) return "рак , юпитер, камень";
            if ((d >= 23 && m == 7) || (d <= 23 && m == 8)) return "лев , юпитер, камень";
            if ((d >= 24 && m == 8) || (d <= 23 && m == 9)) return "дева, юпитер, камень";
            if ((d >= 24 && m == 9) || (d <= 23 && m == 10)) return "весы, юпитер, камень";
            if ((d >= 24 && m == 10) || (d <= 22 && m == 11)) return "скорпион, юпитер, камень";
            if ((d >= 23 && m == 11) || (d <= 21 && m == 12)) return "стрелец, юпитер, камень";
            if ((d >= 22 && m == 12) || (d <= 20 && m == 1)) return "козерог, юпитер, камень";
            if ((d >= 21 && m == 1) || (d <= 18 && m == 2)) return "водолей, юпитер, камень";
            else return "рыбы , юпитер, камень";
        }
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar.SelectedDate;
            int d = selectedDate.Value.Day;
            int m = selectedDate.Value.Month;
            MessageBox.Show($"{Zodiak(d,m)}","Ваш знак и характеристики", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DateTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
