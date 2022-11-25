using ClienteCafe.Models;
using ClienteCafeteria.Droid.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CafeteriaCliente.ViewModels
{
    public class ClienteViewModels : INotifyPropertyChanged
    {
        CafeteriasServices servicio = new CafeteriasServices();
        public ICommand EnviarCommand { get; set; }
        
        public Platillo Platillo = new Platillo();

        public string Error = "";
        public ClienteViewModels()
        {
           
            EnviarCommand = new Command(Enviar);
           


        }


        public async void Enviar()
        {
            try
            {
                Platillo entidad = new Platillo();
                entidad.NumeroMesa = Platillo.NumeroMesa;
                entidad.CantidadPlatillos1 = Platillo.CantidadPlatillos1;
                entidad.CantidadPlatillos2 = Platillo.CantidadPlatillos2;
                entidad.CantidadPlatillos3 = Platillo.CantidadPlatillos3;
                entidad.CantidadPlatillos4 = Platillo.CantidadPlatillos4;
               await servicio.PedidoPOST(entidad);
              
               
               
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
