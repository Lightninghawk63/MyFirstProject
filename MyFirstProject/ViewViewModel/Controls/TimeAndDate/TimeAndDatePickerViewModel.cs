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
    public class TimeAndDatePickerViewModel : BaseViewModel
    {
        public ICommand OnTimeAndDatePickerXAMLButtonClicked { get; set; }
        public TimeAndDatePickerViewModel()
        {
            Title = Titles.TimeAndDatePickerTitle;
            OnTimeAndDatePickerXAMLButtonClicked = new Command(OnTimeAndDatePickerXAMLButtonClickedAsync);
        }

        private async void OnTimeAndDatePickerXAMLButtonClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TimeAndDatePickerXAMLView());
        }
    }
}