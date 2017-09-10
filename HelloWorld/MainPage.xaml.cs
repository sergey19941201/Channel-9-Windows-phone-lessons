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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Frame rootFrame = Window.Current.Content as Frame;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*Button myButton = new Button();
            myButton.Name = "ClickMeButton";
            myButton.Content = "Click Me";
            myButton.Width = 200;
            myButton.Height = 100;
            myButton.Margin = new Thickness(20, 20, 0, 0);
            myButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left;
            myButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;

            myButton.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            myButton.Click += ClickMeButton_Click;

            LayoutGrid.Children.Add(myButton);*/
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Ramzan\nMakaka\nDeathstroke";
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(SplitPanel));
        }

        private void MyPaGeButton_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(MyPage));
        }

        private void ControlsExamplePart1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CommonXAMLControlsPart1));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hamburger));
        }

        private void HamburgerHeavenChallengeBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HamburgerHeavenChallenge));
        }

        private void ControlsExamplePart2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CommonXAMLControlsPart2));
        }

        private void ScrollBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Scroll));
        }

        private void CanvasAndShapesBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CanvasAndShapes));
        }

        private void XAML_StylesBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(XAML_Styles));
        }

        private void XAML_ThemesBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(XAML_Themes));
        }

        private void StupendousStylesChallenge_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StupendousStylesChallenge));
        }

        private void AdaptiveTriggersBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdaptiveTriggers));
        }

        private void AdaptiveLayoutBn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdaptiveLayout));
        }
    }
}
