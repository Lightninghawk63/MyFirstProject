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
    public partial class TimeAndDatePickerViewModelView : ContentPage
    {
        DateTime _startDateSelected = new DateTime();
        DateTime _oStartDateSelected = new DateTime();
        DateTime _endDateSelected = new DateTime();
        DateTime _oEndDateSelected = new DateTime();
        public TimeAndDatePickerViewModelView()
        { 
            InitializeComponent();
            BindingContext = new TimeAndDatePickerViewModelViewModel();
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var start = (TimeAndDatePickerViewModelViewModel)BindingContext;
            start.StartDate = e.NewDate;
            _startDateSelected = e.NewDate;
            _oStartDateSelected = e.OldDate;
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var end = (TimeAndDatePickerViewModelViewModel)BindingContext;
            end.EndDate = e.NewDate;
            _endDateSelected = e.NewDate;
            _oEndDateSelected = e.OldDate;
        }

        private void DisplayDifference(object sender, ToggledEventArgs e)
        {

        }
    }
}