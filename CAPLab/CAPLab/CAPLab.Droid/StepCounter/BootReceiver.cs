using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CAPLab.Droid.StepCounter
{
    [BroadcastReceiver]
    [IntentFilter(new[] { "android.intent.action.BOOT_COMPLETED", "android.intent.action.MY_PACKAGE_REPLACED" })]
    public class BootReceiver : BroadcastReceiver 
    {
        public override void OnReceive(Context context, Intent intent)
        {
            var stepServiceIntent = new Intent(context, typeof(StepService));
            context.StartService(stepServiceIntent);
        }
    }
}