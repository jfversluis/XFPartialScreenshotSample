using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImageFromXamarinUI;

namespace XFPartialScreenshotSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var imageStream = await header.CaptureImageAsync();
            ResultImage.Source = ImageSource.FromStream(() => imageStream);
        }
    }
}
