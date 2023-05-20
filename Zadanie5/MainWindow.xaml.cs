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

namespace Zadanie5
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
                double A1 = Convert.ToDouble(TbNumberA1.Text);
                double B1 = Convert.ToDouble(TbNumberB1.Text);
                double C1 = Convert.ToDouble(TbNumberC1.Text);
                double A2 = Convert.ToDouble(TbNumberA2.Text);
                double B2 = Convert.ToDouble(TbNumberB2.Text);
                double C2 = Convert.ToDouble(TbNumberC2.Text);
                double d = A1 * B2 - A2 * B1;
                double x = (double)(C1 * B2 - C2 * B1) / d;
                double y = (double)(A1 * C2 - A2 * C1) / d;
                TextBlockAnswer.Text = $"Ответ:\nx = {x:f2}" + $"\ny = {y:f2}";
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
