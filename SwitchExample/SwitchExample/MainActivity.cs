using Android.App;
using Android.Widget;
using Android.OS;

namespace SwitchExample
{
    [Activity(Label = "SwitchExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Switch s = FindViewById<Switch>(Resource.Id.monitored_switch);
            s.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                var toast = Toast.MakeText(this, "Your answer is " +
                (e.IsChecked ? "correct" : "incorrect"), ToastLength.Short);
                toast.Show();
            };
        }
    }
}

