using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls;
using MyFirstProject.ViewViewModel.Layouts;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        private ICommand OnLayoutsMenuClicked { get; set; }
        private ICommand OnControlsMenuClicked { get; set; }

        public MainPageViewModel()
        {
            Title = Titles.MainPageTitle;
            Subtitle = Titles.MainPageSubtitle;

            OnLayoutsMenuClicked = new Command(OnLayoutsMenuClickedAsync);
            OnControlsMenuClicked = new Command(OnControlsMenuClickedAsync);
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsMenuView());
        }

        private async void OnControlsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ControlsMenuView());
        }
    }
}
