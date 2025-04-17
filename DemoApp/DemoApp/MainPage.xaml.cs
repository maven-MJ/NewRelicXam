using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelic.Xamarin.Plugin;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                string value = null;
                int length = value.Length;

                //int.Parse("not a number");
            }
            catch (Exception ex)
            {
               // CrossNewRelicClient.Current.RecordException(ex);
            }
        }
    }
}

