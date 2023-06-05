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

namespace V7_Wpf_SQRT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.tbboxInput.Text = "10";
        }

        //Bei Klick auf Button
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            string input = this.tbboxInput.Text; //Abholen der Eingabe des Benutzers
            try
            {
                double wert = Convert.ToDouble(input); //Oder Tryparse //ToDouble wirft Exceptions!
                double result = Math.Sqrt(wert);
                this.tbboxOutput.Text = String.Format("{0:F3}", result);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
