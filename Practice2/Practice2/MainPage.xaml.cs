using Practice2.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            var dat = new dataviewmodel();
            listaimg.BindingContext = dat;

        }

        // de un listview como obtener el click de un boton y posicion 
        class dataviewmodel : INotifyPropertyChanged
        {
            public ObservableCollection<Imagenes> listadatos { get; set; }
            
            public dataviewmodel()
            {
                listadatos = new ObservableCollection<Imagenes>(Datos.Datosinit());
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }



        //private void MostrarOnClicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new PracAlerta());

        //}
        //private void MostrarOnClick(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new datospersonales());

        //}
        //private void MostrarOnCli(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new calculadora());

        //}
    }
}
