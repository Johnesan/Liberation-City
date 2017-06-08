using Xamarin.Forms;

namespace DunamisChurchMobile
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            //Icon = "menu.png";
            Title = "Liberation City";
            BindingContext = new HomeViewModel(this.Navigation);
            //NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
