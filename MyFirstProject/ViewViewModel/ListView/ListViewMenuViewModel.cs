using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.ListView.ListViewNames;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView
{
    class ListViewMenuViewModel : BaseViewModel
    {
        public ICommand OnListViewNamesClicked { get; set; }

        public ListViewMenuViewModel()
        {
            Title = Titles.ListViewTitle;
            OnListViewNamesClicked = new Command(OnListViewNamesClickedAsync);
        }
        private async void OnListViewNamesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListViewNamesView());
        }
    }
}
