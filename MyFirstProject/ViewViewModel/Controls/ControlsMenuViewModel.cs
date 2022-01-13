using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls.Slider;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls
{
    public class ControlsMenuViewModel : BaseViewModel
    {
        public ICommand OnSliderClicked { get; set; }
        public ControlsMenuViewModel()
        {
            Title = Titles.ControlsTitle;
            OnSliderClicked = new Command(OnSliderClickedAsync);
        }

        private async void OnSliderClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
    }
}
