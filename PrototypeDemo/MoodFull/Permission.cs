using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace MoodFull
{
    static class Permission
    {
        const int RequestLocationId = 0;

        public static void TryToGetCameraPermissions(AppCompatActivity activity)
        {    
            if ((int)Build.VERSION.SdkInt >= 23)
            {
                string[] permissionsGroupLocation =
                {
                    Android.Manifest.Permission.Camera
                };

                GetPermissions(Android.Manifest.Permission.Camera, activity, permissionsGroupLocation);
                return;
            }
        }

        private static void GetPermissions(string permission, AppCompatActivity _activity, string[] permissionsGroupLocation)
        {
            if (_activity.CheckSelfPermission(permission) == (int)Android.Content.PM.Permission.Granted)
            {
                Toast.MakeText(_activity, "Permission granted", ToastLength.Short).Show();
                return;
            }

            if (_activity.ShouldShowRequestPermissionRationale(permission))
            {
                //set Alert for executing task
                Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(_activity);
                alert.SetTitle("Permission Needed");
                alert.SetMessage("Need permission to continue");
                alert.SetPositiveButton("Request permission", (senderAlert, args) =>
                {
                    _activity.RequestPermissions(permissionsGroupLocation, RequestLocationId);
                });

                alert.SetNegativeButton("Cancel", (sendAlert, args) =>
                {
                    Toast.MakeText(_activity, "Cancelled", ToastLength.Short).Show();
                });

                Dialog dialog = alert.Create();
                dialog.Show();

                return;
            }
            _activity.RequestPermissions(permissionsGroupLocation, RequestLocationId);
        }
    }
}