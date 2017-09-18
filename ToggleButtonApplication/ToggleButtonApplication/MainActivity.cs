using Android.App;
using Android.Widget;
using Android.OS;

namespace ToggleButtonApplication
{
    [Activity(Label = "ToggleButtonApplication", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ToggleButton toggleButton = FindViewById<ToggleButton>(Resource.Id.toggleButton);
            toggleButton.Click += (o, s) => {
                if(toggleButton.Checked)
                {
                    Toast.MakeText(this, "Checked", ToastLength.Short).Show();
                }
                else
                {
                    Toast.MakeText(this, "Not Checked", ToastLength.Short).Show();
                }
            };
        }
    }
}

