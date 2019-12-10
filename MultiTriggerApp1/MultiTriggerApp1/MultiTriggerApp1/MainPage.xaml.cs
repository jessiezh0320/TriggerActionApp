using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiTriggerApp1
{
    public partial class MainPage : ContentPage
    {
        MyViewModel myVM;

        public MainPage()
        {
            InitializeComponent();

            myVM = new MyViewModel();
            BindingContext = myVM;
        }

        void OpenSubTemplate_Clicked(object sender, EventArgs args)
        {
            myContent.ControlTemplate = (ControlTemplate)Resources["subTemplate"];
        }

        void AllTrueValue_Clicked(object sender, EventArgs args)
        {
            myVM.ValueA = true;
            myVM.ValueB = true;

           
            myContent.ControlTemplate = (ControlTemplate)Resources["mainTemplate"];
        }
    }
}
