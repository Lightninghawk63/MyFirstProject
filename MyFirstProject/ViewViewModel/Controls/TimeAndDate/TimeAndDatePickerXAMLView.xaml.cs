using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.TimeAndDate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeAndDatePickerXAMLView : ContentPage
    {
        DateTime StartDate = new DateTime();
        DateTime oStartDate = new DateTime();
        DateTime EndDate = new DateTime();
        DateTime oEndDate = new DateTime();

        public TimeAndDatePickerXAMLView()
        {
            InitializeComponent();
            BindingContext = new TimeAndDatePickerXAMLViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string msg = "The start date selected is: " + StartDate.ToShortDateString() + ", " + 
                "The end date selected is: " + EndDate.ToShortDateString();

            await Application.Current.MainPage.DisplayAlert(Titles.TimeAndDatePickerXAMLTitle, msg, "ok");
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            StartDate = e.NewDate;
            oStartDate = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            EndDate = e.NewDate;
            oEndDate = e.OldDate;

        }
    }
}