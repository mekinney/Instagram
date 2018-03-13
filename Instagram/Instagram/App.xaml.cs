using Instagram.Views;
using Xamarin.Forms;
using FreshMvvm;

namespace Instagram
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<WelcomePageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
//            MainPage = new NavigationPage(new LaunchPage(this));


        }

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
