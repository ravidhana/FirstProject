using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using Android.Widget;
using System;

//namespace FirstXAndroid
namespace FirstXAndroid
//[Activity(Label = "FirstXAndroid", MainLauncher = true)]
{
    [Activity(Label = "FirstXAndroid")]
    //public class MainActivity : Activity
    public class MainActivity : Activity
    {

        static readonly string TAG = "X:" + typeof(MainActivity).Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //Initializing button from layout
            Button login = FindViewById<Button>(Resource.Id.btnSave);

            //Login button click action
            login.Click += (object sender, EventArgs e) => {
                Android.Widget.Toast.MakeText(this, "Login Button Clicked!", Android.Widget.ToastLength.Short).Show();
            };

            Log.Debug(TAG, "MainActivity is loaded.");
          
        }
    }
}

