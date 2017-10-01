using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practice2
{
    public class calculadora : ContentPage 
    {
        
        public EventArgs args;
        private double a;
        private double b;
        private double c;



        public calculadora()
        {
            Entry num_1 = new Entry
            {
                BackgroundColor = Color.Blue,
                TextColor = Color.Yellow,
                //WidthRequest = 30,
                //HeightRequest = 30,
                VerticalOptions = LayoutOptions.Center,
                //  HorizontalOptions= LayoutOptions.Center,
                Keyboard = Keyboard.Numeric
            };
            Entry num_2 = new Entry()
            {

                BackgroundColor = Color.Blue,
                TextColor = Color.Yellow,
                //WidthRequest = 40,
                //HeightRequest =40,
                VerticalOptions = LayoutOptions.Center,
                // HorizontalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Numeric
            };
            Entry num_3 = new Entry()
            {
                BackgroundColor = Color.Maroon,
                TextColor = Color.Yellow,
                //WidthRequest = 30,
                //HeightRequest = 30,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                // HorizontalOptions = LayoutOptions.Center   

            };

            Button btn1 = new Button
            {
                Text = string.Format("SUM (+)"),
                BackgroundColor = Color.Navy,
                TextColor = Color.Fuchsia,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };
            btn1.Clicked += (sender, args) =>
            {
                if (String.IsNullOrEmpty(num_1.Text) || String.IsNullOrEmpty(num_2.Text))
                {

                }
                else
                {


                    btn1.IsEnabled = true;
                    a = double.Parse(num_1.Text);
                    b = double.Parse(num_2.Text);
                    c = a + b;
                    num_3.Text = "" + c;
                }
            };
            Button btn2 = new Button
            {
                Text = string.Format("SUBTRACTION (-)"),
                BackgroundColor = Color.Navy,
                TextColor = Color.Fuchsia,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };
            btn2.Clicked += (sender, args) =>
            {
                if (String.IsNullOrEmpty(num_1.Text) || String.IsNullOrEmpty(num_2.Text))
                {

                }
                else
                {
                    btn2.IsEnabled = true;
                    a = double.Parse(num_1.Text);
                    b = double.Parse(num_2.Text);
                    c = a - b;
                    num_3.Text = "" + c;
                }
            };

            Button btn3 = new Button
            {
                Text = string.Format("MULTIPLICATION(*)"),
                BackgroundColor = Color.Navy,
                TextColor = Color.Fuchsia,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };
            btn3.Clicked += (sender, args) =>
            {
                if (String.IsNullOrEmpty(num_1.Text) || String.IsNullOrEmpty(num_2.Text))
                {

                }
                else
                {
                    btn3.IsEnabled = true;
                    a = double.Parse(num_1.Text);
                    b = double.Parse(num_2.Text);
                    c = a * b;
                    num_3.Text = "" + c;


                }
            };
            Button btn4 = new Button
            {
                Text = string.Format("DIVISION (/)"),
                BackgroundColor = Color.Navy,
                TextColor = Color.Fuchsia,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200,
            };
            btn4.Clicked += (sender, args) =>
            {
                if (String.IsNullOrEmpty(num_1.Text) || String.IsNullOrEmpty(num_2.Text))
                {
                    MessagingCenter.Send("Alert", "need one number", "OK");


                }
                else
                {
                    btn4.IsEnabled = true;
                    a = double.Parse(num_1.Text);
                    b = double.Parse(num_2.Text);
                    c = a / b;
                    num_3.Text = "" + c;
                }
            };

            Button btn5 = new Button
            {
                Text = string.Format("BACK"),
                BackgroundColor = Color.DarkOliveGreen,
                TextColor = Color.PaleTurquoise,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 100,
            };
            btn5.Clicked += (sender, args) =>
            {
                Navigation.PushModalAsync(new MainPage());

            };


            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                        num_1,
                        num_2,
                        num_3,
                        btn1,
                        btn2,
                        btn3,
                        btn4,
                        btn5,
                        }
            };
            

        }

       
    }
}