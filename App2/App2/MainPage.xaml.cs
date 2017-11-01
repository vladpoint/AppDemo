using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App2;
using SQLite;
using Microsoft.WindowsAzure.MobileServices;

namespace App2
{

    public class Datos
    {
        public static Label label1 = new Label();
        public static Button boton = new Button();
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Nombre.IsVisible = false;
            Apellidos.IsVisible = false;
            Matricula.IsVisible = false;
            DisplayAlert("Datos ingresados", "Hola " + Nombre.Text + " " + Apellidos.Text + " " + Matricula.Text, "Ok","Cancel");
            Navigation.PushAsync(new Calculadora());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Nombre.IsVisible = true;
            Apellidos.IsVisible = true;
            Matricula.IsVisible = true;
        }
    }
}
