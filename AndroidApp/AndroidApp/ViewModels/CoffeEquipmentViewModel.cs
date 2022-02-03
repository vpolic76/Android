using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
//using Xamarin.Forms;

namespace AndroidApp.ViewModels
{
    public class CoffeEquipmentViewModel : BaseViewModel // ObservableObject iz MvvmHelpera, kao i BaseViewModel, ali on ima implementirane IsBussy, Title, Subtitle, Icon, IsNotBussy, CanLoadmore, Header i Footer //BindableObject
    //najlakše je napraviti ViewModelBase klasu koju će svi nasljeđivati, a u njoj postaviti sve propertije iz BaseViewModel
    {
        ObservableRangeCollection<string> Coffe { get;  }
        public CoffeEquipmentViewModel()
        {
            Coffe = new ObservableRangeCollection<string>();
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer); // stari način bez mvvmhelpera: new Command(async ()=> await CallServer());
            Title = "Neki naslov";
            Subtitle = "Podnaslov";

        }
        int count = 0;
        private string countDisplay;

        public string CountDisplay
        {
            get => countDisplay; 
            set => SetProperty(ref countDisplay, value); //MvvmHelper metoda 
            //set
            //{
            //    if (value == countDisplay)
            //        return;

            //    countDisplay = value;
            //    OnPropertyChanged();
            //}
        }

        public ICommand IncreaseCount { get; }
        public ICommand CallServerCommand { get; }  
        void OnIncrease()
        {
            count++;
            CountDisplay = $"Ukupno si kliknuo {count} puta.";
        }
        async Task CallServer() {
            // ObservableCollection - stari način
            //Coffe.Add("Bijela kava");
            //Coffe.Add("Kava s mlijekom");
            //Coffe.Add("Machiatto");

            //MvvmHelpers ObservableRangeCollection
            var items = new List<string> { "Crna kava", "Bijela kava", "Kav s mlijekom" };
            Coffe.AddRange(items);

        }
    }
}
