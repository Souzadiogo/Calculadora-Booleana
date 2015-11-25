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

namespace exemploendor
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

        private void btnand_Click(object sender, RoutedEventArgs e)
        {
            
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtvar1.Text)) && Convert.ToBoolean(Convert.ToInt16(txtvar2.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtvar2.Text));

            
            bool varResult = var1 && var2;
           
            result.Text = varResult.ToString();
             
        }

        private void txtvar2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnor_Click(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtvar1.Text)) || Convert.ToBoolean(Convert.ToInt16(txtvar2.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtvar2.Text)) || Convert.ToBoolean(Convert.ToInt16(txtvar1.Text));

            bool varResult = var1 || var2;

            result.Text = varResult.ToString();
        }

       
        private void btnnot_Click(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtvar1.Text)) ^! Convert.ToBoolean(Convert.ToInt16(txtvar2.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtvar2.Text)) ^! Convert.ToBoolean(Convert.ToInt16(txtvar1.Text));

            bool varResult = var1 ^! var2;

            result.Text = varResult.ToString();

        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnxor_Click(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtvar1.Text)) ^ Convert.ToBoolean(Convert.ToInt16(txtvar2.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtvar2.Text)) ^ Convert.ToBoolean(Convert.ToInt16(txtvar1.Text));

            bool varResult = var1 ^ var2;

            result.Text = varResult.ToString();

        } 

        private void checkBoxa_Checked(object sender, RoutedEventArgs e)
        {
            bool var1 = ((bool)checkBoxa.IsChecked ? Convert.ToBoolean(Convert.ToInt16(txtvar1.Text)) : !Convert.ToBoolean(Convert.ToInt16(txtvar1)));

            bool varResult = !var1;

            result.Text = varResult.ToString();

        }

        private void checkBoxb_Checked(object sender, RoutedEventArgs e)
        {
            bool var2 = ((bool)checkBoxb.IsChecked ? Convert.ToBoolean(Convert.ToInt16(txtvar2.Text)) : !Convert.ToBoolean(Convert.ToInt16(txtvar2)));

            bool varResult = !var2;

            result.Text = varResult.ToString();


        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtvar1.Clear();
            txtvar2.Clear();
            result.Clear();
            

        }
    }
        

    } 

