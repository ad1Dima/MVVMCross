using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidApp
{
    class StartApplicationObject : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            this.ShowViewModel<FirstViewModel>();
        }
    }
}
