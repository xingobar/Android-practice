using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace RadioButtonApplication
{
    [Activity(Label = "RadioButtonApplication", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            RadioButton radio_red = FindViewById<RadioButton>(Resource.Id.radio_red);
            RadioButton radio_blue = FindViewById<RadioButton>(Resource.Id.radio_blue);

            radio_red.Click += RadioButtonClick;
            radio_blue.Click += RadioButtonClick;
        }
        private void RadioButtonClick(object sender,EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            Toast.MakeText(this, rb.Text, ToastLength.Short).Show();
        }
    }
}

