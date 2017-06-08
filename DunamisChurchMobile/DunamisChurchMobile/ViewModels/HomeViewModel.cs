using DunamisChurchMobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DunamisChurchMobile
{
    public class HomeViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public HomeViewModel(INavigation _Navigation)
        {

            YoutubeChannelCommand = new Command(YoutubeChannelPage);
            PartnerWithUsCommand = new Command(PartnerWithUsPage);
            OnlineGivingCommand = new Command(OnlineGivingPage);
            LiberationCityTVCommand = new Command(LiberationCityTVPage);

            Navigation = _Navigation;

        }

        public ICommand YoutubeChannelCommand { private set; get; }
        public ICommand PartnerWithUsCommand { private set; get; }
        public ICommand OnlineGivingCommand { private set; get; }
        public ICommand LiberationCityTVCommand { private set; get; }



        public void OnlineGivingPage()
        {
            Navigation.PushAsync(new Offering());

        }



        public void LiberationCityTVPage()
        {
            Navigation.PushAsync(new LiberationCityTV());

        }





        public void PartnerWithUsPage()
        {
            Navigation.PushAsync(new PartnerWithUs());

        }

        public void YoutubeChannelPage()
        {
            Navigation.PushAsync(new YoutubeChannel());

        }

    }
}
