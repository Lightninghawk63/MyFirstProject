using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Image.EmbeddedImages;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image
{
    class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnEmbeddedImagesClicked  { get; set; }
        public ImageMenuViewModel()
        {
            Title = Titles.ImageTitle;
            OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
        }

        private async void OnEmbeddedImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
        }
    }
}
