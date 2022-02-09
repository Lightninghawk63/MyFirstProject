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
    public partial class PickerViewModelFormView : ContentPage
    {
        public PickerViewModelFormView()
        {
            BindingContext = new PickerViewModelFormViewModel();
            InitializeComponent();
        }
    }
}