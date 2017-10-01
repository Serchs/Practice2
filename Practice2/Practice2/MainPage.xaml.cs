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
            Navigation.PushModalAsync(new PracAlerta());

        }
        private void MostrarOnClick(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new datospersonales());

        }
        private void MostrarOnCli(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new calculadora());

        }
    }
}
