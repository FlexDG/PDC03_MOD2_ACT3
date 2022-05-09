using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

            private async void Act1(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new Activity3());
            }
        }
    }

