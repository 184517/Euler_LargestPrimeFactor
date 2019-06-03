/* Jordan Ross
 * June 3, 2019
 * Finding the greatest prime factor of 600851475143
 */
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

namespace Euler_LargestPrimeFactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Num = 600851475143;
        double GreatestPrime = 0;
        double Counter = 2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            while (
                Counter * Counter <= Num)
            {
                if (Num % Counter == 0)
                {
                    Num = Num / Counter;
                    GreatestPrime = Counter;
                }
                else
                {
                    Counter++;
                }
            }
            if (Num > GreatestPrime)
            {
                GreatestPrime = Num;
            }
            lblOutput.Content = GreatestPrime;
        }
    }
}
