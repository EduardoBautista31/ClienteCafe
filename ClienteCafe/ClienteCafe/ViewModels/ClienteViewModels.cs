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
        
        public Platillo Platillo { get; set; }

        public string Error = "";
        public ClienteViewModels()
        {
            Platillo = new Platillo();
            EnviarCommand = new Command(Enviar);
           


        }


        public async void Enviar()
        {
            try
            {
                
                
               await servicio.PedidoPOST(Platillo);
              
               
               
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
