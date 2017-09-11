using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practice2
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //MainPage = new Practice2.MainPage();
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            
                            Text = "Student:  Sergio Arturo Contreras Gonzalez  !",
                        },
                         new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "TECNOLOGICO DE ESTUDOS SUPERIORES DE HUIXQUILUCAN",
                        }
                         ,
                         new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Matricula: 12090098",
                        }

                         

                    }
                }
            };


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

/* Student: CONTRERAS GONZALEZ SERGIO ARTURO
 * 
 * Question 1: What Is Difference between Portable (CPL) and Shared (SAP) projects?
The sharing is more practical for rapid application development besides that molds itself to small teams and usually more robust than the native.

Question 2: What are the requirements to configure Xamarin Mac Agent?
Is required  one SO mac, to compile the app, or failing to mount a virtual machine with the SO mac.
Question 3: How many projects you have and why you need all?
I have 4 projects are created automatically as they are shared, and are necessary for the development of the various platforms
*/
