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

            PrayerCommand = new Command(PrayerPage);
            YoutubeChannelCommand = new Command(YoutubeChannelPage);
            EventCommand = new Command(EventPage);
            OnlineGivingCommand = new Command(OnlineGivingPage);
            TestimonyCommand = new Command(TestimonyPage);
            LiberationCityTVCommand = new Command(LiberationCityTVPage);

            Navigation = _Navigation;

        }

        public ICommand PrayerCommand { private set; get; }
        public ICommand YoutubeChannelCommand { private set; get; }
        public ICommand EventCommand { private set; get; }
        public ICommand OnlineGivingCommand { private set; get; }
        public ICommand TestimonyCommand { private set; get; }
        public ICommand LiberationCityTVCommand { private set; get; }
        public ICommand SeedOfDestinyCommand { get; set; }



        public void OnlineGivingPage()
        {
            Navigation.PushAsync(new Offering());

        }

        public void PrayerPage()
        {
            Navigation.PushAsync(new Prayers());

        }

        public void LiberationCityTVPage()
        {
            Navigation.PushAsync(new LiberationCityTV());

        }

        public void TestimonyPage()
        {
            Navigation.PushAsync(new Testimonies());

        }



        public void EventPage()
        {
            Navigation.PushAsync(new Events());

        }

        public void YoutubeChannelPage()
        {
            Navigation.PushAsync(new YoutubeChannel());

        }
        
    }
}
