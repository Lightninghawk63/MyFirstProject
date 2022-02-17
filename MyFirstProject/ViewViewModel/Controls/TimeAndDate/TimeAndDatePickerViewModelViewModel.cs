using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.TimeAndDate
{
    public class TimeAndDatePickerViewModelViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; }
        public ICommand OnSubmitClicked { get; }

        public DateTime _startDate;
        public DateTime _endDate;
        public int _dayDifference = -1;
        public TimeAndDatePickerViewModelViewModel()
        {
            Title = Titles.TimeAndDatePickerViewModelTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }
        public DateTime MinDate
        {
            get
            {
                return Dates.MinDate;
            }
        }

        public DateTime MaxDate
        {
            get
            {
                return Dates.MaxDate;
            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            string msg = "The start date selected is: " + _startDate.ToShortDateString() + ", " + "the end date selected is: " + _endDate.ToShortDateString();

            if (_dayDifference != -1)
            {
                msg += "The difference in days is: " + _dayDifference;
            }

            await Application.Current.MainPage.DisplayAlert(Titles.TimeAndDatePickerViewModelTitle, msg, "Ok");

        }

        public void compareDates()
        {
            _dayDifference = 1;
        }
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                if(_startDate != value)
                {
                    SetProperty(ref _startDate, value);
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                if (_endDate != value)
                {
                    SetProperty(ref _endDate, value);
                }
            }
        }
    }
}