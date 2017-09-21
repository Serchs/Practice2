using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practice2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void MostrarOnClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text) || String.IsNullOrEmpty(Ape.Text) || String.IsNullOrEmpty(Direc.Text)
                || String.IsNullOrEmpty(Tel.Text) || String.IsNullOrEmpty(Carr.Text) || String.IsNullOrEmpty(Matr.Text)
                || String.IsNullOrEmpty(Ema.Text) || String.IsNullOrEmpty(GH.Text))
            {
                
                    DisplayAlert("Error", "Llena los Campos requeridos", "OK");

                
            }
            else  
            {
                DisplayAlert("Datos_Personales", "\nNombre:" + Name.Text +
                "\nApellidos:" + Ape.Text + "\nDireccion:" + Direc.Text +
                "\nTelefono:" + Tel.Text +
                "\n\nDatos_Escolares\nCarrera:" + Carr.Text +
                " \nSemestre:" + Sem.Text + "\nMatricula:" + Matr.Text +
                "\n\nDatos_Sociales\nCorreo:" + Ema.Text + " \nGitHub:"
                + GH.Text, "Aceptar");

               
            }

           

        }
    }
}
