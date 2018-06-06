using Dservices.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dservices
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.btnMessage.Clicked += btnMessageClicked;
            this.btnTextoVoz.Clicked += btnText2Voice_Clicked;
            this.btnPlataforma.Clicked += BtnPlatform_Clicked;
        }

        private async void BtnPlatform_Clicked(object sender, EventArgs e)
        {

            await Task.Delay(5000).ConfigureAwait(false);
            Device.StartTimer(TimeSpan.FromSeconds(1), () => 
            {
                Device.BeginInvokeOnMainThread(() => {
                    this.txtAviso.Text = DateTime.Now.ToString();
                });
                return true;

            });
        }

        private void btnText2Voice_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IText2Voice>();
          
            service.speak("Juliet Paseme el codigo, porfavor no seas mala");
          
        }

        private async void btnMessageClicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatMessage>();
            var message = service.getMessage();
            await DisplayAlert("DependencyService", message, "ok");
        }
    }
}
