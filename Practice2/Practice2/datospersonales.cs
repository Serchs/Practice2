using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practice2
{
    public class datospersonales : ContentPage
    {
        public datospersonales()
        {
            Button btn1 = new Button
            {
                Text = string.Format("BACK"),
                BackgroundColor = Color.DarkOliveGreen,
                TextColor = Color.PaleTurquoise,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest=100,
               
            };
            btn1.Clicked += (sender, args) =>
            {
                Navigation.PushModalAsync(new MainPage());

            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                new Label { HorizontalTextAlignment = TextAlignment.Center, Text ="TECNOLOGICO DE ESTUDIOS SUPERIORES DE HUIXQUILUCAN"},
                new Label { HorizontalTextAlignment = TextAlignment.Center, Text ="SERCHS CONTRERAS"},
                new Label { HorizontalTextAlignment = TextAlignment.Center, Text ="MATRICULA:12090098"},
                btn1,
               }
            };


        }
    }
}