using Xamarin.Forms;
using FreshMvvm;

namespace Instagram
{
	/// <summary>
	/// This is a standard ViewModel.
	/// </summary>
	public class WelcomePageModel : FreshBasePageModel
    {
        public WelcomePageModel ()
        {

        }

        public Command LoginScreenCommand
        {
            get
            {
                return new Command(async () => {
                        await CoreMethods.PushPageModel<LoginPageModel>();
                    });
            }
        }

    }
}
