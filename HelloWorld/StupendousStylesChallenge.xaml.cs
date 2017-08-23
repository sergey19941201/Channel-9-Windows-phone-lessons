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
    public sealed partial class StupendousStylesChallenge : Page
    {
        public StupendousStylesChallenge()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(DonutPage));
        }

        private void CompleteBn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CompletePage));
        }

        private void Donutsbn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DonutPage));
        }

        private void CoffeeBn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CoffeePage));
        }

        private void ScheduleBn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(SchedulePage));
        }
    }
}
