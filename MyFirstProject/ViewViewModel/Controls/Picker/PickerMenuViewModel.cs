using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    public class PickerMenuViewModel : BaseViewModel
    {
        public ICommand OnPickerButtonClicked { get; set; }
        public ICommand OnPickerViewModelButtonClicked { get; set; }
        public PickerMenuViewModel()
        {
            Title = Titles.PickerMenuTitle;
            OnPickerButtonClicked = new Command(OnPickerButtonClickedAsync);
            OnPickerViewModelButtonClicked = new Command(OnPickerViewModelButtonClickedAsync);

        }
        private async void OnPickerButtonClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerFormView());
        }

        private async void OnPickerViewModelButtonClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerViewModelFormView());
        }
    }
}