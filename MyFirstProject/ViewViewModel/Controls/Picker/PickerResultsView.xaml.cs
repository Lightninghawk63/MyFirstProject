using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Picker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerResultsView : ContentPage
    {
        public PickerResultsView(string fromPageTitle, string cardPicked)
        {
            BindingContext = new PickerResultsViewModel(fromPageTitle, cardPicked);
            InitializeComponent();
        }
    }
}