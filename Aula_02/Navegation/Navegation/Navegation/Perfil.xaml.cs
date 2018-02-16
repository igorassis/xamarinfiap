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
	public partial class Perfil : ContentPage
	{
		public Perfil ()
		{
			InitializeComponent ();
            btnVoltar.Clicked += btnVoltarClicked;
            btnSair.Clicked += btnSairClicked;
		}

        public void btnVoltarClicked(Object o, EventArgs e)
        {
            Navigation.PopAsync();
        }

        public void btnSairClicked(Object o, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
	}
}