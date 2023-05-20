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

namespace Zadanie3
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbNumberX.Text);
                double a = Convert.ToDouble(TbNumberA.Text);
                double y = Convert.ToDouble(TbNumberY.Text);
                double b = Convert.ToDouble(TbNumberB.Text);
                double xa = a / x;
                double yb = b / y;
                double how = xa / yb;
                TextBlockAnswer.Text = $"Ответ:\n1 кг шоколадных конфет стоит = {xa:f2}\n" +
                    $"1 кг ирисок стоит = {yb:f2}\n" +
                    $"Шоколадные конфеты дороже ирисок в {how:f1} раз(а)";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
