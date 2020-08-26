using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Movil2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Boton1_Clicked(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage(antryAsunto.Text, "<h1>Bienvenido a xamarin</h1><span>Esta es una prueba de envío de correo</span>", entryMail.Text);
            mensaje.BodyFormat = EmailBodyFormat.PlainText;
            await Email.ComposeAsync(mensaje);
        }
    }
}
