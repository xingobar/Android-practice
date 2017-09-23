using Android.App;
using Android.Widget;
using Android.OS;

namespace SpinnerExample
{
    [Activity(Label = "SpinnerExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            ArrayAdapter arrayAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);
            arrayAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = arrayAdapter;
            spinner.ItemSelected += new System.EventHandler<AdapterView.ItemSelectedEventArgs>(SpinnerItemSelected);
        }

        private void SpinnerItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = sender as Spinner;
            string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Short).Show();
        }
    }
}

