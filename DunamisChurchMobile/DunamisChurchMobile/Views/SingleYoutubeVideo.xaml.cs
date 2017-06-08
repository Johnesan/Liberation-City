﻿using DunamisChurchMobile.Models;
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
    public partial class SingleYoutubeVideo : ContentPage
    {
        public SingleYoutubeVideo(string videoId)
        {
            InitializeComponent();
            BindingContext = new YoutubeItem();

            //adds " to the end of the videoId
            videoId = videoId + "\"";
            //youtubeVideo.Source = "https://www.youtube.com/embed/" + videoId;
            var htmlSource = new HtmlWebViewSource();

            //the htmlSource.Html would look something like<html><body><iframe width="100%" src="https://www.youtube.com/embed/ow241ADZxE" frameborder="0" allowfullscreen></iframe></body></html>
            htmlSource.Html = @"<html><body><iframe width=""100%"" height=""100%"" src = ""https://www.youtube.com/embed/" + videoId  + " frameborder = \"0\" allowfullscreen></iframe ></body></html>";
            youtubeVideo.Source = htmlSource;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await progressBar.ProgressTo(0.9, 900, Easing.SpringIn);

        }
        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            progressBar.IsVisible = true;
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            progressBar.IsVisible = false;

        }
    }
}
