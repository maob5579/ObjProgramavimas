using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;

namespace MoodFull
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        Button _button;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _button = FindViewById<Button>(Resource.Id.loginButton);

            _button.Click += delegate
            {
                HandleLogin();
            };
        }

        private void HandleLogin()
        {
            Toast.MakeText(this, "Hello", ToastLength.Long).Show();
            StartActivity(typeof(Activities.MainWindowActivity));
        }
    }
}