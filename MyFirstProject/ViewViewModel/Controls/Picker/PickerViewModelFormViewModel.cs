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
    public class PickerViewModelFormViewModel : BaseViewModel
    {
        public string _selectedItem { get; set; }
        public List<PlayingCard> PickerValues { get; set; }
        public List<string> CardNames { get; set; }
        public ICommand OnSubmitClicked { get; set; }
        public PickerViewModelFormViewModel()
        {
            Title = Titles.PickerFormTitle;
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
            GeneratePickerValues();
        }

        public void GeneratePickerValues()
        {
            PickerValues = PlayingCard.GetCard();

            CardNames = (from index in PickerValues select index.Name).ToList();
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if(_selectedItem != value)
                {
                    //SetProperty(ref _selectedItem, value);
                }
            }
        }

        private async void OnSubmitClickedAsync(object obj)
        {
            if (String.IsNullOrEmpty(_selectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.PickerFormTitle, "A selection must be made!", "Ok");
                return;
            }

            //var result = _cards.FirstOrDefault(Xamarin => Xamarin.Character.Equals(_selectedItem));
            //string name = result.Name + "As" + result.Character;

            //await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView("Picker View Model Results", result.Image));
        }
    }
}
