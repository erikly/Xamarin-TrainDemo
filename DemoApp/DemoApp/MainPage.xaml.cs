using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Views;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TrainListView.ItemsSource = FakeRepo.Data;
        }

        public void OnTap(object sender, EventArgs e)
        {
            var cell = sender as TextCell;
            var train = FakeRepo.Find((int)cell.CommandParameter);
            var page = new ControlTrainView(train);
            Navigation.PushAsync(page);
        }
    }
}
