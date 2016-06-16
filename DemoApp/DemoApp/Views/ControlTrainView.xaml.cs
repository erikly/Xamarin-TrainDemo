using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Models;
using Xamarin.Forms;

namespace DemoApp.Views
{
    public partial class ControlTrainView : ContentPage
    {
        private Train train;
        public ControlTrainView(Train train)
        {
            InitializeComponent();

            this.train = train;
            TrainName.Text = train.Name;
            TrainFunctionList.ItemsSource = train.Functions;
        }


        public void CallTrainFunction(object sender, EventArgs e)
        {
            var button = sender as Button;
            var functionId = (int)button.CommandParameter;
            DisplayAlert("Funksjonskall", "Kaller funksjon " + train.Functions.Single(f => f.Id == functionId).Name + " med Id " + functionId + " på toget " + train.Name, "Ok");
        }
    }
}
