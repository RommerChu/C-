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

namespace WPFApp1_Lesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_FullName_Click(object sender, RoutedEventArgs e)
        {
            string first_name = txtBox_FirstName.Text;
            string last_name = txtBox_LastName.Text;
            lbl_Result.Content = first_name + " " + last_name;

        }
        //THIS IS ADDITION
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
            lbl_result2.Content = num1 + num2;

        }
        //THIS IS SUBTRACTION
        private void btn_add_Copy_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
            lbl_result2.Content = num1 - num2;
        }
        //THIS IS MULTIPLICATION
        private void btn_add_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
            lbl_result2.Content = num1 * num2;
        }
        //THIS IS DIVISION
        private void btn_add_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
            lbl_result2.Content = num1 / num2;
        }
    }
}
