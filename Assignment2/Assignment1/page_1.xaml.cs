using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class page_1 : Page
    {
        public page_1()
        {
            this.InitializeComponent();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_name.Text;
            string phone = txt_phone.Text;
            string address = txt_address.Text;
            string hobbies = list_hobbies.
            MessageDialog showDialog = new MessageDialog("Name: "+name+" Phone: "+phone+" Address: "+address);
            showDialog.Commands.Add(new UICommand("Close")
            {
                Id = 0
            });
            showDialog.DefaultCommandIndex = 0;
            showDialog.CancelCommandIndex = 1;
            await showDialog.ShowAsync();
        }
    }
}
