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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private static string roastValue, sweetenerValue, creamValue;
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            roastValue = "None";
            coffeeValueTB.Text = roastValue;
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            roastValue = "Dark";
            coffeeValueTB.Text = roastValue;

        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            roastValue = "Medium";
            coffeeValueTB.Text = roastValue;
        }

        private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {
            if (roastValue != "None")
            {
                creamValue = "2% Milk";
                coffeeValueTB.Text = roastValue + " + " + sweetenerValue + " + " + creamValue;
            }
        }
        private void MenuFlyoutItem_Click_4(object sender, RoutedEventArgs e)
        {
            if (roastValue != "None")
            {
                sweetenerValue = "Sugar";
                coffeeValueTB.Text = roastValue + " + " + sweetenerValue;
            }
        }

        private void MenuFlyoutItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (roastValue != "None")
            {
                creamValue = "Whole Milk";
                coffeeValueTB.Text = roastValue + " + " + sweetenerValue + " + " + creamValue;
            }
        }
    }
}
