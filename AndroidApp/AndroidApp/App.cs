using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;

namespace AndroidApp
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public App()
        {
            var startApplicationObject = new StartApplicationObject();
            Mvx.RegisterSingleton<IMvxAppStart>(startApplicationObject);
        }
    }
}