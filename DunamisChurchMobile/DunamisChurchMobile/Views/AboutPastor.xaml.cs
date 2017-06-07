using DunamisChurchMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DunamisChurchMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPastor : ContentPage
    {
        public AboutPastor()
        {
            InitializeComponent();

            var ImagesUrl = new List<string>
            {
                "papa1.png",
                "papa2.png",
                "papa3.png"
                
            };

            ImageCarousel.ItemsSource = ImagesUrl;
            BindingContext = new PapaViewModel(this.Navigation);
        }
    }
}
