using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Splash_Screen.Droid
{
    [Activity(Label = "Splash_Screen", Icon = "@mipmap/icon", Theme = "@style/SplachTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplachScreen : Activity
    {
        protected override void OnCreate(Bundle saveInstanceState)
        {
            base.OnCreate(saveInstanceState);
            StartActivity(typeof(MainActivity));
            Thread.Sleep(3000);
            Finish();
            OverridePendingTransition(0, 0);
        }
    }
}