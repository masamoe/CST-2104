﻿using System;
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
    public sealed partial class calc_Tip : Page
    {
        public calc_Tip()
        {
            this.InitializeComponent();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btn_BMI_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(calc_BMI));
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            double bill = Convert.ToDouble(txt_Bill.Text);
            double tip = Convert.ToDouble(txt_Tip.Text);
            double total = bill + (bill * tip / 100);
            out_Total.Text = "Total = " + total.ToString();

        }
    }
}
