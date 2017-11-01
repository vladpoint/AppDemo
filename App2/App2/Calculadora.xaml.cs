using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculadora : ContentPage
	{
        public class Datos
        {
            public static Double dato1 = new Int32();
            public static Double dato2 = new Int32();
            public static Double local1 = new Int32();
            public static Char operacion = new Char();
        }
		public Calculadora ()
		{
			InitializeComponent ();
		}
        public void Cero_Clicked(object sender, EventArgs e)
        {
            if (!(caja.Text == "0"))
                {
                caja.Text = caja.Text + "0";
            }
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Uno_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Dos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Tres_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Cuatro_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Cinco_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Seis_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Siete_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Ocho_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        public void Nueve_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
            Datos.dato1 = Convert.ToDouble(caja.Text);
        }
        private void Suma_Clicked(object sender, EventArgs e)
        {
            Datos.operacion = '+';
            caja.Text = null;
        }
        private void Resta_Clicked(object sender, EventArgs e)
        {
            Datos.operacion = '-';
            caja.Text = null;
        }
        private void Division_Clicked(object sender, EventArgs e)
        {
            Datos.operacion = '/';
            caja.Text = null;
        }
        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            Datos.operacion = '*';
            caja.Text = null;
        }
        private void Resultado_Clicked(object sender, EventArgs e)
        {
            if (Datos.operacion == '+')
            {
                Datos.local1 = Datos.local1 + Datos.dato1;
                Datos.dato2 = Datos.local1;
            }
            else if (Datos.operacion == '-')
            {
                Datos.local1 = Datos.local1 - Datos.dato1;
                Datos.dato2 = Datos.local1;
            }
            else if (Datos.operacion == '*')
            {
                Datos.local1 = Datos.local1 * Datos.dato1;
                Datos.dato2 = Datos.local1;
            }
            else if (Datos.operacion=='/')
            {
                Datos.local1 = Datos.local1 / Datos.dato1;
                Datos.dato2 = Datos.local1;
            }
            caja.Text = Convert.ToString (Datos.dato2);
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            caja.Text = null;
            Datos.dato1 = 0;
            Datos.dato2 = 0;
            Datos.local1 = 0;
        }
        private void Clearlast_Clicked(object sender, EventArgs e)
        {
            caja.Text = null;
        }
        private void Punto_Clicked(object sender, EventArgs e)
        {
            if (!caja.Text.Contains("."))
            {
                caja.Text = caja.Text + ".";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MasterDetailPage1()));
        }
    }
}