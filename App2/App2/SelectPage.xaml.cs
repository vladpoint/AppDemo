using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        //SQLiteConnection database;
        public SelectPage(object selectedItem)
        {
            var dato = selectedItem as TESHDatos;
            BindingContext = dato;
            InitializeComponent();
            if(DataPage.usuario == null)
            {
                Entry_Nombre.IsEnabled = false;
                Entry_Apellido.IsEnabled = false;
                Button_Actualizar.IsVisible = false;
                Button_Eliminar.IsVisible = false;
                Button_Actualizar.IsEnabled = false;
                Button_Eliminar.IsEnabled = false;
            }
            //string db;
            //db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db3");
            //database = new SQLiteConnection(db);
        }
        private async void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Id = Entry_Id.Text,
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text
            };
            await DataPage.Tabla.UpdateAsync(datos);
            await Navigation.PushAsync(new DataPage());
        }
        private async void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Id = Entry_Id.Text,
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text
            };
            await DataPage.Tabla.DeleteAsync(datos);
            await Navigation.PushAsync(new DataPage());
        }
    }
}