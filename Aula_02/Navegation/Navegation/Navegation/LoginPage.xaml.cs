using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            btnLogin.Clicked += btnLoginCliked;
            
		}

        public void btnLoginCliked(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }
	}
}