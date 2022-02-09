using MyFirstProject.ViewViewModel.Controls.TimeAndDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.TimeAndDate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeAndDatePickerView : ContentPage
    {
        public TimeAndDatePickerView()
        {
            InitializeComponent();
            BindingContext = new TimeAndDatePickerViewModel();
        }
    }
}