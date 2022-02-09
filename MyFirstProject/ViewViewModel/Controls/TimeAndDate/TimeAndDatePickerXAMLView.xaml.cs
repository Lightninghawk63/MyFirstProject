using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.TimeAndDate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeAndDatePickerXAMLView : ContentPage
    {
        public TimeAndDatePickerXAMLView()
        {
            InitializeComponent();
            BindingContext = new TimeAndDatePickerViewModel();
        }
    }
}