﻿using DunamisChurchMobile.Views;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DunamisChurchMobile.ViewModels
{
    class SocialMediaViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public ICommand facebookCommand { get; private set; }
        public ICommand twitterCommand { get; private set; }
        public ICommand instagramCommand { get; set; }
        public ICommand youtubeCommand { get; set; }

        public SocialMediaViewModel(INavigation _Navigation)
        {
            facebookCommand = new Command(facebookPage);
            twitterCommand = new Command(twitterPage);
            instagramCommand = new Command(instagramPage);
            youtubeCommand = new Command(youtubePage);
            Navigation = _Navigation;
        }



        public void facebookPage()
        {
            try
            {
                Device.OpenUri(new Uri("fb://page/247939405316259"));
            }
            catch
            {
                Device.OpenUri(new Uri("https://www.facebook.com/liberationcity/"));
            }
        }

        public void twitterPage()
        {
            try
            {
                Device.OpenUri(new Uri("twitter://user?user_id=613891565"));
            }
            catch
            {
                Device.OpenUri(new Uri("https://twitter.com/liberationcity"));
            }           
        }

        public void instagramPage()
        {
            try
            {
                Device.OpenUri(new Uri("instagram://user?username=liberationcity"));
            }
            catch
            {
                Device.OpenUri(new Uri("https://www.instagram.com/liberationcity/"));
            }          
        }

        public void youtubePage()
        {
            Device.OpenUri(new Uri("https://www.youtube.com/user/liberationcitytv"));
        }
    }
}
