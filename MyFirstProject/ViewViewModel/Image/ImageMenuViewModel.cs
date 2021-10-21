using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Image.EmbeddedImageProject;
using MyFirstProject.ViewViewModel.Image.EmbeddedImages;
using MyFirstProject.ViewViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image
{
    class ImageMenuViewModel : BaseViewModel
    {
        public ICommand OnEmbeddedImagesClicked  { get; set; }
        public ICommand OnEmbeddedImageProjectClicked { get; set; }
        public ImageMenuViewModel()
        {
            Title = Titles.ImageTitle;
            OnEmbeddedImagesClicked = new Command(OnEmbeddedImagesClickedAsync);
            OnEmbeddedImageProjectClicked = new Command(OnEmbeddedImageProjectClickedAsync);
        }

        private async void OnEmbeddedImagesClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImagesView());
        }
        private async void OnEmbeddedImageProjectClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageProjectView());
        }
    }
}
