using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Image.EmbeddedImageProject
{
    public class EmbeddedImageProjectViewModel : BaseImageViewModel
    {
        public EmbeddedImageProjectViewModel()
        {
            Title = Titles.EmbeddedImageProjectTitle;
            Image = Images.EmbeddedImageProjectImageSrc;
        }
    }
}