using Android.App;
using Android.Widget;
using Android.OS;

namespace Popup_Menu_Example
{
    [Activity(Label = "Popup_Menu_Example", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button showPopupButton = FindViewById<Button>(Resource.Id.popupButton);

            showPopupButton.Click += (s, args) =>
            {
                PopupMenu popupMenu = new PopupMenu(this,showPopupButton);
                // 版面設定
                popupMenu.Inflate(Resource.Menu.popup_menu);

                // 點擊事件
                popupMenu.MenuItemClick += (s1, args1) =>
                {
                    Toast.MakeText(this,string.Format("{0} selected", args1.Item.TitleFormatted),ToastLength.Short).Show();
                };

                // 註銷事件
                popupMenu.DismissEvent += (s2, args2) =>
                {
                    Toast.MakeText(this, "menu dismissed ", ToastLength.Short).Show();
                };

                popupMenu.Show();
            };
        }
    }
}

