using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CAPLab
{
    public partial class greetPage : ContentPage
    {
        public greetPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("CAPLab app", "Hello World", "Done.");
        }
    }
}
