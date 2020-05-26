using System;

using Xamarin.Forms;

namespace XF.GBCarReg.Droid.Controls
{
    public class VrmEntryRenderer : ContentPage
    {
        public VrmEntryRenderer()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

