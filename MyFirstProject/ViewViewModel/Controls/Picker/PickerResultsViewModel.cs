using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    public class PickerResultsViewModel : ContentPage
    {
        public string fromPageTitle { get; set; }
        public string cardPicked { get; set; }
        public PickerResultsViewModel(string fromPageTitle, string cardPicked)
        {
            Title = Titles.PickerResultTitle;
            this.fromPageTitle = fromPageTitle;
        }
    }
}