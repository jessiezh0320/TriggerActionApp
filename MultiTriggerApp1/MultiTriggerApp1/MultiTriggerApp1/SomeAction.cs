using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MultiTriggerApp1
{
    public class SomeAction:TriggerAction<Label>
    {
        protected override void Invoke(Label sender)
        {
            Debug.WriteLine("=====> SomeAction Invoked !!!");

            Application.Current.MainPage.DisplayAlert("", "All Values are True!!!", "OK");
        }
    }
}
