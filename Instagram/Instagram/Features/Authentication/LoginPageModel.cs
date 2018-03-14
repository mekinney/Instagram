using FreshMvvm;
using Xamarin.Forms;

namespace Instagram
{
	/// <summary>
	/// This is a standard ViewModel.
	/// </summary>
	public class LoginPageModel : FreshBasePageModel
	{
        public LoginPageModel ()
        {

        }

        public Command LoginCommand
        {
            get
            {
                return new Command(async () => {
                    await CoreMethods.PushPageModel<FeedPageModel>(null, true);
                });
            }
        }


    }
}
