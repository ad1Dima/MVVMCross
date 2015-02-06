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

namespace AndroidApp
{
    public class CustomControl : RelativeLayout
    {

        private string text;

        #region Constructors
        public CustomControl(Context context)
            : base(context)
        {
        }

        public CustomControl(Context context, global::Android.Util.IAttributeSet attrs)
            : base(context, attrs)
        {
        }
        public CustomControl(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
        #endregion

        /// <summary>
        /// Binding to this prop not working
        /// </summary>
        public string Text1
        {
            set
            {
                this.text = value;
            }
        }

        /// <summary>
        /// But works for this
        /// </summary>
        public string Text2
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                this.text = value;
            }
        }
    }
}