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
    public sealed partial class CommonXAMLControlsPart2 : Page
    {
        //!!!!!IMPORTANT ARRAY FOR DYNAMIC SEARCH
        private string[] selectionItems = new string[] { "Ferdinand", "Frank", "Frida", "Nigel", "Tag", "Tanya", "Tanner", "Todd" };

        public CommonXAMLControlsPart2()
        {
            this.InitializeComponent();
        }

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString()).ToArray();
            var values = string.Join(", ", selectedDates);
            CalendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            //!!!!!IMPORTANT CODE FOR DYNAMIC SEARCH IGNORING CASE
            var autoSuggestBox = (AutoSuggestBox)sender;
            //Paul1967 in comments under this video https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-025-Common-XAML-Controls-Part-2
            //to compare two strings for equality, ignoring case (there are more comments under that video)
            var filtered = selectionItems.Where(P => P.ToLower().StartsWith(autoSuggestBox.Text.ToLower())).ToArray();
            autoSuggestBox.ItemsSource = filtered;
            //!!!!!IMPORTANT CODE FOR DYNAMIC SEARCH IGNORING CASE ENDED
        }
    }
}
