using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App424
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private static ISettings AppSettings =>  CrossSettings.Current;

        public static string LastPickValue
        {
            get => AppSettings.GetValueOrDefault(nameof(LastPickValue), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(LastPickValue), value);
        }

        public MainPage()
        {
            InitializeComponent();


            List<string> list = new List<string>();
            list.Add("Right1");
            list.Add("Right2");
            list.Add("Right3");
            list.Add("Right4");

            drainlocationPicker1.ItemsSource = list;

            //Set the default value
            drainlocationPicker1.SelectedItem = LastPickValue;
        }

        private void DrainlocationPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nlocation1 = (string)drainlocationPicker1.SelectedItem;

            LastPickValue = nlocation1;
        }
    }
}
