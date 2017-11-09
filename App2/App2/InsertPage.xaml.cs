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
    public partial class InsertPage : ContentPage
    {
        //SQLiteConnection database;
        public InsertPage()
        {
            InitializeComponent();
            //string db;
            //db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db3");
            //database = new SQLiteConnection(db);
        }
        private async void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text
            };
            await DataPage.Tabla.InsertAsync(datos);
            //database.Insert(datos);
            await Navigation.PopAsync();
        }
    }
}