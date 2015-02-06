using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidApp
{
    public class FirstViewModel : MvxViewModel
    {
        public string Hello
        {
            get
            {
                return "this binding works";
            }
        }

    }
}
