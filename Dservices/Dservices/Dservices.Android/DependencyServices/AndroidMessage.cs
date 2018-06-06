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
using Dservices.DependencyServices;
using Dservices.Droid.DependencyServices;
using Xamarin.Forms;

[assembly:Dependency(typeof(AndroidMessage))]
namespace Dservices.Droid.DependencyServices
{
    public class AndroidMessage : IPlatMessage
    {
        public string getMessage()
        {
            return "Esto es Android";
        }
    }
}