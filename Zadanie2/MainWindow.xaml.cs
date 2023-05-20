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

namespace Zadanie2
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
                double x1 = Convert.ToDouble(TbNumberx1.Text);
                double y1 = Convert.ToDouble(TbNumbery1.Text);
                double x2 = Convert.ToDouble(TbNumberx2.Text);
                double y2 = Convert.ToDouble(TbNumbery2.Text);
                double a = Math.Abs(x2 - x1);
                double b = Math.Abs(y2 - y1);
                double S = a * b;
                double P = 2 * (a + b);
                TextBlockAnswer.Text = $"Ответ:\nПлощадь = {S}\n" + $"Периметр = {P}";
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
