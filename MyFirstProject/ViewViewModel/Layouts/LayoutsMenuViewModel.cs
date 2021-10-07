using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Layouts.AbsoluteLayout;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Layouts
{
    class LayoutsMenuViewModel : BaseViewModel
    {
        public ICommand OnAbsoluteLayoutClicked { get; set; }
        public LayoutsMenuViewModel()
        {
            Title = Titles.LayoutsTitle;
            OnAbsoluteLayoutClicked = new Command(OnLayoutsMenuClickedAsync);
        }

        private async void OnLayoutsMenuClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
    }
}
