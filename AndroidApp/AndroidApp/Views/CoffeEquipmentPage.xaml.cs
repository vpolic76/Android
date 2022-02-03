using AndroidApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeEquipmentPage : ContentPage
    {
        public CoffeEquipmentPage()
        {
            InitializeComponent();
            //IncreaseCount = new Command(OnIncrease);
            //BindingContext = this;
            
            //BindingContext = new CoffeEquipmentViewModel();
        }
        //int count = 0;
        //private string countDisplay;

        //public string CountDisplay
        //{
        //    get => countDisplay;
        //    set
        //    {
        //        if (value == countDisplay)
        //            return;

        //        countDisplay = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public ICommand IncreaseCount { get; }

        //void OnIncrease()
        //{
        //    count++;
        //    CountDisplay = $"Ukupno si kliknuo {count} puta.";
        //}


        //private void ButtonClick_Clicked(object sender, EventArgs e)
        //{
        //    count++;
        //    CountDisplay = $"Ukupno si kliknuo {count} puta.";

        //}
    }
}