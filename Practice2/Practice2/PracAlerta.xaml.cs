using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PracAlerta : ContentPage
	{
		public PracAlerta ()
		{
			InitializeComponent ();
		}
        private void MostrarOnClicked(object sender, EventArgs e)
        {
            //  Navigation.PushModalAsync(new PracAlerta());

            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Ape.Text) || string.IsNullOrEmpty(Direc.Text)
                || string.IsNullOrEmpty(Tel.Text) || string.IsNullOrEmpty(Carr.Text) || string.IsNullOrEmpty(Matr.Text)
                || string.IsNullOrEmpty(Ema.Text) || string.IsNullOrEmpty(GH.Text))
            {

                DisplayAlert("error", "llena los campos requeridos", "ok");
            }
            else
            {
                DisplayAlert("datos_personales", "\nnombre:" + Name.Text +
                "\napellidos:" + Ape.Text + "\ndireccion:" + Direc.Text +
                "\ntelefono:" + Tel.Text +
                "\n\ndatos_escolares\ncarrera:" + Carr.Text +
                " \nsemestre:" + Sem.Text + "\nmatricula:" + Matr.Text +
                "\n\ndatos_sociales\ncorreo:" + Ema.Text + " \ngithub:"
                + GH.Text, "aceptar");
            }
        }
         private void MostrarBack(object sender, EventArgs e )
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}