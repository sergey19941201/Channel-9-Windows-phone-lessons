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
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            //this variable is in App.xaml.cs
            App.SomeImportantValue = ValueTextBox.Text;
            //we pass ValueTextBox.Text to Page3
            Frame.Navigate(typeof(Page3), ValueTextBox.Text);
        }

        //!!!!!!!!this method is used when u navigate to this page:
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(!String.IsNullOrEmpty(App.SomeImportantValue))
            {
                //App.SomeImportantValue is global variable in App.xaml.cs
                ValueTextBox.Text = App.SomeImportantValue;
            }
        }
    }
}
