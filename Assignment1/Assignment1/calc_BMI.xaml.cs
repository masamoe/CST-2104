using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class calc_BMI : Page
    {
        public calc_BMI()
        {
            this.InitializeComponent();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btn_Tip_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(calc_Tip));
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            double height = Convert.ToDouble(txt_Height.Text);
            double weight = Convert.ToDouble(txt_Weight.Text);
            double bmi = weight / (height * height) * 10000;
            out_BMI.Text = "BMI = " + bmi.ToString();
        }
    }
}
