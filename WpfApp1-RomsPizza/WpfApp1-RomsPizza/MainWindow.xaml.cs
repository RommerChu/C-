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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApp1_RomsPizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //This is the pizza value
        public int size = 0;
        public int crust = 0;
        public int toppings = 0;
        public int addOn = 0;
        public double total = 0.00;
        public double tax = 13.00;
        public int counter = 0;
        public string size_str = "";
        public string crust_str = "";
        public string toppings_str = "";
        public string addOn_str = "";
   


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rd_small_Checked(object sender, RoutedEventArgs e)
        {
            size = 5;
            size_str = "small";
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void SizeMedium_Checked(object sender, RoutedEventArgs e)
        {
            size = 10;
            size_str = "medium";
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void SizeLarge_Checked(object sender, RoutedEventArgs e)
        {
            size = 15;
            size_str = "large";
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void CrustThin_Checked(object sender, RoutedEventArgs e)
        {
            crust = 0;
            crust_str = "thin" ;
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void CrustThick_Checked(object sender, RoutedEventArgs e)
        {
            crust = 0;
            crust_str = "thick";
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void CrustStuffed_Checked(object sender, RoutedEventArgs e)
        {
            crust = 1;
            crust_str = "stuffed";
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }


        //THIS IS THE TOPPINGS SECTONS - LINK ALL TOPPINGS IN ONE EVENT
        private void toppings_Checked(object sender, RoutedEventArgs e)
        {
            var topping_cb = sender as CheckBox;
            if (topping_cb.IsChecked == true)
            {
                counter++;
                toppings_str = toppings_str + "," + topping_cb.Content;
                if (counter > 3)
                {
                    toppings++;                   
                }
            }
            else
            {
                toppings_str = toppings_str + "," + topping_cb.Content;

                counter--;
                if (counter >= 3)
                {
                    toppings--;
                }
                
            }
            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);

        }



        //THIS IS ADDONS
        private void addOns_Checked(object sender, RoutedEventArgs e)
        {
            var addOn_cb = sender as CheckBox;
            if (addOn_cb.IsChecked == true)
            {
                if (addCheese.IsChecked == true || addSauce.IsChecked == true || addDrinks.IsChecked == true)
                {
                  //  addsOns = 1;
                    addOn++;
                    addOn_str = addOn_str + addOn_cb.Content;
                }

                else if (addYogurt.IsChecked == true)
                {
                    addOn = addOn + 3;
                    
                }
  
            }
            else
            {
                addOn--;
                if (addYogurt.IsChecked != true)
                {
                    addOn = addOn - 3;

                }
            }

            lbl_subTotal.Content = "$" + (size + crust + toppings + addOn);
        }

        private void btn_order_Click(object sender, RoutedEventArgs e)
        {
            
            lbl_total.Content = "$" + (size + crust + toppings + addOn + tax);
            MessageBox.Show("Your selected toppings: \n" + toppings_str);

            string connectionString = "datasource=127.0.0.1; port=3307; username=root; password=; database=pizza_order;";
                string query = "INSERT INTO orders(`size`, `crust`, `toppings`, `addon`, `total`) VALUES ('"+size_str+"' , '" +crust_str+ "', '" +toppings_str+ "', '"+addOn_str+"', '"+lbl_total.Content+"')";
                // Which could be translated manually to :
                // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                //Console.WriteLine(query);

            try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("You order successfully! \nThank you!");

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
            
        }




        //private void AddCheese_Checked(object sender, RoutedEventArgs e)
        //{
        //    addsOns = 1;
        //    lbl_subTotal.Content = "$" + (size + crust + toppings + addsOns);
        //}

        //private void AddSauce_Checked(object sender, RoutedEventArgs e)
        //{
        //    addsOns = 1;
        //    lbl_subTotal.Content = "$" + (size + crust + toppings + addsOns);
        //}

        //private void addOns_Checked(object sender, RoutedEventArgs e)
        //{
        //    addsOns = 1;
        //    lbl_subTotal.Content = "$" + (size + crust + toppings + addsOns);
        //}


    }
}
