using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNotas_Janier_Urbina    
{
    [Activity(Label = "splashActivity", Theme="@style/SplashTheme", MainLauncher =true, NoHistory =true,
        ConfigurationChanges =Android.Content.PM.ConfigChanges.ScreenSize)]
    public class splashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(500);
            StartActivity(new Intent(Application.Context, typeof(ActivityListaAlumnos)));
        
            // Create your application here
        }
    }
}