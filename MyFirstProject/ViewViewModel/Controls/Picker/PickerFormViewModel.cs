using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    public class PickerFormViewModel : ContentPage
    {
        public string _selectedItem { get; set; }
        public ICommand OnSubmitClicked { get; set; }
        public PickerFormViewModel()
        {
            Title = Titles.PickerFormTitle;
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                   // SetProperty(ref _selectedItem, value);
                }
            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            /*if (String.IsNullOrEmpty(_selectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerFormTitle);
                return;
            }
            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView("Picker XAML Results", "Ok"));*/
        }
    }
}