using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Microsoft.WindowsAzure.MobileServices;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<TESHDatos> Items { get; set; }
        //SQLiteConnection database;
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<TESHDatos> Tabla;
        public static MobileServiceUser usuario;
        public DataPage()
        {
            InitializeComponent();
            //string db;
            //db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db3");
            //database = new SQLiteConnection(db);
            cliente = new MobileServiceClient(AzureConnection.AzureURL);
            //database.CreateTable<TESHDatos>();
            Tabla = cliente.GetTable<TESHDatos>();
            //var elemento = new TESHDatos
            //{
            //    Dato1 = "Rodrigo",
            //    Dato2 = "Perez"
            //};
            ////database.Insert(elemento);
            //Tabla.InsertAsync(elemento);           
        }
        private void Evento_Insertar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as TESHDatos));

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }
        private async void LeerTabla()
        {
            IEnumerable<TESHDatos> elementos = await Tabla.ToEnumerableAsync();
            Items = new ObservableCollection<TESHDatos>(elementos);
            BindingContext = this;
            Lista.ItemsSource = Items;
        }

        private async void Login(object sender, EventArgs e)
        {
            try
            { 
                if (App.Authenticator != null)
                {
                    usuario = await App.Authenticator.Authenticate();

                    if (usuario != null)
                    {
                        await DisplayAlert("Usuario Autenticado", usuario.UserId, "ok");
                        LeerTabla();
                    }
                    if (usuario == null)
                    {
                        Boton_Insertar.IsVisible = false;
                        Boton_Insertar.IsEnabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ok");
            }
        }

        private async void Eliminados(object sender, EventArgs e)
        {
            IEnumerable<TESHDatos> elementos = await Tabla.IncludeDeleted().ToEnumerableAsync();
            Items = new ObservableCollection<TESHDatos>(elementos);
            BindingContext = this;
            Lista.ItemsSource = Items.Where(dato => dato.Deleted == true) ;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (usuario != null)
            {
                LeerTabla();
            }
        }
    }
    
}