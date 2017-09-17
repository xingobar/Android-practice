using Android.App;
using Android.Widget;
using Android.OS;

namespace Notification
{
    [Activity(Label = "Notification", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            string[] countries = Resources.GetStringArray(Resource.Array.countries_array);

            AutoCompleteTextView autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autocomplete_country);
            var adapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, countries);
            autoCompleteTextView.Adapter = adapter; 

        }
    }
}

