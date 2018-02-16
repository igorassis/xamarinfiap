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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
            BotaoSair.Clicked += BotaoSaldoClicked;
            BotaoPerfil.Clicked += BotaoPerfilClicked;
            BotaoSair.Clicked += BotaoSairClicked;
		}
        public void BotaoSaldoClicked(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Saldo());
        }
        public void BotaoPerfilClicked(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Perfil());
        }
        public void BotaoSairClicked(Object o, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

    }
}