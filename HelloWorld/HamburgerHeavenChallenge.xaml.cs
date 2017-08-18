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
    public sealed partial class HamburgerHeavenChallenge : Page
    {
        public HamburgerHeavenChallenge()
        {
            this.InitializeComponent();
            backBn.Visibility = Visibility.Collapsed;
            textBlock.Text = "Financial";
            MyFrame.Navigate(typeof(Financial));
            FinancialListBoxItem.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinancialListBoxItem.IsSelected)
            {
                textBlock.Text = "Financial";
                backBn.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Financial));
            }
            else if (FoodListBoxItem.IsSelected)
            {
                textBlock.Text = "Food";
                backBn.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Food));
            }
        }

        private void backBn_Click(object sender, RoutedEventArgs e)
        {
            backBn.Visibility = Visibility.Collapsed;
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                FinancialListBoxItem.IsSelected = true;
            }
        }
    }
}
